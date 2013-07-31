using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hyperlinq
{
    public abstract class HObject
    {
        public virtual XObject ToXml ()
        {
            return null;
        }

        public override string ToString ()
        {
            return "" + ToXml ();
        }
    }

    public abstract class HNode : HObject
    {
        public readonly IEnumerable<HNode> Children;

        public HNode (IEnumerable<object> children)
        {
            if (children != null)
                this.Children = children.SelectMany (c =>
                    c is HNode ? new[] { (HNode)c } :
                    c is IEnumerable<HNode> ? (IEnumerable<HNode>)c :
                    c == null ? new HNode[0] :
                    new[] { new HText (c.ToString ()) });
        }
    }

    public class HLiteral : HNode
    {
        public readonly string Text;
        public HLiteral (string text)
            : base (null)
        {
            this.Text = text;
        }

        public override XObject ToXml ()
        {
            return XElement.Parse (Text);
        }
    }


    public class HElement : HNode
    {
        static readonly string[] EmptyTags = new[] { "area","base","basefont","br","col","frame","hr","img","input","isindex","link","meta","param","source"};
        public readonly string Name;
        public readonly IEnumerable<HAttribute> Attributes;

        public HElement (string name, IChain<HAttribute> attributes, IEnumerable<object> children)
            : base (children)
        {
            this.Name = name;
            if (attributes != null)
                this.Attributes = attributes.ToEnumerable ();

            Validate ();
        }

        void Validate () // not strictly necessary, as System.Linq.Xml picks this up, but the exceptions are more helpful this way
        {
            if (string.IsNullOrEmpty (Name))
                throw new Exception ("Element name cannot be null or empty.");

            if (Attributes != null)
            {
                if (this.Attributes.Any (a => a.Name == null || a.Value == null))
                    throw new InvalidOperationException (string.Format ("Element '{0}' has attributes with null names or values", Name));

                var attributeNames = this.Attributes.Select(a => a.Name);
                if (attributeNames.Distinct().Count () != attributeNames.Count ())
                {
                    var duplicates = attributeNames.GroupBy (a => a).Where (g => g.Count () > 1);
                    throw new InvalidOperationException (string.Format ("Element '{0}' has duplicate attributes '{1}'",
                        Name, string.Join (" , ", duplicates.Select(a => a.Key))));
                }
            }
        }
        
        public override XObject ToXml ()
        {
            var attXml = Attributes == null ? new XNode[0] : Attributes.Select (a => a.ToXml ());
            var kidXml = Children.EmptyNotNull ().Where (c => c != null).Select (c => c.ToXml ());
            var content = attXml.Concat (kidXml);

            var addClosingTag = ! kidXml.Any () && ! EmptyTags.Contains (Name);

            if (addClosingTag)
                content = content.Concat (new[] { new XText ("") }); // ensures closing tag occurs
            
            return new XElement (Name, content);
        }

        public override string ToString ()
        {
            return ToXml ().ToString ();
        }
    }

    public class HDoc : HElement
    {
        public HDoc (IEnumerable<HNode> children) : base ("html", null, children) { }
    }

    public class HText : HNode
    {
        public readonly string Text;
        public HText (string text)
            : base (null)
        {
            this.Text = text;
        }

        public override XObject ToXml ()
        {
            return new XText (Text);
        }

        
        public override bool Equals (object obj)
        {
            if (obj == null || !(obj is HText))
                return false;
            var other = (HText)obj;
            return Text == other.Text;
        }

        public override int GetHashCode ()
        {
            return Text.GetHashCode ();
        }
    }

    public class HAttribute : HObject
    {
        public readonly string Name;
        public readonly object Value;

        public HAttribute () { Name = null; Value = null; }

        public HAttribute (string name, object value) { this.Name = name; this.Value = value; }

        public virtual HAttribute Create (string name, object value) { throw new InvalidOperationException (); }

        public override XObject ToXml ()
        {
            return new XAttribute (Name, Value);
        }

        public override bool Equals (object obj)
        {
            if (obj == null || !(obj is HAttribute))
                return false;
            var other = (HAttribute)obj;
            return Name == other.Name && Value == other.Value;
        }

        public override int GetHashCode ()
        {
            return Name.GetHashCode () ^ Value.GetHashCode ();
        }
    }
}
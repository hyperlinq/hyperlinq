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
    // work in progress.

    public interface IHyperlinqInput
    {      
        string Id { get; }
        object Label { get; }
        HElement ToElement (IEnumerable<HAttribute> customAttributes);
        bool IsRequired { get; }
    }

    public abstract class HInput : IHyperlinqInput
    {
        public object Label { get; private set; }
        public object Data { get; private set; }
        public string Id { get; private set; }
        public Type DataType { get; private set; }
        public MemberInfo Member {get; private set;}
        public bool IsRequired { get; private set; }

        public abstract HElement ToElement (IEnumerable<HAttribute> customAttributes);

        public HElement ToElement () { return ToElement (null); }

        public HInput (Expression<Func<object>> idExpression, object label = null)
        {
            Member = GetMemberInfoFromExpression (idExpression);
            Id = Member.Name;
            DataType = Member is PropertyInfo ? ((PropertyInfo)Member).PropertyType : ((FieldInfo)Member).FieldType;
            Data = idExpression.Compile()();
            Label = label ?? StringHelper.CSharpNameToFriendlyName (Id);
            IsRequired = HExtensions.ResolveIsRequired == null ? false : HExtensions.ResolveIsRequired (Member);
        }

        static MemberInfo GetMemberInfoFromExpression (Expression<Func<object>> expression)
        {
            var body = expression.Body is UnaryExpression ? ((UnaryExpression)expression.Body).Operand : expression.Body;
            return ((MemberExpression)body).Member;
        }
    }

    public abstract class HInput<TAttribute> : HInput
    {
        public readonly ChainFunc<TAttribute> attributes;

        public HInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<TAttribute> attributes = null) :
            base (idExpression, label)
        {
            this.attributes = attributes;
        }
    }

    public class TextInput : HInput<HAttributes.input>
    {
        public TextInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes) { }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            return H.input (a => a.type ("text").id (Id).name (Id).value (Data).JoinCustom(customAttributes).Merge(attributes));
        }
    }

    public class TextAreaInput : HInput<HAttributes.textarea>
    {
        public TextAreaInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<HAttributes.textarea> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            return H.textarea (a => a.id (Id).name (Id).JoinCustom (customAttributes).Merge(attributes), Data);
        }
    }

    public class NumericInput : HInput<HAttributes.input>
    {
        public NumericInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            return H.input (a => a.type ("number").id (Id).name (Id).value(Data).JoinCustom(customAttributes).Merge(attributes));
        }
    }

    public class EmailInput : HInput<HAttributes.input>
    {
        public EmailInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            return H.input (a => a.type ("email").id (Id).name (Id).value (Data).JoinCustom (customAttributes).Merge (attributes));
        }
    }

    public class RadioButtonInput : HInput<HAttributes.input>
    {
        public RadioButtonInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            var nonNullableType = DataType.GetNonNullableType();
            var options = Enum.GetNames(nonNullableType).Zip(Enum.GetValues(nonNullableType).Cast<object>(), (name, value) => new { name, value });
            return
                H.div (
                    from option in options
                    let checkedValue = object.Equals (option.value, Data) ? "checked" : null 
                    select H.div
                    (
                        H.input (a => a.type ("radio").name (Id).value ("" + option.value).@checked (checkedValue).JoinCustom(customAttributes).Merge(attributes), option.name)
                    )
                );
        }
    }

    public class DropDownInput : HInput<HAttributes.select>
    {
        IEnumerable<KeyValuePair<object, string>> options;

        public DropDownInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<HAttributes.select> attributes = null,
            IEnumerable<KeyValuePair<object,string>> options = null)
            : base (idExpression, label, attributes)
        {
            this.options = options;
        }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            options = options ?? EnumHelper.ValuesWithNamesCanonical (DataType);

            var placeholder = new[] {H.option (a => a.value (""))};

            return
                H.select (a => a.name(Id).JoinCustom(customAttributes).Merge(attributes),
                    placeholder.Concat
                    (
                        from option in options
                        let selectedValue = object.Equals (option.Key, Data) ? "true" : null
                        select H.div
                        (
                            H.option (a => a.value ("" + option.Key).selected(selectedValue), option.Value)
                        )
                    )
                );
        }
    }

    public class CheckboxInput : HInput<HAttributes.input>
    {
        public CheckboxInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            return H.input (a => a.type ("checkbox").id (Id).name (Id).value (Data).JoinCustom(customAttributes).Merge (attributes));
        }
    }

    public class HiddenInput : HInput<HAttributes.input>
    {
        public HiddenInput (Expression<Func<object>> idExpression, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, null, attributes)
        { }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            return H.input (a => a.type ("hidden").id (Id).name (Id).value(Data).JoinCustom(customAttributes).Merge(attributes));
        }
    }

    public class PasswordInput : HInput<HAttributes.input>
    {
        public PasswordInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<HAttributes.input> attributes = null) : base (idExpression, label, attributes) { }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            return H.input (a => a.type ("password").id (Id).name (Id).value (Data).JoinCustom (customAttributes).Merge (attributes));
        }
    }

    public class DateInput : HInput<HAttributes.input>
    {
        public DateInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            var value = object.Equals (Data, default (DateTime)) ? null : ((DateTime)Data).ToString ("dd MMM yyyy");
            return H.input (a => a.type ("text").id (Id).name (Id).value (value).JoinCustom (customAttributes).Merge (attributes));
        }
    }

    public class FileInput : HInput<HAttributes.input>
    {
        public FileInput (Expression<Func<object>> idExpression, object label = null, ChainFunc<HAttributes.input> attributes = null) : base (idExpression, label, attributes) { }

        public override HElement ToElement (IEnumerable<HAttribute> customAttributes)
        {
            return H.input (a => a.type ("file").id (Id).name (Id).value (Data).JoinCustom (customAttributes).Merge (attributes));
        }
    }
}
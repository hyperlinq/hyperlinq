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

    public abstract class HInput
    {
        public string Label;       
        public object Value;
        public string Id;
        public Type DataType;
            
        public abstract HElement Render ();

        public HInput (Expression<Func<object>> idExpression, string label = null)
        {
            var member = GetMemberInfoFromExpression (idExpression);
            Id = member.Name;
            DataType = member is PropertyInfo ? ((PropertyInfo)member).PropertyType : ((FieldInfo)member).FieldType;
            Value = idExpression.Compile()();
            Label = label ?? Id;
        }

        static MemberInfo GetMemberInfoFromExpression (Expression<Func<object>> expression)
        {
            var body = expression.Body is UnaryExpression ? ((UnaryExpression)expression.Body).Operand : expression.Body;
            return ((MemberExpression)body).Member;
        }
    }

    public abstract class HInput<TAttribute> : HInput
    {
        public ChainFunc<TAttribute> extraAttributes;

        public HInput (Expression<Func<object>> idExpression, string label = null, ChainFunc<TAttribute> extraAttributes = null) :
            base (idExpression, label)
        {
            this.extraAttributes = extraAttributes;
        }
    }

    public class TextInput : HInput<HAttributes.input>
    {
        public TextInput (Expression<Func<object>> idExpression, string label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes) { }
       
        public override HElement Render ()
        {
            return H.input (a => a.type ("text").id (Id).name (Id).value (Value).Merge(extraAttributes));
        }
    }

    public class TextAreaInput : HInput<HAttributes.textarea>
    {
        public TextAreaInput (Expression<Func<object>> idExpression, string label = null, ChainFunc<HAttributes.textarea> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement Render ()
        {
            return H.textarea (a => a.id (Id).name (Id).Merge(extraAttributes), Value);
        }
    }

    public class NumericInput : HInput<HAttributes.input>
    {
        public NumericInput (Expression<Func<object>> idExpression, string label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement Render ()
        {
            return H.input (a => a.type ("number").id (Id).name (Id).value(Value).Merge(extraAttributes));
        }
    }

    public class RadioButtonInput : HInput<HAttributes.input>
    {
        public RadioButtonInput (Expression<Func<object>> idExpression, string label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement Render ()
        {
            var nonNullableType = DataType.GetNonNullableType();
            var options = Enum.GetNames(nonNullableType).Zip(Enum.GetValues(nonNullableType).Cast<object>(), (name, value) => new { name, value });
            return
                H.div (
                    from option in options
                    let checkedValue = object.Equals (option.value, Value) ? "checked" : null 
                    select H.div
                    (
                        H.input (a => a.type ("radio").name (Id).value ("" + option.value).@checked (checkedValue).Merge(extraAttributes), option.name)
                    )
                );
        }
    }

    public class DropDownInput : HInput<HAttributes.select>
    {
        public DropDownInput (Expression<Func<object>> idExpression, string label = null, ChainFunc<HAttributes.select> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement Render ()
        {
            var nonNullableType = DataType.GetNonNullableType ();
            var options = Enum.GetNames (nonNullableType).Zip (Enum.GetValues (nonNullableType).Cast<object> (), (name, value) => new { name, value });

            var placeholder = Value != null ? new HElement[0] :
                new[] {H.option (a => a.value ("").disabled (true).selected (true).style ("display:none"), Label)};

            return
                H.select (a => a.name(Id).Merge(extraAttributes),
                    placeholder.Concat
                    (
                        from option in options
                        let selectedValue = object.Equals (option.value, Value) ? "true" : null
                        select H.div
                        (
                            H.option (a => a.value ("" + option.value).selected(selectedValue), option.name)
                        )
                    )
                );
        }
    }

    public class CheckboxInput : HInput<HAttributes.input>
    {
        public CheckboxInput (Expression<Func<object>> idExpression, string label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement Render ()
        {
            return H.input (a => a.type ("checkbox").id (Id).name (Id).value(Value).Merge(extraAttributes));
        }
    }

    public class HiddenInput : HInput<HAttributes.input>
    {
        public HiddenInput (Expression<Func<object>> idExpression, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, null, attributes)
        { }

        public override HElement Render ()
        {
            return H.input (a => a.type ("hidden").id (Id).name (Id).value(Value).Merge(extraAttributes));
        }
    }

    public class PasswordInput : HInput<HAttributes.input>
    {
        public PasswordInput (Expression<Func<object>> idExpression, string label = null, ChainFunc<HAttributes.input> attributes = null) : base (idExpression, label, attributes) { }

        public override HElement Render ()
        {
            return H.input (a => a.type ("password").id (Id).name (Id).value(Value).Merge (extraAttributes));
        }
    }

    public class DateInput : HInput<HAttributes.input>
    {
        public DateInput (Expression<Func<object>> idExpression, string label = null, ChainFunc<HAttributes.input> attributes = null)
            : base (idExpression, label, attributes)
        { }

        public override HElement Render ()
        {
            var value = object.Equals (Value, default (DateTime)) ? null : ((DateTime)Value).ToString ("dd MMM yyyy");
            return H.input(a => a.type("text").id(Id).name(Id).value(value).Merge(extraAttributes));
        }
    }

    public class FileInput : HInput<HAttributes.input>
    {
        public FileInput (Expression<Func<object>> idExpression, string label = null, ChainFunc<HAttributes.input> attributes = null) : base (idExpression, label, attributes) { }

        public override HElement Render ()
        {  
            return H.input (a => a.type ("file").id (Id).name (Id).value(Value).Merge (extraAttributes));
        }
    }
}
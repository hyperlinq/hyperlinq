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

    public class TextInput : HInput
    {
        public TextInput (Expression<Func<object>> idExpression, string label = null) : base (idExpression, label) { }

        public override HElement Render ()
        {
            return H.input (a => a.type ("text").id (Id).name (Id), Value);
        }
    }

    public class NumericInput : HInput
    {
        public NumericInput (Expression<Func<object>> idExpression, string label = null) : base (idExpression, label) { }

        public override HElement Render ()
        {
            return H.input (a => a.type ("text").id (Id).name (Id), Value);
        }
    }

    public class RadioButtonInput : HInput
    {
        public RadioButtonInput (Expression<Func<object>> idExpression, string label = null) : base (idExpression, label) { }

        public override HElement Render ()
        {
            var options = Enum.GetNames (DataType).Zip (Enum.GetValues (DataType).Cast<object>(), (name, value) => new {name, value});
            return
                H.div (
                    options.Select (option => H.div (
                        H.input (a => a.type ("radio").name(Id).value ("" + option.value), option.name)
                    ))
                );
        }
    }

    public class CheckboxInput : HInput
    {
        public CheckboxInput (Expression<Func<object>> idExpression, string label = null) : base (idExpression, label) { }

        public override HElement Render ()
        {
            return H.input (a => a.type ("checkbox").id (Id).name (Id), Value);
        }
    }

    public class HiddenInput : HInput
    {
        public HiddenInput (Expression<Func<object>> idExpression) : base (idExpression, null) { }

        public override HElement Render ()
        {
            return H.input (a => a.type ("hidden").id (Id).name (Id).value(Value));
        }
    }

    public class PasswordInput : HInput
    {
        public PasswordInput (Expression<Func<object>> idExpression, string label = null) : base (idExpression, label) { }

        public override HElement Render ()
        {
            return H.input (a => a.type ("password").id (Id).name (Id), Value);
        }
    }

    public class DateInput : HInput
    {
        public DateInput (Expression<Func<object>> idExpression, string label = null) : base (idExpression, label) { }

        public override HElement Render ()
        {
            return H.input (a => a.type ("text").id (Id).name (Id), Value);
        }
    }

    public class FileInput : HInput
    {
        public FileInput (Expression<Func<object>> idExpression, string label = null) : base (idExpression, label) { }

        public override HElement Render ()
        {  
            return H.input (a => a.type ("file").id (Id).name (Id), Value);
        }
    }
}
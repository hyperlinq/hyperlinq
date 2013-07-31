using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyperlinq.Imp;

namespace Hyperlinq
{
    public static class SimpleUrlResolver
    {     
        public static string ResolveUrl (Expression body)
        {
            var methodCall = (MethodCallExpression)body;
                        
            var parameters = methodCall.Method.GetParameters ();

            var arguments = methodCall.Arguments.Select (arg => Expression.Lambda (arg).Compile ().DynamicInvoke (null));
            var zipped = parameters.Zip (arguments, (param, arg) => new { param = param.Name, arg });
            var noNullsZipped = zipped.Where (z => z.arg != null);          

            var parametersText = !noNullsZipped.Any () ? "" : string.Join ("", zipped.Select (z => "/" + z.arg));           
            
            var url = "/" + methodCall.Method.Name + parametersText;

            return url;
        }
    }
}
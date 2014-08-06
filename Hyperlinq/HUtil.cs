using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hyperlinq
{
    public interface IChain<out T>
    {
        IEnumerable<T> ToEnumerable ();
    }

    public class Chain<T> : IChain<T>
    {
        readonly IEnumerable<T> items;

        public Chain () {}
                
        public Chain (IEnumerable<T> items)
        {
            this.items = items;
        }
        
        public IEnumerable<T> ToEnumerable ()
        {
            return items.EmptyNotNull ();
        }
    }

    public delegate IChain<T> ChainFunc<T> (IChain<T> func);

    public static class ChainExtensions
    {    
        public static IChain<T> Join<T> (this IChain<T> x, IChain<T> y)
        {
            if (x == null && y == null) return new Chain<T> (null);
            if (x == null) return y;
            if (y == null) return x;            
            return new Chain<T> (x.ToEnumerable().Concat (y.ToEnumerable ()));
        }

        public static IChain<T> Join<T> (this IChain<T> x, T y)
        {
            return x.Join (new Chain<T> (new[] { y }));
        }

        public static IChain<T> Join<T> (this IChain<T> x, ChainFunc<T> func)
        {
            return x.Join (func == null ? null : func (null));
        }
    }

    static class EnumerableHelper
    {
        public static IEnumerable<T> EmptyNotNull<T> (this IEnumerable<T> list)
        {
            return list == null ? new T[0] : list;
        }
    }

    static class ExceptionHelper
    {
        public static T ThrowIfNull<T> (this T obj)
        {
            if (obj == null)
                throw new InvalidOperationException ("Value cannot be null");
            return obj;
        }
    }

    static class NullableHelper
    {
        public static Type GetNonNullableType(this Type t)
        {
            return Nullable.GetUnderlyingType(t) ?? t;
        }
    }

    static class EnumHelper
    {
        public static KeyValuePair<object, string>[] ValuesWithNames (Type enumType)
        {
            var nonNullableEnumType = enumType.GetNonNullableType ();            
            return Enum.GetValues (nonNullableEnumType).Cast<object> ().Zip (Enum.GetNames (nonNullableEnumType), (value, name) => new KeyValuePair<object, string> (value, name)).ToArray();
        }

        public static KeyValuePair<object, string>[] ValuesWithNamesCanonical (Type enumType)
        {
            return ValuesWithNames (enumType).Select (x => new KeyValuePair<object, string> (x.Key, StringHelper.CSharpNameToFriendlyName (x.Value))).ToArray ();
        }
    }

    static class StringHelper
    {
        public static string CSharpNameToFriendlyName (string enumName)
        {
            return
                Regex
                    .Replace (enumName, "([a-z](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", "$1 ")
                    .Replace ("_", "-");
        }
    }
}
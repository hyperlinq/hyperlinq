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
    public static class HExtensions
    {
        public static IChain<T> Custom<T> (this IChain<T> attributes, string name, object value) where T : HAttribute, new()
        {
             return attributes.Join ((T) new T().Create(name, value));
        }

        public static IChain<T> Custom<T> (this IChain<T> attributes, HAttribute attribute) where T : HAttribute, new ()
        {
            return attributes.Join ((T) new T ().Create (attribute.Name, attribute.Value));
        }

        public static IChain<T> JoinCustom<T> (this IChain<T> attributes, IEnumerable<HAttribute> customAttributes) where T : HAttribute, new ()
        {
            if (customAttributes == null) return attributes;

            return attributes.Join (new Chain<T> (customAttributes.Where (a => a != null).Select (a => (T) new T ().Create (a.Name, a.Value))));
        }

        public static IChain<T> href<T> (this IChain<T> attributes, Expression<Action> action) where T : HAttribute, IhrefAttribute, new()
        {
            return attributes.href (Url (action));
        }

        public static IChain<T> href<T,A> (this IChain<T> attributes, Expression<Action<A>> action) where T : HAttribute, IhrefAttribute, new()
        {
            return attributes.href (Url<A> (action));
        }

        public static string Url (Expression<Action> action)
        {
            return ResolveUrl (action.Body);
        }

        public static string Url<T> (Expression<Action<T>> action)
        {
            return ResolveUrl (action.Body);
        }

        public static Func<Expression, string> ResolveUrl = SimpleUrlResolver.ResolveUrl;

        public static Func<MemberInfo, bool> ResolveIsRequired;

        public static HNode Literal (string s)
        {
            // currently only handles elements
            return new HLiteral (s);
        }
    }
}
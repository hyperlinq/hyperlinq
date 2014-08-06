using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperlinq
{
    public static class HyperlinqHelper
    {
        static string MergeCss (IEnumerable<string> csses)
        {
            return string.Join (" ", csses.Where (c => !string.IsNullOrEmpty (c)));
        }

        static IChain<T> MergeCssAttributes<T> (this IChain<T> chain) where T : HAttribute, new()
        {
            if (!chain.ToEnumerable ().Any (a => a.Name == "class"))
                return chain;

            var combinedCss = MergeCss (chain.ToEnumerable ().Where (a => a.Name == "class" && a.Value != null).Select (a => "" + a.Value).ToList ());
            var cssAttribute = (T) new T().Create ("class", combinedCss);
            return new Chain<T> (chain.ToEnumerable ().Where (a => a.Name != "class").Concat (new T[] { cssAttribute }));
        }

        // this can be improved in the future to intelligently merge other types of attributes.
        // css is however the most common case.

        /// <summary>
        /// Merges two attribute chains with css-awareness. Unlike Join, which merely concatenate two chains,
        /// Merge merges multiple css attributes into a single css attribute.
        /// </summary>
        public static IChain<T> Merge<T> (this IChain<T> x, ChainFunc<T> func) where T : HAttribute, new()
        {
            return x.Join (func).MergeCssAttributes ();
        }
    }
}

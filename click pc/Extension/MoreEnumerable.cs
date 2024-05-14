using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crawl_price.Extension
{
    public static class MoreEnumerable
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> sources, Func<TSource, TKey> keySelector)
        {
            return sources.DistinctBy(keySelector, null);
        }
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> sources, Func<TSource, TKey> keySelector, IEqualityComparer<TKey>? comparer)
        {
            if (sources == null) throw new ArgumentNullException(nameof(sources));
            if (keySelector == null) throw new ArgumentNullException(nameof(keySelector));
            return _(); IEnumerable<TSource> _()
            {
                var knownKeys = new HashSet<TKey>(comparer);
                foreach (var element in sources)
                {
                    if (knownKeys.Add(keySelector(element)))
                    {
                        yield return element;
                    }
                }
            }
        }
    }
}

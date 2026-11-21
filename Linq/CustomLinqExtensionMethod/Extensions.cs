using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinqExtensionMethod
{
    public static class Extensions
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source,int? page,int? pagesize)
        {
            if (source == null)
                throw new ArgumentNullException($"{nameof(source)}");
            if (!page.HasValue)
            {
                page = 1;
               
            }
            if (!pagesize.HasValue)
            {
                pagesize = 2;
            }
            if (!source.Any())
            {
                return Enumerable.Empty<T>();
            }
              
            return source.Skip((page.Value - 1) * pagesize.Value).Take(pagesize.Value);
        }
        public static IEnumerable<T> WhereWithPaginate<T>(this IEnumerable<T> source, Func<T, bool> predicate, int? page, int? pagesize)
        {
            if (source == null)
                throw new ArgumentNullException($"{nameof(source)}");
            if (!page.HasValue)
            {
                page = 1;

            }
            if (!pagesize.HasValue)
            {
                pagesize = 2;
            }
            if (!source.Any())
                return Enumerable.Empty<T>();
            var result = Enumerable.Where(source, predicate);
            return Paginate(result,page,pagesize);
        }
    }
}

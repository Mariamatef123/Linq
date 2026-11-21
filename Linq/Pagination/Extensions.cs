using System;
using System.Collections.Generic;
using System.Text;

namespace Pagination
{
    public static class Extensions
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int pageNumber = 1, int pageSize = 10) where T : class
        {
            if(pageNumber <= 0)
            {
                pageNumber = 1;
            }
            if (pageSize <= 0)
            {
                pageSize = 10;
            }
            var total = source.Count();
            var pages = (int)Math.Ceiling((decimal)total / pageSize);
            return source.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }   
    }
}

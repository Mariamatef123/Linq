using System;
using System.Collections.Generic;
using System.Text;

namespace SharedForConvertingDataTypes
{
    public class ShippingList<T> : List<T> where T : Shipping
    {
        public IEnumerable<T> Where (Func<T, bool> predicate)
        {
            Console.WriteLine("filtering...");
            return Enumerable.Where(this, predicate);
        }
    }
}

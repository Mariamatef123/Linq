using System;
using System.Collections.Generic;
using System.Text;

namespace SharedForConvertingDataTypes
{
    public static class Extension
    {
        public static void Process<T>(this IEnumerable<T> source, string title) where T : Shipping
        {
            Console.WriteLine(title);
            foreach (var item in source)
            {
               ((Shipping)item).Start();
            }
        }
    }
}

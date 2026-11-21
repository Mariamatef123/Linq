using SharedForConvertingDataTypes;

namespace ToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            var shippingsArray = shippings.ToArray();
            Console.WriteLine($"total shippings: {shippingsArray.Length}");
            Console.WriteLine($"first shippings:");
            shippingsArray[0].Start();
        }
    }
}

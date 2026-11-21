using SharedForConvertingDataTypes;

namespace ToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            var shippingsList = shippings.ToList();
            Console.WriteLine($"total shippings: {shippingsList.Count}");
            Console.WriteLine($"first shippings:");
            shippingsList.First().Start();
        }
    }
}

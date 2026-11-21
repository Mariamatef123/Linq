using SharedForConvertingDataTypes;

namespace ToLookup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            ILookup<string, Shipping> shippingsDictionary = shippings.ToLookup(s => s.UniqueId);
            shippingsDictionary["A001"].First().Start();
            ILookup<DateTime, Shipping> dictionary2 = shippings.ToLookup(x => x.ShippingDate);
            dictionary2[new DateTime(2023, 10, 1)].Process("Today's Shipping List");
        }
    }
}

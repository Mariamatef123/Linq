using SharedForConvertingDataTypes;

namespace ToDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            Dictionary<string,Shipping> shippingsDictionary = shippings.ToDictionary(s => s.UniqueId);
            shippingsDictionary["A001"].Start();
            Dictionary<DateTime ,List<Shipping>> dictionary2 =shippings.GroupBy(x=>x.ShippingDate)
                .ToDictionary(g => g.Key, g => g.ToList());
            dictionary2[new DateTime(2023, 10, 1)].Process("Today's Shipping List");
        }
    }
}

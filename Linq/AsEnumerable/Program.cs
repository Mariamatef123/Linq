using SharedForConvertingDataTypes;

namespace AsEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;
            var todayShippings = shippings.Where(s => s.ShippingDate == DateTime.Today);//call the specific Where method in ShippingList class
            todayShippings.Process("Today's Shipping List");
           var todayShippings2 = shippings.AsEnumerable().Where(s => s.ShippingDate == DateTime.Today);//call the generic Where method in Enumerable class
            todayShippings2.Process("Today's Shipping List");  
        }
    }
}

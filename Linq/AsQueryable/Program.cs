using SharedForConvertingDataTypes;

namespace AsQueryable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;
            var todayShippings = shippings.Where(s => s.ShippingDate == DateTime.Today);//call the specific Where method in ShippingList class

            todayShippings.Process("Today's Shipping List");
            IQueryable<Shipping> todayShippings2 = shippings.AsQueryable().Where(s => s.ShippingDate == DateTime.Today);//call the generic Where method in Queryable class
            todayShippings2.Process("Today's Shipping List");
            Console.WriteLine(todayShippings2.Expression);
        }
    }
}

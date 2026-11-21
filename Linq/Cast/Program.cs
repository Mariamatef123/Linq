using SharedForConvertingDataTypes;

namespace Cast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            // var groundShippings = shippings.Cast<GroundShipping>();
            //groundShippings.Process("Ground Shipping List");//System.InvalidCastException m2dersh y7wlha
            var groundShippings = shippings.Where(x=>x.GetType() == typeof(GroundShipping)).Cast<GroundShipping>();
            groundShippings.Process("Ground Shipping List");//valid
        }
    }
}

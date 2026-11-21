using System;
using System.Collections.Generic;
using System.Text;

namespace SharedForConvertingDataTypes
{
    public static class ShippingRepository
    {
        public static List<Shipping> AllAsList => new List<Shipping>
        {
            new AirShipping("A001","John Doe",DateTime.Now),
            new GroundShipping("G001","Jane Smith",new DateTime(2023, 10, 1)),
            new OceanShipping("O001","Alice Johnson",new DateTime(2023, 10, 1)),
            new RailShipping("R001","Bob Brown",DateTime.Now.AddDays(-3))
        };
        public static ShippingList<Shipping> AllAsShippingList => new ShippingList<Shipping>
        {
            new AirShipping("A001","John Doe",DateTime.Now),
            new GroundShipping("G001","Jane Smith",DateTime.Now.AddDays(-1)),
            new OceanShipping("O001","Alice Johnson",DateTime.Now.AddDays(-2)),
            new RailShipping("R001","Bob Brown",DateTime.Now.AddDays(-3))
        };
    }
}

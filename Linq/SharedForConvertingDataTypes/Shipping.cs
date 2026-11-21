using System;
using System.Collections.Generic;
using System.Text;

namespace SharedForConvertingDataTypes
{
    public abstract class Shipping
    {
        public string UniqueId { get; set; }
        public string Sender { get; set; }
        public DateTime ShippingDate { get; set; }
        protected Shipping(string uniqueId,string sender,DateTime shippingDate)
        {
            this.UniqueId = uniqueId;
            this.Sender = sender;
            this.ShippingDate = shippingDate;
        }
        public abstract string Description { get; }
        public virtual void Start()
        {
            Console.WriteLine($"{UniqueId} {Description} {Sender} {ShippingDate.ToShortDateString()}");
        }

    }
    public class AirShipping : Shipping
    {
        public AirShipping(string uniqueId, string sender, DateTime shippingDate) : base(uniqueId, sender, shippingDate)
        {
        }
        public override string Description => "Air Shipping";
    }
    public class GroundShipping : Shipping
    {
        public GroundShipping(string uniqueId, string sender, DateTime shippingDate) : base(uniqueId, sender, shippingDate)
        {
        }
        public override string Description => "Ground Shipping";
    }
    public class OceanShipping : Shipping
    {
        public OceanShipping(string uniqueId, string sender, DateTime shippingDate) : base(uniqueId, sender, shippingDate)
        {
        }
        public override string Description => "Ocean Shipping";
    }
    public class RailShipping : Shipping
    {
        public RailShipping(string uniqueId, string sender, DateTime shippingDate) : base(uniqueId, sender, shippingDate)
        {
        }
        public override string Description => "Rail Shipping";
    }
}

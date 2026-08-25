using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    /*
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private const decimal CostPerKg = 3m;
        public decimal ExtraFee { get; private set; }

        public ExpressShipment(string trackingCode, string description, decimal weight,
                                decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            if (extraFee < 0)
                throw new ArgumentException("Extra fee cannot be negative.");
            ExtraFee = extraFee;
        }

        public override decimal EstimatedCost => DeliveryFee + Weight * CostPerKg + ExtraFee;

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus() => $"Shipment {TrackingCode} is Out for Delivery.";

        public decimal CalculateInsurance() => EstimatedCost * 0.08m;
    }
    */
}

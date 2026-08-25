using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    /*
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private const decimal CostPerKg = 5m;
        private const decimal CustomsFee = 100m;

        public InternationalShipment(string trackingCode, string description, decimal weight,
                                      decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination) { }

        public override decimal EstimatedCost => DeliveryFee + Weight * CostPerKg + CustomsFee;

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code        : {TrackingCode}");
            Console.WriteLine($"Destination Country  : {Destination.Country}");
            Console.WriteLine($"Estimated Cost       : {EstimatedCost} EGP");
        }

        public string GetTrackingStatus() => $"Shipment {TrackingCode} has been Delivered.";

        public decimal CalculateInsurance() => EstimatedCost * 0.12m;
    }
    */
}

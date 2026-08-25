using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{

    /*
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        private const decimal CostPerKg = 3m;

        public StandardShipment(string trackingCode, string description, decimal weight,
                                 decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination) { }

        public override decimal EstimatedCost => DeliveryFee + Weight * CostPerKg;

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus() => $"Shipment {TrackingCode} is Ready.";

        public decimal CalculateInsurance() => EstimatedCost * 0.05m;
    }
    */
}

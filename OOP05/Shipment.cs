using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    /*
    public abstract partial class Shipment
    {
        public string TrackingCode { get; private set; }
        public string Description { get; private set; }
        public decimal Weight { get; private set; }
        public decimal DeliveryFee { get; private set; }
        public DeliveryAddress Destination { get; private set; }

        public static int TotalShipmentsCreated;

        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        protected Shipment(string trackingCode, string description, decimal weight,
                            decimal deliveryFee, DeliveryAddress destination)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                throw new ArgumentException("Tracking code cannot be empty.");
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be empty.");
            if (weight <= 0)
                throw new ArgumentException("Weight must be greater than zero.");
            if (deliveryFee < 0)
                throw new ArgumentException("Delivery fee cannot be negative.");
            if (destination == null)
                throw new ArgumentNullException(nameof(destination));

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            TrackingStatus = "In Transit";

            TotalShipmentsCreated++;
            Console.WriteLine($"{GetType().Name.Replace("Shipment", "")} Shipment Created");
        }

        public abstract decimal EstimatedCost { get; }
        public abstract void PrintShipment();

        public Shipment CopyShipment()
        {
            return ShallowCopy();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();
            copy.Destination = new DeliveryAddress(Destination.Street, Destination.City, Destination.Country);
            return copy;
        }

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
    }
    */
    }
    

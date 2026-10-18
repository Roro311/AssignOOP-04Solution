using System;
using System.Collections.Generic;
using System.Text;

namespace AssignOOP_04
{

        public abstract class Shipment
        {
            private string trackingCode;
            private string description;
            private decimal weight;
            private decimal deliveryFee;

            public string TrackingCode
            {
                get { return trackingCode; }
            }

            public string Description
            {
                get { return description; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        description = value;
                }
            }

            public decimal Weight
            {
                get { return weight; }
                set
                {
                    if (value > 0)
                        weight = value;
                }
            }

            public decimal DeliveryFee
            {
                get { return deliveryFee; }
                private set
                {
                    if (value > 0)
                        deliveryFee = value;
                }
            }

            public DeliveryAddress Destination { get; set; }

            // Abstract property
            public abstract decimal EstimatedCost { get; }

            // Constructor with default values
            public Shipment(string trackingCode)
                : this(
                    trackingCode,
                    "Unknown",
                    1m,
                    50m,
                    new DeliveryAddress("Unknown", "Unknown", 0))
            {
            }

            // Main constructor
            public Shipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                DeliveryAddress destination)
            {
                this.trackingCode =
                    string.IsNullOrWhiteSpace(trackingCode)
                    ? "Unknown"
                    : trackingCode;

                this.description = "Unknown";
                this.weight = 1m;
                this.deliveryFee = 50m;

                Description = description;
                Weight = weight;
                DeliveryFee = deliveryFee;

                Destination = destination;
            }

            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                    DeliveryFee = newFee;
            }

            // UpdateWeight overload 1
            public void UpdateWeight(decimal newWeight)
            {
                if (newWeight > 0)
                    Weight = newWeight;
            }

            // UpdateWeight overload 2
            public void UpdateWeight(
                decimal newWeight,
                decimal packingWeight)
            {
                if (newWeight > 0 && packingWeight >= 0)
                {
                    Weight = newWeight + packingWeight;
                }
            }

            // Abstract method
            public abstract void PrintShipment();
        }
    }



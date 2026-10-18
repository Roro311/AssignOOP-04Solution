using System;
using System.Collections.Generic;
using System.Text;

namespace AssignOOP_04
{

        public class ExpressShipment : Shipment, ITrackable, IInsurable
        {
            private decimal extraFee;

            public decimal ExtraFee
            {
                get { return extraFee; }
                set
                {
                    if (value >= 0)
                        extraFee = value;
                }
            }

            public ExpressShipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                DeliveryAddress destination,
                decimal extraFee)
                : base(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    destination)
            {
                ExtraFee = extraFee;
            }

            public override decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + (Weight * 5m) + ExtraFee;
                }
            }

            public override void PrintShipment()
            {
                System.Console.WriteLine("Express Shipment");
                System.Console.WriteLine(
                    $"Tracking Code : {TrackingCode}");
                System.Console.WriteLine(
                    $"Description   : {Description}");
                System.Console.WriteLine(
                    $"Weight        : {Weight} KG");
                System.Console.WriteLine(
                    $"Delivery Fee  : {DeliveryFee} EGP");
                System.Console.WriteLine(
                    $"Extra Fee     : {ExtraFee} EGP");
                System.Console.WriteLine(
                    $"Destination   : {Destination.GetFullAddress()}");
                System.Console.WriteLine(
                    $"Estimated Cost: {EstimatedCost} EGP");
            }

            public string GetTrackingStatus()
            {
                return $"Shipment {TrackingCode} is Out for Delivery.";
            }

            public decimal CalculateInsurance()
            {
                return EstimatedCost * 0.08m;
            }
        }
    }

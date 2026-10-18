using System;
using System.Collections.Generic;
using System.Text;

namespace AssignOOP_04
{
        public class InternationalShipment : Shipment, ITrackable, IInsurable
        {
            private string destinationCountry;
            private decimal customsFee;

            public string DestinationCountry
            {
                get { return destinationCountry; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        destinationCountry = value;
                }
            }

            public decimal CustomsFee
            {
                get { return customsFee; }
                set
                {
                    if (value >= 0)
                        customsFee = value;
                }
            }

            public InternationalShipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                DeliveryAddress destination,
                string destinationCountry,
                decimal customsFee)
                : base(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    destination)
            {
                this.destinationCountry = "Unknown";
                this.customsFee = 0m;

                DestinationCountry = destinationCountry;
                CustomsFee = customsFee;
            }

            public override decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + (Weight * 5m) + CustomsFee;
                }
            }

            public override void PrintShipment()
            {
                System.Console.WriteLine("International Shipment");
                System.Console.WriteLine(
                    $"Tracking Code      : {TrackingCode}");
                System.Console.WriteLine(
                    $"Description        : {Description}");
                System.Console.WriteLine(
                    $"Weight             : {Weight} KG");
                System.Console.WriteLine(
                    $"Delivery Fee       : {DeliveryFee} EGP");
                System.Console.WriteLine(
                    $"Destination        : {Destination.GetFullAddress()}");
                System.Console.WriteLine(
                    $"Destination Country: {DestinationCountry}");
                System.Console.WriteLine(
                    $"Customs Fee        : {CustomsFee} EGP");
                System.Console.WriteLine(
                    $"Estimated Cost     : {EstimatedCost} EGP");
            }

            public string GetTrackingStatus()
            {
                return $"Shipment {TrackingCode} has been Delivered.";
            }

            public decimal CalculateInsurance()
            {
                return EstimatedCost * 0.12m;
            }

            public virtual void GenerateCustomsReport()
            {
                System.Console.WriteLine("Customs Report");
                System.Console.WriteLine(
                    $"Tracking Code: {TrackingCode}");
                System.Console.WriteLine(
                    $"Destination Country: {DestinationCountry}");
                System.Console.WriteLine(
                    $"Customs Fee: {CustomsFee} EGP");
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Text;

namespace AssignOOP_04
{
        public sealed class CompletedShipment : Shipment
        {
            public CompletedShipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                DeliveryAddress destination)
                : base(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    destination)
            {
            }

            public override decimal EstimatedCost
            {
                get { return DeliveryFee + (Weight * 5m); }
            }

            public override void PrintShipment()
            {
                System.Console.WriteLine("Completed Shipment");
                System.Console.WriteLine(
                    $"Tracking Code : {TrackingCode}");
                System.Console.WriteLine(
                    $"Description   : {Description}");
                System.Console.WriteLine(
                    $"Weight        : {Weight} KG");
                System.Console.WriteLine(
                    $"Delivery Fee  : {DeliveryFee} EGP");
                System.Console.WriteLine(
                    $"Estimated Cost: {EstimatedCost} EGP");
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Text;

namespace AssignOOP_04
{
        public class DeliveryCenter
        {
            private Shipment[] shipments = new Shipment[20];
            private int count = 0;

            public string CenterName { get; set; }

            public Driver AssignedDriver { get; set; }

            public DeliveryCenter(string centerName)
            {
                CenterName = centerName;
            }

            // Integer indexer
            public Shipment this[int index]
            {
                get
                {
                    if (index >= 0 && index < count)
                        return shipments[index];

                    return default(Shipment);
                }
                set
                {
                    if (index >= 0 && index < count)
                        shipments[index] = value;
                }
            }

            // String indexer: search by tracking code
            public Shipment this[string trackingCode]
            {
                get
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (shipments[i].TrackingCode == trackingCode)
                            return shipments[i];
                    }

                    return default(Shipment);
                }
            }

            public bool AddShipment(Shipment shipment)
            {
                if (shipment == null || count >= shipments.Length)
                    return false;

                shipments[count] = shipment;
                count++;

                return true;
            }

            public bool RemoveShipment(string trackingCode)
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        for (int j = i; j < count - 1; j++)
                        {
                            shipments[j] = shipments[j + 1];
                        }

                        shipments[count - 1] = null;
                        count--;

                        return true;
                    }
                }

                return false;
            }

            public void PrintAllShipments()
            {
                System.Console.WriteLine("==========================================");
                System.Console.WriteLine(CenterName);
                System.Console.WriteLine("==========================================");

                if (AssignedDriver != null)
                {
                    System.Console.WriteLine(
                        $"Driver : {AssignedDriver.DriverName}");
                }

                System.Console.WriteLine();

                for (int i = 0; i < count; i++)
                {
                    shipments[i].PrintShipment();
                    System.Console.WriteLine("------------------------------------------");
                }
            }

            // New method in Assignment 4
            public void PrintTrackingStatuses()
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i] is ITrackable trackable)
                    {
                        System.Console.WriteLine(
                            trackable.GetTrackingStatus());
                    }
                }
            }
        }
}

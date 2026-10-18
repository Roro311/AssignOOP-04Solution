using System;
using System.Collections.Generic;
using System.Text;

namespace AssignOOP_04
{

        public class DeliveryReport
        {
            public void PrintShipment(ITrackable shipment)
            {
                if (shipment != null)
                {
                    System.Console.WriteLine(
                        shipment.GetTrackingStatus());
                }
            }

            public void PrintInsurance(IInsurable shipment)
            {
                if (shipment != null)
                {
                    System.Console.WriteLine(
                        $"Insurance: {shipment.CalculateInsurance():F2} EGP");
                }
            }
        }
    }


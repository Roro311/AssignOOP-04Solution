using System;
using System.Collections.Generic;
using System.Text;

namespace AssignOOP_04
{

        public static class DeliveryHelper
        {
            public static void PrintShipmentDetails(Shipment shipment)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                }
            }
        }
    }


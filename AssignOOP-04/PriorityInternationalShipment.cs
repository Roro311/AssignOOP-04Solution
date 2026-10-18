

namespace AssignOOP_04
{

    public class PriorityInternationalShipment
: InternationalShipment
    {
        public PriorityInternationalShipment(
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
                destination,
                destinationCountry,
                customsFee)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            System.Console.WriteLine("Priority Customs Report");
            System.Console.WriteLine(
                $"Tracking Code: {TrackingCode}");
            System.Console.WriteLine(
                $"Destination Country: {DestinationCountry}");
            System.Console.WriteLine(
                $"Customs Fee: {CustomsFee} EGP");
        }
    }
}


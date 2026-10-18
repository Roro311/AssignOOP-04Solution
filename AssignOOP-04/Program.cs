namespace AssignOOP_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            //Q1 Abstraction
            //a)  What is Abstraction in Object - Oriented Programming?
            // answer: Abstraction is a fundamental concept in Object-Oriented Programming (OOP) that focuses on exposing only the essential features of an object while hiding the unnecessary details.
            // It allows developers to create simplified models of complex systems by defining abstract classes or interfaces that specify the behavior and properties that derived classes must implement.
            // This helps in managing complexity, improving code maintainability, and promoting code reusability.

            //b)  Why is abstraction considered one of the four pillars of OOP?
            // answer: Abstraction is considered one of the four pillars of OOP because it allows developers to create simplified models of complex systems by focusing on essential features and hiding unnecessary details.


            //Q2  Abstract Classes vs.Interfaces
            //a)  What is the difference between an Abstract Class and an Interface?
            // answer: An Abstract Class is a class that cannot be instantiated and may contain both abstract methods (without implementation) and concrete methods (with implementation).
            // It serves as a base class for other classes to inherit from, allowing for code reuse and providing a common interface for related classes.

            //b)  When would you choose an Interface instead of an Abstract Class?
            // answer: I would choose an Interface when you want to define a contract that multiple classes can implement, allowing for multiple inheritance of behavior.
            // An abstract class is more suitable when you want to provide a common base implementation for related classes.

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // answer: A class in C# can only inherit from one abstract class (single inheritance), but it can implement multiple interfaces (multiple inheritance of contract).

            #endregion

            #region Part 02 — Practical Questions

      
                // 1. Create delivery addresses
                DeliveryAddress address1 = new DeliveryAddress(
                    "Cairo", "Nasr Street", 10);

                DeliveryAddress address2 = new DeliveryAddress(
                    "Giza", "Pyramid Street", 20);

                DeliveryAddress address3 = new DeliveryAddress(
                    "Berlin", "Main Street", 30);

                // 2. Create a driver
                Driver driver = new Driver("Ahmed Mohamed");

                // 3. Create a delivery center
                DeliveryCenter center =
                    new DeliveryCenter("Delivery Center");

                center.AssignedDriver = driver;

                // 4. Create the three shipment types
                StandardShipment standard = new StandardShipment(
                    "SH001",
                    "Laptop",
                    3m,
                    80m,
                    address1);

                ExpressShipment express = new ExpressShipment(
                    "SH002",
                    "Mobile Phone",
                    2m,
                    60m,
                    address2,
                    30m);

                InternationalShipment international =
                    new InternationalShipment(
                        "SH003",
                        "Television",
                        8m,
                        120m,
                        address3,
                        "Germany",
                        100m);

                // 5. Add shipments to the center
                center.AddShipment(standard);
                center.AddShipment(express);
                center.AddShipment(international);

                // 6. Print all shipments
                center.PrintAllShipments();

                // 7. Use the old DeliveryHelper
                Console.WriteLine();
                Console.WriteLine("Printing Using DeliveryHelper...");
                Console.WriteLine();

                DeliveryHelper.PrintShipmentDetails(standard);
                Console.WriteLine();

                DeliveryHelper.PrintShipmentDetails(express);
                Console.WriteLine();

                DeliveryHelper.PrintShipmentDetails(international);

                // 8. Demonstrate UpdateWeight overloads
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Updating Weight...");
                Console.WriteLine();

                Console.WriteLine(
                    $"Original Weight : {standard.Weight} KG");

                standard.UpdateWeight(5m);

                Console.WriteLine(
                    $"Updated Weight : {standard.Weight} KG");

                standard.UpdateWeight(5m, 0.5m);

                Console.WriteLine(
                    $"Updated Weight After Packing : {standard.Weight} KG");

                // 9. Demonstrate Shipment[] polymorphism
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Printing Using Shipment[]...");
                Console.WriteLine();

                Shipment[] shipments =
                {
                standard,
                express,
                international
            };

                for (int i = 0; i < shipments.Length; i++)
                {
                    shipments[i].PrintShipment();
                    Console.WriteLine();
                }

                // 10. Demonstrate ITrackable
                Console.WriteLine("==========================================");
                Console.WriteLine("Tracking Statuses...");
                Console.WriteLine();

                center.PrintTrackingStatuses();

                // 11. Use DeliveryReport
                DeliveryReport report = new DeliveryReport();

                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Delivery Report...");
                Console.WriteLine();

                report.PrintShipment(standard);
                report.PrintShipment(express);
                report.PrintShipment(international);

                Console.WriteLine();
                Console.WriteLine("Insurance Costs...");
                report.PrintInsurance(standard);
                report.PrintInsurance(express);
                report.PrintInsurance(international);

                // 12. Demonstrate ITrackable polymorphism
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("ITrackable Polymorphism...");
                Console.WriteLine();

                ITrackable[] trackableShipments =
                {
                standard,
                express,
                international
            };

                for (int i = 0; i < trackableShipments.Length; i++)
                {
                    Console.WriteLine(
                        trackableShipments[i].GetTrackingStatus());
                }

                // 13. Demonstrate IInsurable polymorphism
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("IInsurable Polymorphism...");
                Console.WriteLine();

                IInsurable[] insurableShipments =
                {
                standard,
                express,
                international
            };

                for (int i = 0; i < insurableShipments.Length; i++)
                {
                    Console.WriteLine(
                        $"Insurance: {insurableShipments[i].CalculateInsurance():F2} EGP");
                }

                // 14. Demonstrate the string indexer
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Searching for SH002...");

                Shipment foundShipment = center["SH002"];

                if (foundShipment != null)
                    foundShipment.PrintShipment();
                else
                    Console.WriteLine("Shipment not found.");

                // 15. Demonstrate the integer indexer
                Console.WriteLine();
                Console.WriteLine("Shipment at index 0:");

                Shipment firstShipment = center[0];

                if (firstShipment != null)
                    Console.WriteLine(firstShipment.TrackingCode);

                // 16. Demonstrate customs report
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Customs Report...");
                international.GenerateCustomsReport();

                // 17. Demonstrate PriorityInternationalShipment
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Priority International Shipment...");

                PriorityInternationalShipment priority =
                    new PriorityInternationalShipment(
                        "SH004",
                        "Urgent Package",
                        4m,
                        100m,
                        address3,
                        "France",
                        40m);

                priority.PrintShipment();
                priority.GenerateCustomsReport();

                // 18. Demonstrate sealed CompletedShipment
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("Completed Shipment...");

                CompletedShipment completed =
                    new CompletedShipment(
                        "SH005",
                        "Documents",
                        1m,
                        50m,
                        address1);

                completed.PrintShipment();

                // 19. Demonstrate RemoveShipment
                Console.WriteLine();
                Console.WriteLine("==========================================");

                bool removed = center.RemoveShipment("SH002");

                Console.WriteLine(
                    removed
                    ? "SH002 removed successfully."
                    : "Shipment not found.");

                Console.WriteLine();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
            #endregion
    
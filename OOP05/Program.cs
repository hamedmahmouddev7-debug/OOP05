using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP05
{
    public class Program
    {
        public static void Main()
        {

            #region Question01
            // (A) When you assign one object variable to another, both variables refer to the same object in memory.

            // (B) No. Assigning one object variable to another does not create a new object. It only copies the reference to the existing object.

            // (C) Copying the reference: Both variables point to the same object. Changing the object through one variable affects the other.
            //     Copying the object: A new, separate object is created with the same data.Changing one object does not affect the other.
            #endregion

            #region Question02
            // (A) A Shallow Copy creates a new object, but it copies the values of the fields directly. For reference-type fields, it copies the reference, not the actual object.

            // (B) A Deep Copy creates a new object and also creates new copies of all referenced objects inside it. The original and copied objects are completely independent.

            /* (C) The reference is copied, so both the original and copied objects point to the same referenced object.
              Therefore, changing the referenced object through one copy will affect the other.
            */

            /* (D) The reference is copied, so both the original and copied objects point to the same referenced object.
             The referenced objects are also copied into new objects. Each object has its own independent reference.

             Therefore, changing a referenced object in one copy does not affect the other.
             */

            /* (E)
             * Deep Copy is safer when you need to modify a copied object without affecting the original.

            Example: If you copy a customer's profile and want to edit the copy before saving it, a Deep Copy prevents changes to the copied profile from modifying the original profile.
            */
            #endregion

            #region Question03
            /* (A) A static field belongs to the class itself, not to a specific object. There is only one shared copy of a static field.

               An instance field belongs to a specific object, so every object has its own copy.
            */
            /* (B) A static method belongs to the class rather than to an object.

                A static method cannot directly access instance members because instance members belong to a specific object.
            */
            /* (C) A static constructor is used to initialize static members of a class.

                  It:

                    Has the same name as the class.
                    Has no access modifier.
                    Has no parameters.
                    Is executed automatically once, before the class is first used.
            */
            /* (D) A static class is a class that can contain only static members. It cannot be instantiated.

                   So, No, you cannot create an object from a static class.
            */

            #endregion

            #region Question04
            // (A) An Extension Method is a method that allows you to add new functionality to an existing class or type without modifying its original source code.

            // (B) The this keyword must be used with the first parameter.

            // (C) An extension method must be declared inside a static class, and the method itself must also be static.

            // (D) No. An extension method cannot directly access the private members of the class it extends. It can only access members that are accessible to it, such as public members.

            #endregion

            #region Question05
            // (A)A Partial Class is a class that can be divided into multiple files. The compiler combines all parts into one class during compilation.

            /* (B) A developer may split a class into multiple files to:

                   Keep the code organized.
                   Make large classes easier to manage.
                   Allow multiple developers to work on different parts.
                   Separate generated code from manually written code.
            */

            // (C) A Partial Method is a method that is declared in one part of a partial class and can be implemented in another part of the same class.

            /* (D) Partial Class → one class split into multiple files.
                   Partial Method → method declaration and optional implementation can be in different parts.
                   No implementation → the method is removed by the compiler.
            */
            #endregion

            #region Part 02 — Practical
            /*
                        DeliveryUtilities.PrintSystemTitle();
                            Console.WriteLine();

                            int trigger = Shipment.GetTotalShipmentsCreated();
                            Console.WriteLine();

                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine("Creating Shipments...");
                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine();

                            var address1 = new DeliveryAddress("Tahrir St", "Cairo", "Egypt");
                            var address2 = new DeliveryAddress("Corniche Rd", "Cairo", "Egypt");
                            var address3 = new DeliveryAddress("Main St", "Cairo", "Egypt");

                            Shipment shipment1 = new StandardShipment("SH001", "Books", 3m, 20m, address1);
                            Shipment shipment2 = new ExpressShipment("SH002", "Electronics", 2m, 30m, address2, 15m);
                            Shipment shipment3 = new InternationalShipment("SH003", "Machinery", 8m, 50m, address3);
                            Console.WriteLine();

                            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
                            Console.WriteLine();

                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine("Object Copying");
                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine();

                            Shipment shipmentAssigned = shipment1;
                            Console.WriteLine($"Original Shipment  : {shipment1.TrackingCode}");
                            Console.WriteLine($"Assigned Shipment  : {shipmentAssigned.TrackingCode}");
                            Console.WriteLine();
                            Console.WriteLine($"Same Object : {ReferenceEquals(shipment1, shipmentAssigned)}");
                            Console.WriteLine();

                            DeliveryUtilities.PrintDashSeparator();
                            Console.WriteLine("Shallow Copy");
                            DeliveryUtilities.PrintDashSeparator();
                            Console.WriteLine();

                            Shipment shallowCopy = shipment1.ShallowCopy();
                            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
                            Console.WriteLine($"Copied Shipment Address   : {shallowCopy.Destination.City}");
                            Console.WriteLine();
                            Console.WriteLine("Changing copied shipment address...");
                            Console.WriteLine();
                            shallowCopy.Destination.City = "Giza";
                            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
                            Console.WriteLine($"Copied Shipment Address   : {shallowCopy.Destination.City}");
                            Console.WriteLine();
                            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(shipment1.Destination, shallowCopy.Destination)}");
                            Console.WriteLine();

                            shipment1.Destination.City = "Cairo";

                            DeliveryUtilities.PrintDashSeparator();
                            Console.WriteLine("Deep Copy");
                            DeliveryUtilities.PrintDashSeparator();
                            Console.WriteLine();

                            Shipment deepCopy = shipment1.DeepCopy();
                            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
                            Console.WriteLine($"Copied Shipment Address   : {deepCopy.Destination.City}");
                            Console.WriteLine();
                            Console.WriteLine("Changing copied shipment address...");
                            Console.WriteLine();
                            deepCopy.Destination.City = "Giza";
                            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
                            Console.WriteLine($"Copied Shipment Address   : {deepCopy.Destination.City}");
                            Console.WriteLine();
                            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(shipment1.Destination, deepCopy.Destination)}");
                            Console.WriteLine();

                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine("Extension Methods");
                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine();

                            Console.WriteLine(shipment1.GetSummary());
                            Console.WriteLine(shipment2.GetSummary());
                            Console.WriteLine(shipment3.GetSummary());
                            Console.WriteLine();

                            Console.WriteLine($"SH001 Is Delivered : {shipment1.IsDelivered()}");
                            Console.WriteLine($"SH003 Is Delivered : {shipment3.IsDelivered()}");
                            Console.WriteLine();

                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine("Tracking Status");
                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine();

                            shipment2.UpdateTrackingStatus("Out For Delivery");
                            Console.WriteLine();

                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine("Static Utilities");
                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine();

                            DeliveryUtilities.PrintDashSeparator();
                            Console.WriteLine("Delivery Center");
                            DeliveryUtilities.PrintDashSeparator();
                            Console.WriteLine();

                            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
                            Console.WriteLine();

                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine("Partial Method");
                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine();

                            shipment3.UpdateTrackingStatus("Delivered");
                            Console.WriteLine();

                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine("Assignment 04 Functionality Check");
                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine();

                            var center = new DeliveryCenter();
                            center.AddShipment(shipment1);
                            center.AddShipment(shipment2);
                            center.AddShipment(shipment3);

                            center.PrintAllShipments();
                            center.PrintTrackingStatuses();
                            Console.WriteLine();

                            DeliveryReport.PrintInsurance((IInsurable)shipment1);
                            DeliveryReport.PrintInsurance((IInsurable)shipment2);
                            DeliveryReport.PrintInsurance((IInsurable)shipment3);
                            Console.WriteLine();

                            DeliveryUtilities.PrintSeparator();
                            Console.WriteLine("Assignment Completed");
                            DeliveryUtilities.PrintSeparator();
                        }
            */
        }

        #endregion

    }
}
    
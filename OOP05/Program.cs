using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP05
{
    class Program
    {
        static void Main(string[] args)
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

        }
    }
}
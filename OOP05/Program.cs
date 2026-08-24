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
        }
    }
}
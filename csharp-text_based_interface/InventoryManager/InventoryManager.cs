using System;
using InventoryLibrary;

namespace InventoryManager
{
    public class InventoryManager
    {
        static void Main()
        {
            PrintCommands();
            Start();
        }

        private void PrintCommands()
        {
            Console.WriteLine("Inventory Manager\n" +
                            "-------------------------\n" +
                            "<ClassNames> show all ClassNames of objects\n" +
                            "<All> show all objects\n" +
                            "<All [ClassName]> show all objects of a ClassName\n" +
                            "<Create [ClassName]> a new object\n" +
                            "<Show [ClassName object_id]> an object\n" +
                            "<Update [ClassName object_id]> an object\n" +
                            "<Delete [ClassName object_id]> an object\n" +
                            "<Exit>");
        }

        private void Start()
        {
            while (true)
            {

            }
        }
    }
}

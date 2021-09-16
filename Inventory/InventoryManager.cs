using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    class InventoryManager
    {
        CalculateInventory calculateInventory = new CalculateInventory();
        List<InventoryDetails> list = new List<InventoryDetails>();
        public void CreateInventory()
        {
            list = calculateInventory.GetInventory();
            Console.WriteLine("----------------------------------");
            foreach (var i in this.list)
            {
                Console.WriteLine($"{i.name} : {i.price},");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Create Inventory");
            Console.WriteLine();
            Console.Write("What you want to Buy : ");
            String name = Console.ReadLine();
            Console.Write("In Kilogram(KG) : ");
            double kg = double.Parse(Console.ReadLine());
            calculateInventory.Calculate(this.list,name,kg);
            CreateInventory();
        }
    }
}

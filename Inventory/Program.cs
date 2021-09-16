using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Inventory
{

    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager inventoryManager = new InventoryManager();
            inventoryManager.CreateInventory();
        }
    }
}

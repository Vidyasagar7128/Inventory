using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Inventory
{
    class CalculateInventory
    {
        double price = 0;
        List<InventoryDetails> buyList = new List<InventoryDetails>();
        public void Calculate(List<InventoryDetails> list,String name,double weight)
        {
            Console.WriteLine($"Name : {name}, in KG : {weight}");
            foreach(var i in list)
            {
                if(i.name == name)
                {
                    this.price = i.price;
                }
            }
            Console.WriteLine("***********************************************");
            Console.WriteLine($"Calculation for : {name}, {weight}KG, Total : {this.price*weight}");
            Console.WriteLine("***********************************************");
            InventoryDetails inventoryDetails = new InventoryDetails()
            {
                name = name,
                weight = weight,
                price = this.price*weight
            };
            this.buyList.Add(inventoryDetails);
            String inventory = JsonConvert.SerializeObject(buyList);
            File.WriteAllText(@"buyerListJson.json", inventory);
        }
        public List<InventoryDetails> GetInventory()
        {
            List<InventoryDetails> employeeList = new List<InventoryDetails>();
            InventoryDetails inventoryDetails = new InventoryDetails()
            {
                name = "Rice",
                weight = 1,
                price = 100.0,
            };
            InventoryDetails inventoryDetails1 = new InventoryDetails()
            {
                name = "Wheats",
                weight = 1,
                price = 150.0,
            };
            InventoryDetails inventoryDetails2 = new InventoryDetails()
            {
                name = "Pulses",
                weight = 1,
                price = 200.0,
            };
            employeeList.Add(inventoryDetails);
            employeeList.Add(inventoryDetails1);
            employeeList.Add(inventoryDetails2);
            
            String inventory = JsonConvert.SerializeObject(employeeList);
            File.WriteAllText(@"inventoryJson.json", inventory);
            Console.WriteLine("Saved!");
            String file = File.ReadAllText(@"C:\Users\vidya\Desktop\DotNet\Inventory\Inventory\bin\Debug\netcoreapp3.1\inventoryJson.json");
            var data1 = JsonConvert.DeserializeObject<List<InventoryDetails>>(file);
            return data1;
        }
    }
}

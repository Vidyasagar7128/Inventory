using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    class InventoryDetails
    {
        public String name { get; set; }
        public double weight { get; set; }
        public double price { get; set; }

        public override string ToString()
        {
            return string.Format("Inventory Details : \n\t Name : {0} \n\t Weight : {1} \n\t Price : {2}");
        }
    }
}

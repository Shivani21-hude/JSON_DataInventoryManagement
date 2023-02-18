using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    public class DataManagement
    {
        public void DataInventory()
        {
            string filepath = "E:\\RFP 215\\InventoryDataManagement\\JSON_DataInventoryManagement\\InventoryDataManagement\\DataInventory.json";
            try
            {
                if (File.Exists(filepath))
                {
                    string record=File.ReadAllText(filepath);
                    Data data =JsonConvert.DeserializeObject<Data>(record);
                    List<Inventory> inventories = data.inventories;
                    foreach (Inventory items in inventories)
                    {
                        double value = items.Price * items.Weight;
                        Console.WriteLine("Name : " + items.Name + ",  Weight : " + items.Weight + ",  Price :  " + items.Price + ", Total Value :" + value);
                    }
                }
                else
                {
                    Console.WriteLine("File not found");
                    throw new Exception();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       
    }
}

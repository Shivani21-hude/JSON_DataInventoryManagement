using System;
namespace InventoryDataManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ******  Data Inventory Management  *******");
            DataManagement datamanagement=new DataManagement();
            datamanagement.DataInventory();
        }
    }
}
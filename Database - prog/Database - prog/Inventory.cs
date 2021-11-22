using System;
using System.Collections.Generic;
using System.Text;

namespace Database___prog
{
    public class Inventory
    {
        public Inventory()
        {

        }



        public void addToInventory(string item, int amount)
        {
            Console.WriteLine("Input the specified item.\n:");
            string inputItem = Console.ReadLine();
            int inputQuantity;
            Console.WriteLine("Input specified amount of said item.\n:");
            int.TryParse(Console.ReadLine(), out inputQuantity);
        }

        string[] items;
        int[] itemsQuantity;
    }
}

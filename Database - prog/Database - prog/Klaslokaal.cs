using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Database___prog
{
    public class Klaslokaal
    {
        private int counter;
        private bool read;
        public Klaslokaal()
        {

        }

        public void AddToClass()
        {
            Console.WriteLine("Person added:\n");
            string added = Console.ReadLine();
            Console.WriteLine("Added persons age:\n");
            string addedAge = Console.ReadLine();
            Console.WriteLine("Added persons role:\n");
            string addedRole = Console.ReadLine();
            Console.WriteLine("Save changes and exit?\nPlease make your choice by typing Yes or No (or x to discard all progress)\n:");
            read = true;
            while(read == true)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "yes")
                {
                    string[] input = { added, addedAge, addedRole };
                    
                }
                else if (userInput.ToLower() == "no")
                {
                    read = false;
                    continue;
                }
                else if (userInput.ToLower() == "x")
                {
                    break;                 
                }
                else
                {
                    Console.WriteLine("Input invalid, please try again.");
                    return;
                }
            }
        }
        public void ReadFromClass()
        {
            Console.WriteLine("Input ID to read from database:\n");
            string userInput = Console.ReadLine();
            
        }
    }
}

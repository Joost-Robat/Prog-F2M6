using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace Database___prog
{
    public class Klaslokaal
    {
        private int counter;
        private bool read;
        public string input;
        public List<Person> people;
        public Person person;

        public Klaslokaal()
        {
            people = new List<Person>();
        }

        public void AddToClass()
        {
            Console.Clear();
            person = new Person();
            Console.Write("\nInput name: ");
            input = Console.ReadLine();
            person.SetName(input);
            Console.Write("\nInput age: ");
            input = Console.ReadLine();
            person.SetAge(input);
            Console.Write("\nInput role: ");
            input = Console.ReadLine();
            person.SetRole(input);
            Console.WriteLine("Do you want to save " + person.GetName() + "? y/n");
            input = Console.ReadLine();
            if(input.ToLower() == "y")
            {
                people.Add(person);
            }
            else if(input.ToLower() == "n")
            {
                AddToClass();
            }
            else
            {
                Console.WriteLine("Inproper input, restarting...");
                Thread.Sleep(2000);
                AddToClass();
            }
            /*
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
                    input = { added, addedAge, addedRole };
                    
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
            }*/
        }
        public void ReadFromClass()
        {
            Console.WriteLine("Input ID to read from database:\n");
            string userInput = Console.ReadLine();
            
        }
        public Person[] GetAllPeople()
        {
            return people.ToArray();
        }
        public void ListAllPeople()
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(i + " " + GetAllPeople()[i].GetName());
            }
        }
        public void ListPeopleWithAge(string input)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if(GetAllPeople()[i].GetAge() == input)
                {
                    Console.WriteLine(i + " " + GetAllPeople()[i].GetName());
                    Console.WriteLine("Age: " + GetAllPeople()[i].GetAge());
                    Console.WriteLine("Role: " + GetAllPeople()[i].GetRole());
                }
            }
        }
        public void CheckForID(int input)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if(i == input)
                {
                    Console.WriteLine(i + " " + GetAllPeople()[i].GetName());
                    Console.WriteLine("Age: " + GetAllPeople()[i].GetAge());
                    Console.WriteLine("Role: " + GetAllPeople()[i].GetRole());
                }
            }
        }
    }
}

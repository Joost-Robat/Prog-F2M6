using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Database___prog
{
    class Program : Klaslokaal
    {
        public Person currentPerson;
        static void Main(string[] args)
        {
            Klaslokaal _class = new Klaslokaal();
            while (true)
            {
                Console.WriteLine("1 To add to class, 2 to read from class, 3 to filter with age from class\n");
                string userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    _class.AddToClass();
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("");
                    _class.GetAllPeople();
                    _class.ListAllPeople();
                }
                else if(userInput == "3")
                {
                    Console.Write("\nChoose age filter: ");
                    string input = Console.ReadLine();
                    _class.ListPeopleWithAge(input);
                }
            }
        }
    }
}

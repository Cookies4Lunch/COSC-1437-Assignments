using System;

namespace Project_3_ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring and assigning strings
            string firstname = "John";
            string lastname = "Doe";

            Console.WriteLine("Name: " + firstname + " " + lastname);

            Console.WriteLine("Please enter a new first name:");
            firstname = Console.ReadLine();

            Console.WriteLine("Please enter a new last name:");
            lastname = Console.ReadLine();

            Console.WriteLine("New name: " + firstname + " " + lastname);

            Console.Write("Press any key to continue");
            Console.ReadKey();

        }
    }
}

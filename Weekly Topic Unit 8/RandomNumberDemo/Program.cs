using System;
using System.Text.RegularExpressions;
using BinaryTreeImplementation;

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();

            var rand = new Random();

            Console.WriteLine("Spencer Johnson - Assignment 8\n");

            Console.WriteLine("As Loaded ...");

            for (int i = 0; i <= 9; i++)
            {
                var hold = rand.Next(101);
                Console.Write(hold + " ");

                tree.Add(hold);


                
            }

            Console.WriteLine();

            Console.WriteLine( "\n" + tree.Count + " words\n");

            Console.WriteLine("As retrieved ...");

            foreach (int actual in tree)
            {
                Console.Write(actual + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

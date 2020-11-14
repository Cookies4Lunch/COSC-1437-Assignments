using System;
using System.Text.RegularExpressions;
using BinaryTreeImplementation;

/*
 * ProfReynolds
 */

namespace WordSorterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<string>();

            var consoleInput = string.Empty;

            do 
            {
                // read the line from the user
                Console.Write("> ");
                consoleInput = Console.ReadLine();

                if (consoleInput.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }

                // split the line into words (on space)
                //var words = consoleInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // add each word to the tree
                //foreach (var word in words)
                //{
                //    tree.Add(word);
                //}

                string pattern = " ";
                string[] result = Regex.Split(consoleInput, pattern,
                                              RegexOptions.IgnoreCase);
                for (int i = 0; i < result.Length; i++)
                {
                    tree.Add(result[i]);
                }

                // print the number of words
                Console.WriteLine($"{tree.Count} words");

                // and print each word using the default (in-order) enumerator
                foreach (var word in tree)
                {
                    Console.Write($"{word} ");
                }

                Console.WriteLine();

                tree.Clear();

            } while (true);
        }
    }
}
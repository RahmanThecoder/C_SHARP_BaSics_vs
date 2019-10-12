using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            //List -01
            //var names = new List<string> { "<name>", "Ana", "Felipe" };
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");
            //}

            // list-02
            //var names= new List<string> { "me", "Myself", "who" };
            //Console.WriteLine();
            //names.Add("Maria");
            //names.Add("Bill");
            //names.Remove("Ana");
            //names.Remove("who");
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");
            //}

            //list-03
            //var names = new List<string> { "me", "Myself", "who", "bella","piku"};
            ////var names = new List<string> ["kas", "bas"];



            //Console.WriteLine($"My name is {names[0]}.");
            //Console.WriteLine($"I've added {names[2]} and {names[3]} " +
            //                  $"to the list.");

            //List-04

            //var names = new List<string> { "me", "myself", "you", "ha" };
            //Console.WriteLine($"The list has {names.Count} people in it");

            //list-05
            //var names = new List<string> { "Me", "FeLipe", "kaku", "bela","Felipe",
            //    "Not Found" };
            //var index = names.IndexOf("Felipe");
            //if (index != -1)
            //    Console.WriteLine($"The name {names[index]} is at index {index}");
            //    // the name felipe is at index 1 will return this

            //var notFound = names.IndexOf("Not Found");
            //Console.WriteLine($"When an item is not found, IndexOf returns " +
            //    $"{notFound}");
            //var found = names.IndexOf("Found_item");
            //Console.WriteLine($"Not found here {found} thats it");

            //list -06
            //names.Sort();
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");
            //}

            //List-07
            //var fibonacciNumbers = new List<int> { 1, 1,2,3,5,8,13 };

            //var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            //fibonacciNumbers.Add(previous + previous2);

            //foreach (var item in fibonacciNumbers)
            //    Console.WriteLine(item);

            //list-08
            var fibonacciNumbers2 = new List<int> { 1, 1 };

            while (fibonacciNumbers2.Count < 20)
            {
                var previous_1 = fibonacciNumbers2[fibonacciNumbers2.Count - 1];
                var previous2_1 = fibonacciNumbers2[fibonacciNumbers2.Count - 2];

                fibonacciNumbers2.Add(previous_1 + previous2_1);
            }
            foreach (var item in fibonacciNumbers2)
                Console.WriteLine(item);
        }
    }
}

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var aFriend = "Maira";
            // Console.WriteLine(aFriend);
            //Console.WriteLine("Hello " + aFriend);
            //Console.WriteLine($"Hello {aFriend}");

            //string firstFriend = "Maria";
            //string secondFriend = "Sage";
            //Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            //var m1 = "mustafiz";
            //var m2 = "sayhem";
            //Console.WriteLine($"My Friends are not real like {m1} and {m2}");

            //var firstFriend = " mustafizur";
            //var secondFriend = " mustafizur";
            //Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            //Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
            //Console.WriteLine($"The character lenght is counting using this {firstFriend} has {firstFriend.Length} letters really");
            //Console.WriteLine($"has lenght {firstFriend.Length}");


            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

        }
    }
}

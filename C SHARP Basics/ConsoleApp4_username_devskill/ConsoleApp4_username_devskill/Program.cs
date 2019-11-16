using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_username_devskill
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter The Username ");
            string a = Convert.ToString(Console.ReadLine());

            if (a.StartsWith("1") || (a.StartsWith("2") || (a.StartsWith("3") ||
               (a.StartsWith("4")) || (a.StartsWith("5")) || (a.StartsWith("6"))
               ||(a.StartsWith("7")) || (a.StartsWith("8")) || (a.StartsWith("9"))
               || (a.StartsWith("0"))|| (a.StartsWith("_") ||(a.StartsWith("__"))
               || (a.Length < 5)|| (a.Length > 20)))))
            
                ////Console.WriteLine("Invalid Username");
                //if (a.StartsWith("2"))

                //  //  Console.WriteLine("Invalid Username");
                //if (a.StartsWith("3"))

                //  //  Console.WriteLine("Invalid Username");
                //if (a.StartsWith("4"))

                //  //  Console.WriteLine("Invalid Username");
                //if (a.StartsWith("5"))

                //  //  Console.WriteLine("Invalid Username");
                //if (a.StartsWith("6"))

                //    Console.WriteLine("Invalid Username");
                //if (a.StartsWith("7"))

                //   // Console.WriteLine("Invalid Username");
                //if (a.StartsWith("8"))

                //    //Console.WriteLine("Invalid Username");
                //if (a.StartsWith("9"))

                //    //Console.WriteLine("Invalid Username");
                //if (a.StartsWith("0"))

                //  //  Console.WriteLine("Invalid Username");
                //if (a.StartsWith("_"))

                //   //Console.WriteLine("Invalid Username");
                //if (a.Contains("__"))

                //   // Console.WriteLine("Invalid Username");
                //if (a.Length < 5)

                //   // Console.WriteLine("Invalid Username");

                //if (a.Length > 20)

                    Console.WriteLine("Invalid Username");

            
            else
                Console.WriteLine("Valid Username");

            
        }
    }
}

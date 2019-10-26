using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace after_mid_xm
{
    

        // Base Class

        public class BClass

        {

            public virtual string Name { get; set; }

            public virtual void GetInfo()

            {

                Console.WriteLine("Learn C# Tutorial");

            }

        }

        // Derived Class

        public class DClass : BClass

        {

            private string name;

            public override string Name

            {

                get

                {

                    return name;

                }

                set

                {

                    if (!string.IsNullOrEmpty(value))

                    {

                        name = value;

                    }

                    else

                    {

                        name = "No Value";

                    }

                }

            }

            public  override void GetInfo()

            {

                Console.WriteLine("Welcome to Tutlane");

            }

        }

        class Program

        {

        //    static void Main(string[] args)

        //    {

        //    DClass d = new DClass();

        //    d.GetInfo();

        //    BClass b = new BClass();

        //    b.GetInfo();


        //    d.Name = string.Empty;

        //    Console.WriteLine(d.Name);

        //    //Console.WriteLine("\nPress Enter Key to Exit..");

        //    //Console.ReadLine();

        //}

    }

    }




    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
   // }


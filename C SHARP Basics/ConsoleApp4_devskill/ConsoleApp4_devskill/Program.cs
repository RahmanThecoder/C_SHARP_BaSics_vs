//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4_devskill
//{

//    class Person : IComparable
//    {
//        string vorname;
//        string nachname;
//        int age;

//        public Person(string vorname, string nachname, int age)
//        {
//            this.age = age;
//            this.nachname = nachname;
//            this.vorname = vorname;
//        }

//        public int CompareTo(object obj)
//        {
//            Person other = (Person)obj;
//            int a = this.age - other.age;

//            if (a != 0)
//            {
//                return -a;
//            }
//            else
//            {
//                return age.CompareTo(other.age);
//            }
//        }

//        public override string ToString()
//        {
//            return vorname + " " + nachname + "\t" + age;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person[] peeps = new Person[20];

//            try
//            {
//                StreamReader sr = new System.IO.StreamReader("inputNames.txt");

//                int count = 0;

//                while (!sr.EndOfStream)
//                {
//                    string data = sr.ReadLine();
//                    Console.WriteLine();
//                    string[] info = data.Split(',');
//                    peeps[count] = new Person(info[0], info[1], int.Parse(info[2]));

//                    count++;
//                }
//                Array.Sort(peeps);
//                sr.Close();
//            }
//            catch (FileNotFoundException e)
//            {
//                Console.WriteLine(e.Message);
//            }

//            StreamWriter sw = new StreamWriter("outputNames.txt");

//            Console.WriteLine();
//            foreach (Person p in peeps)
//            {
//                Console.WriteLine(p);
//                sw.WriteLine(p);
//            }
//            sw.Close();
//        }
//    }



//    //class Program
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //    }
//    //}
//}

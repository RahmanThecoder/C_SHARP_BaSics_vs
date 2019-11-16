//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp4_devskill
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text.RegularExpressions;

//    namespace Rextester
//    {
//        public class Program
//        {
//            public class Student
//            {
//                public string Name { get; set; }
//                public int Age { get; set; }

//            }



//            public static void Main(string[] args)
//            {
//                //Your code goes here
//                //Console.WriteLine("Hello, world!");

//                Student s = new Student() { Name = "Ivy", Age = 33 };
//                Student s1 = new Student() { Name = "Ryan", Age = 34 };
//                Student s2 = new Student() { Name = "Ron", Age = 23 };
//                Student s3 = new Student() { Name = "Melvin", Age = 2 };
//                Student s4 = new Student() { Name = "Sara", Age = 33 };
//                Student s5 = new Student() { Name = "Mars", Age = 43 };
//                Student s6 = new Student() { Name = "Pluto", Age = 50 };
//                Student s7 = new Student() { Name = "Neptune", Age = 6 };
//                Student s8 = new Student() { Name = "Nero", Age = 5 };
//                Student s9 = new Student() { Name = "Augustus", Age = 34 };

//                List<Student> list = new List<Student>();
//                list.Add(s);
//                list.Add(s1);
//                list.Add(s2);
//                list.Add(s3);
//                list.Add(s4);
//                list.Add(s5);
//                list.Add(s6);
//                list.Add(s7);
//                list.Add(s8);
//                list.Add(s9);



//                int[] studentCount = new int[100];

//                foreach (Student l in list)
//                {

//                    int index = l.Age - 1;
//                    studentCount[index] = studentCount[index] + 1;

//                }

//                int[] sortedAgeList = new int[list.Count()];

//                int currentAge = 0;
//                foreach (int i in studentCount)
//                {
//                    currentAge++;

//                    if (i != 0)
//                        for (int r = 0; r < i; r++)
//                            Console.WriteLine(currentAge);
//                }




//            }


//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_devskill
{
   
        class Program
        {
        static void Main(string[] args)
        {
            //        List<User> listOfUsers = new List<User>()
            //{
            //new User() { Name = "John Doe", Mail = "john@doe.com", Age = 42 },
            //new User() { Name = "Jane Doe", Mail = "jane@doe.com", Age = 34 },
            //new User() { Name = "Joe Doe", Mail = "joe@doe.com", Age = 8 },
            //new User() { Name = "Another Doe", Mail = "another@doe.com", Age = 15 },
            //};

            //        List<User> usersByAge = listOfUsers.OrderBy(user => user.Age).ToList();
            //        foreach (User user in usersByAge)
            //            Console.WriteLine(user.Name + ": " + user.Age + " years");
            //    }


            //approch 2


            List<User> listOfUsers = new List<User>()
{
    new User() { Name = "John Doe", Mail = "john@doe.com", Age = 42 },
    new User() { Name = "Jane Doe", Mail = "jane@doe.com", Age = 42 },
    new User() { Name = "Joe Doe", Mail = "joe@doe.com", Age = 8 },
    new User() { Name = "Jenna Doe", Mail = "another@doe.com", Age = 8 },
};

            List<User> sortedUsers = listOfUsers.OrderBy(user => user.Age).ThenBy(user => user.Name).ToList();
            foreach (User user in sortedUsers)
                Console.WriteLine(user.Name + ": " + user.Age + " years");
        }
            class User
            {
                public string Name { get; set; }
                public string Mail { get; set; }
                public int Age { get; set; }
            }
        }


  

 }


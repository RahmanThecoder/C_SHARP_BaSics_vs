using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Console;

namespace Microsoft_docs
{
    public class Person
    {
        // 01
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }


        // another approach 
        public override string ToString() => $"{FirstName} {LastName}";
        public string AllCaps() => ToString().ToUpper();

    }




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQ_practices
{

    class baseclass
    {
        protected int a = 20;
    }
    class derived : baseclass
    {
        int a = 10;
        public void math()
        {
            /* add code here */
            Console.WriteLine(a + " " +base.a);
        }
    }

    class here
    {
        //static void Main()
        //{
        //    derived aa = new derived();
        //    aa.math();
        //}
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace after_mid_xm
{
    class Midterm_Code
    {
        public class Shape
        {
            public double dimention1;
            public double dimention2;

            public Shape()
            {
            }

            public Shape(double dimention1, double dimention2)
            {
                this.dimention1 = dimention1;
                this.dimention2 = dimention2;

            }
            public virtual double GetArea()
            {
                return dimention1 * dimention2;
            }
        }

        public class Rectangle : Shape
        {
            //public double dimention2;
            public Rectangle(double dimention1, double dimention2) : 
                base(dimention1,
                dimention2)
            {
            }

            public override double GetArea()
            {
                return dimention1 * dimention2;
            }
        }

        class Triangle : Shape
        {
            //  public double y;
            public Triangle(double dimention1, double 
                dimention2) : base(dimention1, dimention2)
            {
            }

            public override double GetArea()
            {
                return 0.5 * dimention1 * dimention2;
            }
        }



        //static void Main()
        //{
            
        //    Shape r1 = new Rectangle(10,20);
        //    Shape t1 = new Triangle(10,20);
           
        //    // Display results.
        //    Console.WriteLine("Area of Rectangle  = {0}", r1.GetArea());
        //    Console.WriteLine("Area of Triangle   = {0}", t1.GetArea());
            
        //}
    }
    /*
    Output:
    Area of Rectangle   = 200
    Area of Triangle   = 100
    
    */
}

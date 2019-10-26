using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_xm_csharp_mustafiz
{


        public class Shape
        {
            public double dimention1;
            // public double dimention2;
            public Shape() { }
        public Shape(double dimention1)
        {
            this.dimention1 = dimention1;
        }
            public virtual double GetArea()
            {
            //Rectangle(double dimention1, double dimention2);
            //Triangle(double dimention1, double dimention2);
            return dimention1;
            }
        }


        public class Rectangle :  Shape
        {
            //public double dimention1;
            public double dimention2;
            public Rectangle() { }
            public Rectangle(double dimention1, double dimention2)
            {

            this.dimention1 = dimention1;
            this.dimention2 = dimention2;
           // return dimention1 * dimention2;
        }


            public override double GetArea()
            {
            // Rectangle(double dimention1, double dimention2);
            //Console.WriteLine(Convert.ToDouble(Rectangle(double dimention1,
            //    double dimention2)));
            return dimention1 * dimention2;
        }

        }

        public class Triangle : Shape
        {
            public double y;
            public Triangle() { }
            public Triangle(double dimention1, double dimention2)
            {
            this.dimention1 = dimention1;
             y = dimention2;
           // return 0.5 *dimention1 * dimention2;
        }

            public override double   GetArea()
            {

            //Triangle(double dimention1, double dimention2);

            //        Console.WriteLine(Convert.ToDouble(Triangle(double dimention1,
            //double dimention2)));


             return 0.5 * dimention1 * y;
            }
        }




        class Program
        {
            static void Main(string[] args)
            {

                Rectangle r1 = new Rectangle(10.0,20.0);
                Triangle t1 = new Triangle(10.0,20.0);
              //  r1.Rectangle(10.0, 20.0);
               // t1.Triangle(10.0, 20.0);
                Console.WriteLine("Rectangle Area:{0}",r1.GetArea());
               Console.WriteLine("Triangle Area:{0}", t1.GetArea());

            }
        }
    }





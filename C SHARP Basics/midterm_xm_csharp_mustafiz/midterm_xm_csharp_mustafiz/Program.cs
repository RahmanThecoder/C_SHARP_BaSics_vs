//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace midterm_xm_csharp_mustafiz
//{
//   public  class Shape
//    {
//        public double dimention1;
//       // public double dimention2;
//        public Shape() { }
//        public virtual void GetArea() {
//            //Rectangle(double dimention1, double dimention2);
//            //Triangle(double dimention1, double dimention2);
//        }
//    }


//    public class Rectangle : Shape
//    {
//        public double dimention1;
//        public double dimention2;
//        public Rectangle() { }
//         public  double Rectangle(double dimention1, double dimention2)
//        {
//            double b, Area;
//            b = dimention1;
//            this.dimention2 = dimention2;
//            Area = b * dimention2;
//            return Area;

//        }


//        public override void GetArea()
//        {
//            // Rectangle(double dimention1, double dimention2);
//            Console.WriteLine(Convert.ToDouble(Rectangle(double dimention1,
//                double dimention2)));
//        }

//    }

//    public class Triangle : Shape
//    {
//        public double y;
//        public Triangle() { }
//        public double Triangle(double dimention1, double dimention2)
//        {
//            double c, Area;
//            c = dimention1;
//            y = dimention2;
//            Area = c* y;
//            return Area;

//        }

//        public override void GetArea()
//        {

//            //Triangle(double dimention1, double dimention2);

//            Console.WriteLine(Convert.ToDouble(Triangle(double dimention1,
//    double dimention2)));
//        }
//    }




//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Rectangle r1 = new Rectangle();
//            Triangle t1 = new Triangle();
//            r1.Rectangle(10.0, 20.0);
//            t1.Triangle(10.0, 20.0);
//            Console.WriteLine("Rectangle Area:{0}",GetArea());
//            Console.WriteLine("Triangle Area:{0}", GetArea());

//        }
//    }
//}

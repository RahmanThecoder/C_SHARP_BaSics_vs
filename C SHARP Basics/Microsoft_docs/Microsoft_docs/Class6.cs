using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_docs
{
    class Class6
    {
        static void Main()
        {
            var messages = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };

            Console.WriteLine(messages[302]);
        }
    }

     /// <summary>
     ///  this code can't be run for environment issues
     /// </summary>
    //public class Path : IEnumerable<Pointer>
    //{
    //    private List<Pointer> points = new List<Point3D>();
    //    public IEnumerator<Point3D> GetEnumerator()
    //    {
    //        return points.GetEnumerator();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator() => points.GetEnumerator();

    //    public void Add(Point3D pt)
    //    {
    //        points.Add(pt);
    //    }

    //    IEnumerator<Pointer> IEnumerable<Pointer>.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    private class Point3D
    //    {
    //    }

    //    internal void Add(Microsoft_docs.Point3D point3D)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public static class Extensions
    //{
    //    public static void Add(this Path path, double x, double y, double z)
    //    {
    //        path.Add(new Point3D(x, y, z));
    //    }
    //}



}

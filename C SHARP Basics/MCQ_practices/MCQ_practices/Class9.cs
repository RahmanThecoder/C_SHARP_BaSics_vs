using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQ_practices
{
    class Class9
    {
        // arthimatic operator 
        //01
        //static void Main(string[] args)
        //{
        //    float a = 16.4f;
        //    int b = 12;
        //    float c;
        //    c = a * (b + a) / (a - b);
        //    Console.WriteLine("result is :" + c);
        //    Console.ReadLine();
        //}

        // 02
        //static void Main(string[] args)
        //{
        //    int a, b, c, x;
        //    a = 90;
        //    b = 15;
        //    c = 3;
        //    x = a - b / 3 + c * 2 - 1;
        //    Console.WriteLine(x);
        //    Console.ReadLine();
        //}

        //03
        //static void Main(string[] args)
        //{
        //    int a, b, c, x;
        //    a = 80;
        //    b = 15;
        //    c = 2;
        //    x = a - b / (3 * c) * (a + c);
        //    Console.WriteLine(x);
        //    Console.ReadLine();
        //}

        //04
        //static void Main(string[] args)
        //{
        //    int i, j = 1, k;
        //    for (i = 0; i < 3; i++)
        //    {
        //        k = j++ - ++j; // j=1 then increment by 1 j++ becomes j=2 , next 
        //        //before incrementation happend so ++j is j=3 now
        //        // so j++ is actually 1 but after incrementation is not applicable
        //        // (1-3=-2) three times loops executing
        //        Console.Write(k + " ");
        //    }
        // }

        //05

        //static void Main(string[] args)
        //{
        //    int b = 11;
        //    int c = 7;
        //    int r = 5;
        //    int e = 2;
        //    int l;
        //    int v = 109;
        //    int k;
        //    int z, t, p;
        //    z = b * c;
        //    t = b * b;
        //    p = b * r * 2;
        //    l = (b * c) + (r * e) + 10;
        //    k = v - 8;
        //    Console.WriteLine(Convert.ToString(Convert.ToChar(z)) + 
        //        ""  + Convert.ToString(Convert.ToChar(t)) 
        //        + Convert.ToString(Convert.ToChar(p)) 
        //        + Convert.ToString(Convert.ToChar(l)) 
        //        + Convert.ToString(Convert.ToChar(v))
        //        + Convert.ToString(Convert.ToChar(k)));
        //    Console.ReadLine();
        //}

        //06

        //static void Main(string[] args)
        //{
        //    int n = 5;
        //    int x = 4;
        //    int z, c, k;
        //    for (c = 1; c <= n; c++)
        //    {
        //        for (k = 1; k <= c; k++)
        //        {
        //            z = 3 * x * x + 2 * x + 4 / x + 8;
        //            Console.Write(Convert.ToString(Convert.ToChar(z)));
        //        }
        //        Console.WriteLine("\n");
        //    }
        //    Console.ReadLine();
        //}

        //07

        //static void Main(string[] args)
        //{
        //    int n = 5;
        //    int x = 4;
        //    int z, c, k;
        //    z = 3 * x * x + 2 * x + 4 / x + 8;
        //    for (c = 1; c <= n; c++)
        //    {
        //        for (k = 1; k <= c; k++)
        //        {
        //            Console.Write(Convert.ToString(Convert.ToChar(z)));
        //            z++;
        //        }
        //        Console.WriteLine("\n");
        //    }
        //    Console.ReadLine();
        //}

        //08
        //static void Main(string[] args)
        //{
        //    int a, b;
        //    int c = 10;
        //    int d = 12;
        //    int e = 5;
        //    int f = 6;
        //    a = c * (d + e) / f + d;
        //    Console.WriteLine(a);
        //    b = c * (d + e / f + d);
        //    Console.WriteLine(b);
        //    if (a < b)
        //    {
        //        Console.WriteLine(" parentheses changes values");
        //    }
        //    else if (a > b)
        //    {
        //        Console.WriteLine("they have same value");
        //    }
        //    Console.ReadLine();
        //}

        // Logical Operators
        // 09
        //static void Main(string[] args)
        //{
        //    int a = 4;
        //    int b = 5;
        //    int c = 6;
        //    int d = 8;
        //    if (((a * b / c) + d) >= ((b * c + d) / a))
        //    {
        //        Console.WriteLine("Line 1 - a is greater to b");
        //        Console.WriteLine((a * b / c) + d);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Line 1 - a is not greater to b");
        //        Console.WriteLine((b * c + d) / a);
        //    }
        //}

        //10
        //static void Main(string[] args)
        //{
        //    int a = 10;
        //    int b = 5;
        //    int c = 12;
        //    int e = 8;
        //    int d;
        //    d = Convert.ToInt32((a * (c - b) / e + (b + c)) <= (e * (c + a) / (b + c) + a));
        //    Console.WriteLine(d);
        //    if (d == 1)
        //    {
        //        Console.WriteLine("C# is great language!");
        //        Console.WriteLine((a * (c - b) / e + (b + c)));
        //    }
        //    else
        //    {
        //        Console.WriteLine("harsh is not great language!");
        //        Console.WriteLine((e * (c + a) / (b + c) + a));
        //    }
        //}

        //11
        //static void Main()
        //{
        //    int n = 2;
        //    int p = 4;
        //    int q = 5;
        //    int w = 3;
        //    if (!((p * q) / n <= (q * w) + n / p))
        //    {
        //        Console.WriteLine(++p + w++ + " " + ++n);
        //        Console.WriteLine("b");
        //    }
        //    else
        //    {
        //        Console.WriteLine(--p + q-- + " " + --n);
        //        Console.WriteLine("a");
        //    }

        //}

        //12

        //static void Main(string[] args)
        //{
        //    int a = 3, b = 5, c = 1;
        //    int z = ++b;
        //    int y = ++c;
        //    b = Convert.ToInt32((Convert.ToBoolean(z)) && (Convert.ToBoolean(y))
        //     || Convert.ToBoolean(Convert.ToInt32(!(++a == b))));
        //    a = Convert.ToInt32(Convert.ToBoolean(c) || Convert.ToBoolean(a--));
        //    Console.WriteLine(++a);
        //    Console.WriteLine(++b);
        //    Console.WriteLine(c);
        //}

        //13
        //static void Main(string[] args)
        //{
        //    int a = 4, b = 5, c = 7, u = 9;
        //    int h;
        //    h = (Convert.ToInt32(u < b)) + (a + b--) + 2;
        //    Console.WriteLine(h);
        //    Console.WriteLine(b);
        //    Console.WriteLine(u < b);
        //}

        //14
        //static void Main(string[] args)
        //{
        //    int m = 10, n = 5, p = 20;
        //    bool b1 = m * p / n <= p * n / m;
        //    int l = p - 2 * m;
        //    bool b2 = l == 0;
        //    int z = Convert.ToInt32(b2);
        //    int k = Convert.ToInt32(b1);
        //    Console.WriteLine(k);
        //    Console.WriteLine(z);
        //}

        //15

        //class method1
        //{
        //    public int fun(int m)
        //    {
        //        return (m++ % 10);
        //    }
        //}

        //static void Main(string[] args)
        //    {
        //        int a = 23, b = 0, c;
        //        method1 z = new method1();
        //        c = z.fun(++b * --a % 2);
        //        int d = (z.fun(c-- + --a));
        //        Console.WriteLine(c);
        //        Console.WriteLine(a++);
        //        Console.WriteLine(d);
        //        Console.ReadLine();
        //    }

        //16

        static void Main(string[] args)
        {
            int a = 8, b = 6, c = 10;
            int d = a * c * 2 / Convert.ToInt32(Math.Pow((c - b), 2));
            if (d == (c = Convert.ToInt32(Math.Sqrt(a * a + b * b))) && c == 10)
            {
                Console.WriteLine("figure is hypotenuse");
            }
            else
            {
                Console.WriteLine("figure is square");
            }
        }

    }
    }


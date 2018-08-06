using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes s1 = new Shapes();
            Console.WriteLine("enter the radius");
            double r = double.Parse(Console.ReadLine());
            double a4=s1.Area(r);
            Console.WriteLine("area of circle is=" + a4);
            Console.WriteLine("enter the length and breadth");
            int l = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int a2=s1.Area(l,b);
            Console.WriteLine("area of rectangle is=" + a2);
           Console.WriteLine("enter the side");
            int s = int.Parse(Console.ReadLine());
             int a1=s1.Area(s);
            Console.WriteLine("area of square is=" + a1);
           Console.WriteLine("enter the base and height");
            double ba = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
             double a3=s1.Area(b,h);
            Console.WriteLine("area of triangle is=" + a3);
        }
    }
}

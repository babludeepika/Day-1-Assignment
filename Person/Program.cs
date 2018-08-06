using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter date of birth");
            DateTime d = DateTime.Parse(Console.ReadLine());
            person p1 = new person("bablu", "Deepika", "abc@xyz.com", d);
            p1.Birthday();
            p1.Adult();
            p1.SunSign();

            Console.WriteLine("enter date of birth");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            person p2 = new person("bablu", "Deep", d1);
            p2.Birthday();
            p2.Adult();
            p2.SunSign();


            person p3 = new person("bablu", "Deepika", "abc@xyz.com");
            p3.Birthday();
            p3.Adult();
            p3.SunSign();



        }
    }
}

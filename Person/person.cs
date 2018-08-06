using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class person
    {
        string fname;
        string lname;
        string email;
        DateTime dob;

        public person(string fname,string lname,string email,DateTime dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.dob = dob;
        }

        public person(string fname, string lname, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
        }

        public person(string fname, string lname, DateTime dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.dob = dob;
        }

        public void SunSign()
        {

            if(dob.Month==1)
            {
                Console.WriteLine("your sign is aries");
            }
            else if (dob.Month == 2)
            {
                Console.WriteLine("your sign is tarus");
            }
            else if (dob.Month == 3)
            {
                Console.WriteLine("your sign is gemini ");
            }
            else if (dob.Month == 4)
            {
                Console.WriteLine("your sign is leo");
            }
            else if (dob.Month == 5)
            {
                Console.WriteLine("your sign is cancer");
            }
           else if (dob.Month == 6)
            {
                Console.WriteLine("your sign is vigro");
            }
            else if (dob.Month == 7)
            {
                Console.WriteLine("your sign is libra");
            }
            else if (dob.Month == 8)
            {
                Console.WriteLine("your sign is scorpio");
            }
            else if (dob.Month == 9)
            {
                Console.WriteLine("your sign is sagittaris");
            }
            else if (this.dob.Month == 10)
            {
                Console.WriteLine("your sign is capricon");
            }
            else if (dob.Month == 11)
            {
                Console.WriteLine("your sign is aquaris");
            }
           else
            {
                Console.WriteLine("your sign is piesces");
            }

        }

        public void Adult()
        {
            int d = DateTime.Now.Year - this.dob.Year;
            if(d>18)
            {
                Console.WriteLine("the person is adult");
            }
            else
            {
                Console.WriteLine("the person is child");
            }
        }

        public void Birthday()
        {
            if(DateTime.Now.Month==this.dob.Month)
            {
                if (DateTime.Now.Day == this.dob.Day)
                {
                    Console.WriteLine("Happy birthday to you");
                }
            }
            else
            {
                Console.WriteLine("have a nice day");
            }
        }
    }
}

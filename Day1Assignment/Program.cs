using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {

            char trans_type;
            double amount;
            double balance;
            accounts t1 = new accounts(123, "bablu", "Savings");
            Console.WriteLine("enter the type of transaction(c/d)");
            trans_type =char.Parse(Console.ReadLine());
            Console.WriteLine("enter the balance ");
            balance = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the amount ");
            amount = double.Parse(Console.ReadLine());

            char t =trans_type;
            if (t=='d')
            {
                t1.debit(amount);
            }
            else
            {
                t1.credit(amount);
            }
            t1.ShowData();
            Console.WriteLine(" transaction type=" + trans_type);
            Console.WriteLine("transaction amount= " + amount);
            Console.WriteLine(" current balance=" + balance);

        }
    }
}

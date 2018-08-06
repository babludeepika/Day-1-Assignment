using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    class accounts
    {
        int acc_no;
        string name;
        string acc_type;
        char trans_type;
        double amount;
        double balance;
 
        public void ShowData()
        {
            Console.WriteLine("account number=" +  acc_no );
            Console.WriteLine(" customer name ="+name);
            Console.WriteLine(" account type="+acc_type);
           
        }

        public accounts( int acc_no,string name,string acc_type)
        {
            this.acc_no = acc_no;
            this.name = name;
            this.acc_type = acc_type;
            //this.balance = balance;
        }


        public double credit(double amt)
        {
            balance = balance + amt;
            return balance;
        }

        public double debit(double amt)
        {
            balance = balance - amt;
           return balance;
        }
    }
}

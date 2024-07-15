using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace assaignment4
{
    class Bank
    {
        int acno;
        String cname;
        static String atype = "savings";
        string ttype;
        int amount;
        int bal=2000;
        public void cdetails(int acno, String cname,string ttype,int amount)
        {
            this.amount = amount;
            Console.WriteLine("customer account type is " + atype + " account no is " + acno + " customer account name is " + cname);
            if (ttype == "w")
            {
                withdraw();
            }
            else deposit();
        }
        public void deposit()
        {
            bal = bal + amount;
            Console.WriteLine("total balance is :" + bal);
        }
        public void withdraw()
        {
            if (amount < bal)
            {
                Console.WriteLine("enter valid amount");
            }
            else
            {
                bal = bal - amount;
            }
            Console.WriteLine("total balance is :" + bal);
        }

    }
    internal class A2
    {
        static void Main()
        {
            Console.WriteLine("enter account holder name");
            string cname=Console.ReadLine();
            Console.WriteLine("enter account no");
            int acno  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Transaction type");
            String ttype= Console.ReadLine();
            Console.WriteLine("enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());


            Bank b=new Bank();
            b.cdetails(acno, cname, ttype, amount); 
           

        }
    }
}

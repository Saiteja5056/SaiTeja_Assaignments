namespace D12A
{
    interface Igov
    {
        double pf();
        string leavedetails();
        double gratuity(float scompleted, double basicsalary);
    }
    class Tcs : Igov
    {
        int empid;string name, dept, desg; double basicsalary;
        double gratuityamount;
        
        
        public Tcs(int empid, string name, string dept,string desg, double basicsalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicsalary = basicsalary;
        }
        
        public void Employeedetails()
        {
            Console.WriteLine("Employee name is " + name);
            Console.WriteLine(" Employee id is " + empid);
            Console.WriteLine(" Employee department  is " + dept);
            Console.WriteLine(" employee designition is " + desg);
            Console.WriteLine(" Employee basi salary is " + basicsalary);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
        }

        public double pf() 
        {
            double pf = basicsalary * 0.12;
            return pf;
        }
        public string leavedetails()
        {
            Console.WriteLine("leaves for company");
            Console.WriteLine("1 day of Casual Leave per month");
            Console.WriteLine("12 days of Sick Leave per year");
            Console.WriteLine("10 days of Previlage Leave per year");
            Console.WriteLine("-----------------------------------------------------------------------------");
            return "";
        }
       public double gratuity(float scompleted, double basicsalary)
        {
            if(scompleted>10)
            {
                gratuityamount = 2 * basicsalary;
            }
            else if(scompleted>20)
            {
                gratuityamount = 3 * basicsalary;
            }
            else if (scompleted < 5) { }
            Console.WriteLine("---------------------------------------------------------------------------");
            return 0.0;

        }


    }
    class Accenture : Igov 
    {
        int empid; string name, dept, desg; double basicsalary;
        double gratuityamount;


        public Accenture(int empid, string name, string dept, string desg, double basicsalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicsalary = basicsalary;
        }
        public void Employeedetails()
        {
            Console.WriteLine("Employee name is " + name);
            Console.WriteLine(" Employee id is " + empid);
            Console.WriteLine(" Employee department  is " + dept);
            Console.WriteLine(" employee designition is " + desg);
            Console.WriteLine(" Employee basi salary is " + basicsalary);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
        public double pf()
        {
            double pf = basicsalary * 0.12;
            return pf;
        }
        public string leavedetails()
        {
            Console.WriteLine("leaves for company");
            Console.WriteLine("2 days of Casual Leave per month");
            Console.WriteLine("5 days of Sick Leave per year");
            Console.WriteLine("5 days of Previlage Leave per year");
            return "";
        }
        public double gratuity(float scompleted, double basicsalary)
        {
            Console.WriteLine(" no gratuity applicable ");
                return 0.0;
        }
    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            int empid; string name, dept, desg; double basicsalary;
            double gratuityamount;
            string company;
            Console.WriteLine("enter company name");
            company=Console.ReadLine();
            if(company == "Tcs" || company=="tcs")
            {
                Console.WriteLine("enter employee name");
                name = Console.ReadLine();
                Console.WriteLine("enter employee id");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employee dept");
                dept = Console.ReadLine();
                Console.WriteLine("enter employee designation");
                desg = Console.ReadLine();
                Console.WriteLine("enter employee basic salary");
                basicsalary = Convert.ToDouble(Console.ReadLine());



                Tcs t = new Tcs(empid, name, dept, desg, basicsalary);
                t.Employeedetails();
                Console.WriteLine("Pf amount of employee is " + t.pf());
                Console.WriteLine("gratuity amount of employee  is " + t.gratuity(10, basicsalary));
            }
            else if(company =="Acccenture" || company =="accenture")
            {
                Console.WriteLine("enter employee name");
                name = Console.ReadLine();
                Console.WriteLine("enter employee id");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employee dept");
                dept = Console.ReadLine();
                Console.WriteLine("enter employee designation");
                desg = Console.ReadLine();
                Console.WriteLine("enter employee basic salary");
                basicsalary = Convert.ToDouble(Console.ReadLine());



                Accenture a = new Accenture(empid, name, dept, desg, basicsalary);
                a.Employeedetails();
                Console.WriteLine("Pf amount of employee is " + a.pf());
                Console.WriteLine("gratuity amount of employee  is " + a.gratuity(10, basicsalary));
            }
            else
            {
                Console.WriteLine("enter valid company name");
            }         
        }
    }
}

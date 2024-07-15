
namespace Assaignment5
{
    class Person
    {
        string fname;
        string lname;
        string email;
        string DOB;
        public Person(string fname, string lname, string email, String DOB)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.DOB = DOB;
        }
        public void showdetails()
        {
            Console.WriteLine("first name of person is " + fname + " Last name of person is " + lname);
            Console.WriteLine("Email address " + email);
            Console.WriteLine("date of birth is " + DOB);
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter first name");
            string fname=Console.ReadLine();
            Console.WriteLine("enter Last name");
            string lname = Console.ReadLine();
            Console.WriteLine("enter email address");
            string email = Console.ReadLine();
            Console.WriteLine("enter DOB");
            string DOB = Console.ReadLine();

            Person p = new Person(fname,lname,email,DOB);
            p.showdetails();
        }
    }
}

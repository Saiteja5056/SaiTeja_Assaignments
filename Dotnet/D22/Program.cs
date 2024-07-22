using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ss
{
    internal class sai
    {
        static List<student> l = new List<student>();
        static List<staff> s = new List<staff>();
        public static void addstudent()
        {
            Console.WriteLine("enter student name");
            string Name = Console.ReadLine();
            Console.WriteLine("enter student gender");
            string Gender = Console.ReadLine();
            Console.WriteLine("enter student class");
            string Class = Console.ReadLine();
            Console.WriteLine("Enter section ");
            string Section = Console.ReadLine();
            Console.WriteLine("Enter Date of birth");
            string dob = Console.ReadLine();
            Console.WriteLine("Enter staff name");
            string staff = Console.ReadLine();

            l.Add(new student { name = Name, gender = Gender, SClass = Class, DOB = dob, section = Section, staffname = staff });

            foreach (student student in l)
            {
                Console.WriteLine($"name:{student.name} Gender:{student.gender} ");

            }
        }
        public static void addstaff()
        {
            Console.WriteLine("Enter StaffId");
            int staffId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Staff name");
            string Staffname = Console.ReadLine();
            s.Add(new staff { staffid = staffId, staffName = Staffname });
            foreach (staff staff in s)
            {
                Console.WriteLine($"sid={staff.staffid} sname={Staffname}");
            }

        }
        public static void displaystudentbystaff(string sname)
        {
            if (sname == "sai")
            {
                foreach (student student in l)
                {
                    foreach (staff staff in s)
                    {
                        if (student.staffname.Equals(sname))
                        {
                            Console.WriteLine($"name:{student.name} Gender:{student.gender}");
                        }
                        continue;
                    }
                }
            }
            if (sname == "tej")
            {
                foreach (student student in l)
                {
                    foreach (staff staff in s)
                    {
                        if (student.staffname.Equals(sname))
                        {
                            Console.WriteLine($"name:{student.name} Gender:{student.gender}");
                        }
                        continue;
                    }
                }
            }

        }
        public static void displaystudentbyclass(string sclass)
        {
            if (sclass == "CSE" || sclass == "cse")
            {
                foreach (student student in l)
                {
                    if (student.section.Equals(sclass))
                    {
                        Console.WriteLine($"student name :{student.name} gender :{student.gender} class:{student.section} staffname:{student.staffname}");
                    }
                }
            }
            if (sclass == "ECE" || sclass == "ece")
            {
                foreach (student student in l)
                {
                    if (student.section.Equals(sclass))
                    {
                        Console.WriteLine($"student name :{student.name} gender :{student.gender} class:{student.section} staffname:{student.staffname}");
                    }

                }
            }

        }
        public static void displayallstudents(string path)
        {
            foreach (student student in l)
            {

                File.AppendAllText(path,student.ToString());
                File.AppendAllText(path," \n");
            }

        }



        static void Main()
        {


            while (true)
            {
                Console.WriteLine("MENU:-");
                Console.WriteLine("1.Addstaff");
                Console.WriteLine("2.Addstudent");
                Console.WriteLine("3.Display all Students as per Staff ");
                Console.WriteLine("4.Display all Students as per Class ");
                Console.WriteLine("5.Display all Students and write it in text file.");
                Console.WriteLine("6.Exit");
                int opton = int.Parse(Console.ReadLine());

                switch (opton)
                {
                    case 1:
                        {
                            addstaff();
                            break;
                        }
                    case 2:
                        {
                            addstudent();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("enter which staff list u want to print");
                            string sname = Console.ReadLine();

                            Console.WriteLine("student list under " + sname + "  is");
                            displaystudentbystaff(sname);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("enter which class list u want to print");
                            string sclass = Console.ReadLine();
                            Console.WriteLine("student list under " + sclass + "  is");
                            displaystudentbyclass(sclass);
                            break;
                        }
                    case 5:
                        {
                            string path= "E:\\s.txt";
                            displayallstudents(path);
                            break;
                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }

        }
    }
}


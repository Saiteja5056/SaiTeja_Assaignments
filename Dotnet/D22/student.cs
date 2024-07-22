using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace ss
{
    internal class student
    {
        public int studentID { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string SClass { get; set; }
        public string DOB { get; set; }
        public string section { get; set; }
        public string staffname { get; set; }

        public override string ToString()
        {
            return $"name:{name} gender:{gender}, staffname:{staffname},dob:{DOB}";
        }
    }
}

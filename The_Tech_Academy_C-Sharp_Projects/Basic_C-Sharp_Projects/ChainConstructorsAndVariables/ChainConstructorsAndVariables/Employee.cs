using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainConstructorsAndVariables
{
    class Employee
    {
        // Constructor call chain that inherits properties from the original constructor
        public Employee (string fname, string lname, int id) : this(fname, _Blank, lname, id) { }

        // Original constructor 
        public Employee (string fname, string mname, string lname, int id)
        {
            Firstname = fname;
            MiddleName = mname;
            LastName = lname;
            Id = id;
        }

        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        private const string _Blank = "";
    }
}

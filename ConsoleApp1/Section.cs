using System.Collections.Generic;

namespace ConsoleApp5
{
    class Department
    {
        public string name { get; set; }
        public List<Doctor> doctors = new List<Doctor>();
        public Department()
        {

        }
        public Department(string name)
        {
            this.name = name;
        }
    }
}

using System.Collections.Generic;

namespace ConsoleApp5
{
    class Doctor : Person
    {
        public int experience { get; set; }
        public Dictionary<string, bool> WorkTimes = new Dictionary<string, bool>();
        public Doctor(string name, string surname, int experience)
        {
            this.name = name;
            this.surname = surname;
            this.experience = experience;
            WorkTimes.Add("09:00-11:00", false);
            WorkTimes.Add("12:00-14:00", false);
            WorkTimes.Add("15:00-17:00", false);
        }
    }
}

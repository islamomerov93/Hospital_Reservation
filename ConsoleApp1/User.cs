namespace ConsoleApp5
{
    class User : Person
    {
        public string email { get; set; }
        public string telNum { get; set; }
        public User(string name, string surname, string email, string telnum)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.telNum = telNum;
        }
    }
}

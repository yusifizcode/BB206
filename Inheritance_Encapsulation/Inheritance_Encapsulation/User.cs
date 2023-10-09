namespace Inheritance_Encapsulation
{
    public class User : Human
    {
        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                if (value.Length > 6 && value.Length < 25)
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("Username'i duz daxil ele!!");
                }
            }
        }
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                if (value.Length > 8 && value.Length < 25)
                {
                    _password = value;
                }
            }
        }

        public User(string name, string surname, string userName) : base(name, surname)
        {
            this.UserName = userName;
        }
    }
}

using SRP.Models;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "enver";
            string password = "Enver123";

            Checker checker = new Checker();
            UserCRUD userCRUD = new UserCRUD();
            User user = new User();

            if (checker.UsernameChecker(username))
            {
                user.Username = username;
            }

            if (checker.PasswordChecker(password))
            {
                user.Password = password;
            }

            userCRUD.Create(user);
            userCRUD.Create(new User { Username = "Test", Password = "Test123" });

            foreach (var item in userCRUD.GetAll())
            {
                Console.WriteLine(item.Username + " " + item.Password);
            }
            Console.WriteLine("==================================");
            userCRUD.Remove(user);
            foreach (var item in userCRUD.GetAll())
            {
                Console.WriteLine(item.Username + " " + item.Password);
            }
        }
    }
}
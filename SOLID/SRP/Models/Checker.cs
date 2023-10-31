namespace SRP.Models
{
    internal class Checker
    {
        public bool UsernameChecker(string username)
        {
            if (!String.IsNullOrWhiteSpace(username) && username.Length >= 5 && username.Length <= 15)
            {
                return true;
            }
            return false;
        }

        public bool PasswordChecker(string password)
        {
            if (!String.IsNullOrWhiteSpace(password) && password.Length >= 5 && password.Length <= 15)
            {
                return true;
            }
            return false;
        }
    }
}

namespace SRP.Models
{
    internal class UserCRUD
    {
        public void Create(User user)
        {
            if (user != null)
            {
                Database.Users.Add(user);
            }
        }

        public void Remove(User user)
        {
            Database.Users.Remove(user);
        }

        public List<User> GetAll()
        {
            return Database.Users;
        }
    }
}

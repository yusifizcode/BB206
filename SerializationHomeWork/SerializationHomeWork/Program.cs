using System.Text.Json;

namespace SerializationHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Id = 19;
            user.Name = "Elmar";
            user.Surname = "BYK";
            user.UserName = "Razin";
            SerializeUserToJson(user);
            string path = "C:\\Users\\User\\Desktop\\BB206\\SerializationHomeWork\\SerializationHomeWork\\Data.json";
            User deserializedUser = DeserializeUserFromJSON(path);
            Console.WriteLine(deserializedUser);
        }
        public static void SerializeUserToJson(User user)
        {
            string path = "C:\\Users\\User\\Desktop\\BB206\\SerializationHomeWork\\SerializationHomeWork\\Data.json";
            string serializeData = JsonSerializer.Serialize(user);
            File.WriteAllText(path, serializeData);
        }
        public static User DeserializeUserFromJSON(string path)
        {
            string jsonData = File.ReadAllText(path);
            User user = JsonSerializer.Deserialize<User>(jsonData);
            return user;
        }
    }
}
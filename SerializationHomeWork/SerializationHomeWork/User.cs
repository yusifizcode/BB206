using System.Runtime.Serialization;

namespace SerializationHomeWork
{
    [Serializable]
    public class User : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name, typeof(string));
            info.AddValue("SurName", Surname, typeof(string));
            info.AddValue("UserName", UserName, typeof(string));
            info.AddValue("Id", Id, typeof(int));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

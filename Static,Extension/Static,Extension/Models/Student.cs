using Static_Extension.Extensions;

namespace Static_Extension.Models
{
    public class Student
    {
        private static int _id;
        public int Id { get; set; }
        private string _fullName;
        public string FullName
        {
            get => _fullName;
            set
            {
                if (Helper.CheckFullname(value))
                {
                    _fullName = value;
                }
            }
        }
        private string _groupNo;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (Helper.CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }
        public byte Age { get; set; }

        static Student()
        {
            _id = 0;
        }

        public Student(string fullName, string groupNo)
        {
            _id++;
            Id = _id;
            FullName = fullName;
            GroupNo = groupNo;
        }
    }
}

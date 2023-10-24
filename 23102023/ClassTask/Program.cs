using ClassTask.Models;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher() { Fullname = "Eli Eliyev", Experience = 9 };
            Teacher teacher2 = new Teacher() { Fullname = "Veli Veliyev", Experience = 19 };

            Student student1 = new Student() { Fullname = "Eli Eliyev", GroupNo = "9" };
            Student student2 = new Student() { Fullname = "Velishka Veliyev", GroupNo = "19" };


            MyList<Teacher> teacherList = new MyList<Teacher>();

            teacherList.Add(teacher1);
            teacherList.Add(teacher2);

            MyList<Student> studentList = new MyList<Student>();

            studentList.Add(student2);
            studentList.Add(student1);

            Console.WriteLine("Teacher list:");
            foreach (var item in teacherList.values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Student list:");
            foreach (var item in studentList.values)
            {
                Console.WriteLine(item);
            }

        }
    }
}
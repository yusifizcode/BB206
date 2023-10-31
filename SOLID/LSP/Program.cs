using LSP.Models;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person professor = new Professor();
            professor.GetFullData();
            professor.GetFullname();
            //professor.GetExperience();

            Person teacher = new Teacher();
            teacher.GetFullData();
            teacher.GetFullname();
            //teacher.GetExperience();

            Person student = new Student();
            student.GetFullData();
            student.GetFullname();
            //student.GetExperience();
        }
    }
}
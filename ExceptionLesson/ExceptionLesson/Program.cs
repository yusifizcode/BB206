using ExceptionLesson.Excepptions;
using ExceptionLesson.Models;

namespace ExceptionLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Ad daxil edin: ");
            person.FullName = Console.ReadLine();

            try
            {
                Console.WriteLine("Yash daxil edin: ");
                sbyte age = sbyte.Parse(Console.ReadLine());
                person.Age = age;
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
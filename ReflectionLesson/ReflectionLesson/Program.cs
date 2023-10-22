using System.Reflection;

namespace ReflectionLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();

            foreach (Type type in assembly.GetTypes())
            {
                if (type.Name != "Student" && type.Name != "Program" && type.Name != "WarrantyStudent")
                    continue;

                Console.WriteLine(type.Name + " properties: ");

                foreach (PropertyInfo pr in type.GetProperties())
                {
                    Console.WriteLine($"\t{pr.Name}");
                }

                Console.WriteLine(type.Name + " methods: ");

                foreach (MethodInfo method in type.GetMethods())
                {
                    Console.WriteLine($"\t{method.Name}");
                }

                Console.WriteLine(type.Name + " fields: ");

                foreach (FieldInfo fld in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance))
                {
                    Console.WriteLine($"\t{fld.Name}");
                }
            }


            Student student = new Student();

            var studentType = typeof(Student);
            Console.WriteLine("=======================================================");
            Console.WriteLine(studentType.Name + " fields: ");

            foreach (FieldInfo fld in studentType.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                Console.WriteLine($"Field Name: {fld.Name} Field Value: {fld.GetValue(student)}");
                fld.SetValue(student, 2);
                Console.WriteLine($"Field Name: {fld.Name} Field Value: {fld.GetValue(student)}");
            }

        }
    }
}
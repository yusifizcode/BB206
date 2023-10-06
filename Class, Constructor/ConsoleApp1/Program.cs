public class Program
{
    public static void Main()
    {
        Console.WriteLine("Adinizi daxil edin: ");
        string name = Console.ReadLine();

        Console.WriteLine("Soyadinizi daxil edin: ");
        string surName = Console.ReadLine();

        Console.WriteLine("Ixtisasinizi daxil edin: ");
        string profession = Console.ReadLine();

        //Console.WriteLine("Yashinizi daxil edin: ");
        //string ageStr = Console.ReadLine();
        byte ageNum;
        //while (!byte.TryParse(ageStr, out ageNum))
        //{
        //    Console.WriteLine("Yashinizi daxil edin: ");
        //    ageStr = Console.ReadLine();
        //}
        string ageStr;
        do
        {
            Console.WriteLine("Yashinizi daxil edin: ");
            ageStr = Console.ReadLine();
        } while (!byte.TryParse(ageStr, out ageNum));

        Teacher teacher = new Teacher();
        teacher.Name = name;
        teacher.Surname = surName;
        teacher.Profession = profession;
        teacher.Age = ageNum;

        teacher.ShowFullData();
    }
}

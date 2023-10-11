using System.Text;

namespace StringBuilderLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a = "";
            for (int i = 0; i < 1000; i++)
            {
                a += i;
            }

            //Console.WriteLine(a);

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                stringBuilder.Append(i);

            }

            string s = stringBuilder.ToString();
            Console.WriteLine(s);
        }
    }
}
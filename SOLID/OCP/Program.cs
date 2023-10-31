using OCP.Models;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalc = new AreaCalculator();

            Console.WriteLine(areaCalc.CalcArea(new Rectangle() { Height = 5, Width = 10 }));
        }
    }
}
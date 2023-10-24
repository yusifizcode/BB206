namespace SealedNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee? employee = new Employee();
            employee.Salary = null;

            string? str = null;
        }

        static void GetInfo(int? id)
        {
            if (id != null)
            {

            }
        }
    }
}
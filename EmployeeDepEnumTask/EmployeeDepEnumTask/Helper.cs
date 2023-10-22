namespace EmployeeDepEnumTask
{
    public class Helper
    {
        public static bool CheckNameOrSurname(string str)
        {
            if (!string.IsNullOrWhiteSpace(str) && char.IsUpper(str[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

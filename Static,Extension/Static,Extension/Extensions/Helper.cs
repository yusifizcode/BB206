namespace Static_Extension.Extensions
{
    public class Helper
    {
        public static bool CheckGroupNo(string groupNo)
        {
            // P123
            if (groupNo.Length != 4 && !char.IsUpper(groupNo[0])) return false;
            for (int i = 1; i < groupNo.Length; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckFullname(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName) &&
                fullName.Length != fullName.Trim().Length) return false;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == ' ' && fullName[i + 1] != ' ')
                {
                    return true;
                }
            }

            return false;
        }
    }
}

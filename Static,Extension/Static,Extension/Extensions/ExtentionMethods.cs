namespace Static_Extension.Extensions
{
    public static class ExtentionMethods
    {

        public static int CheckString(this string sentence, string str)//Task1
        {
            int count = 0;
            int index = 0;
            while ((index = sentence.IndexOf(str, index)) != -1)
            {
                count++;
                index += str.Length;
            }
            return count;
        }


        public static bool IsPalindrome(this int number) //Task2
        {
            int number1 = number;
            int number2 = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number2 = number2 * 10 + digit;
                number /= 10;
            }
            return number1 == number2;
        }


        public static bool HasAnyDIgit(this string str) //Task3
        {
            foreach (char character in str)
            {
                if (char.IsDigit(character)) return true;

            }
            return false;
        }



        public static bool IsOdd(this int num)
            => num % 2 == 1;

        public static bool IsEven(this int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }

        public static string ToCapitalize(this string str)
        {
            if (!string.IsNullOrEmpty(str.Trim()))
            {
                return char.ToUpper(str[0]) + str.Substring(1);
            }
            return "String boshluqdan ibaretdir ve ya nulldir!";
        }

        public static int[] GetValueIndexes(this string str, char chr)
        {
            int[] ints = new int[0];
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == chr)
                    {
                        Array.Resize(ref ints, ints.Length + 1);
                        ints[^1] = i;
                    }
                }
            }

            return ints;
        }

        public static bool CustomContains(this string sentence, string word)
        {
            string[] words = sentence.Trim().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

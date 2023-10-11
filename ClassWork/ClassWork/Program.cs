namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "    Hellosad   asdsad     ";
            Console.WriteLine(CustomTrim(example));
            //char wc = 'H';

            //Console.WriteLine(LastIndexOf(example, wc));
            //Console.WriteLine(CustomContain("HEMID", "J"));

            //Console.WriteLine(CustomRep("salam", 'a', 'b'));

            //Console.WriteLine(CustomSubString(4, example, 3));
        }

        public static int LastIndexOf(string sentence, char x)
        {


            for (int i = sentence.Length - 1; i > -1; i--)
            {
                if (sentence[i] == x) return i;
            }

            return -1;

        }

        static bool CustomContain(string source, string value)
        {
            string result = "";

            for (int i = 0; i < source.Length; i++)
            {
                if (source.Substring(i, value.Length) == value)
                {
                    return true;

                }
            }
            return false;
        }

        //static string CustomReplace(string source, char oldchar, char newChar)
        //{
        //    char[] charArray = source.ToCharArray();
        //    for (int i = 0; i < source.Length; i++)
        //    {
        //        if (charArray[i] == oldchar) charArray[i] = newChar;
        //    }

        //    return new string(charArray);
        //}
        static string CustomRep(string source, char oldchar, char newchar)
        {
            //the result array which we return in the end
            string result = "svlvm";
            // salam, a, v
            //iterate over each char in source string
            foreach (char i in source)
            {
                //if current cursor is the old char then add newchar
                if (i == oldchar) result += newchar;

                //just concatinate string
                else result += i;
            }


            return result;


        }

        static string CustomSubString(int index, string source, int length)
        {
            string str = String.Empty;

            if (length + index < source.Length && length > 0)
            {
                for (int i = index; i < length + index; i++)
                {
                    str += source[i];
                }
            }

            return str;

        }
        public static string CustomTrim(string sentence)
        {
            string trimedSen = String.Empty;
            int startWith = 0;
            int endWith = sentence.Length - 1;
            while (startWith < endWith && sentence[startWith] == ' ')
            {
                startWith++;
            }
            while (endWith > startWith && sentence[endWith] == ' ')
            {
                endWith--;
            }
            trimedSen = sentence.Substring(startWith, endWith - startWith + 1);
            return trimedSen;


        }



    }
}
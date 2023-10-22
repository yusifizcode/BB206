using Static_Extension.Extensions;

namespace Static_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;

            //Console.WriteLine(a.IsOdd());

            //string word = "salam";
            //Console.WriteLine(word.ToCapitalize());

            ////int[] arr = word.GetValueIndexes('a');

            //foreach (var index in word.GetValueIndexes('a'))
            //{
            //    Console.WriteLine(index);
            //}

            //string sentence = "Remzi ne var ne yox?";

            //Console.WriteLine(sentence.CustomContains("salam"));

            //Student student = new Student("B2206", "Remzi");
            int a = 1232221;
            string s = "salam necesen salam salam salam";
            Console.WriteLine(s.CheckString("salam")); ;
            Console.WriteLine(a.IsPalindrome());
        }
    }
}
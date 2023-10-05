public class Program
{
    public static void Main()
    {
        //int num1 = 10;
        //int num2 = 20;
        //ChangeNumbers(ref num1, ref num2);
        //Console.WriteLine($"Num1: {num1}; Num2: {num2}");

        //int[] numbers = { 1, -2, 3, -4, -5, 6, 7 };
        //ChangeToPositive(ref numbers);

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine(numbers[i]);
        //}

        Console.WriteLine(Sum(out int num1, out int num2));
    }

    #region 1. Verilen iki ededin yerini deyisdiren metod
    static void ChangeNumbers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine(a + " " + b);
    }

    #endregion

    #region 2. Ədədlərdən ibarət arrayın mənfi elementlərini müsbətə çevirən method yazın. (array assign olmadan göndərilə bilməsin)
    static void ChangeToPositive(ref int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0) arr[i] *= -1;
        }
    }

    #endregion

    #region 3. 2 int parametr qəbul edən bir method yazırsınız. Bu ədədləri Consoledan daxil edirsiniz və əgər int'ə çevirilə bilirsə cəmini qaytarırsınız. (ədədlər mütləq şəkildə method daxilində assign olunmalıdır.)
    static int Sum(out int a, out int b)
    {
        bool check1 = int.TryParse(Console.ReadLine(), out a);
        bool check2 = int.TryParse(Console.ReadLine(), out b);

        if (check1 && check2)
        {
            return a + b;
        }


        return -1;
    }

    #endregion
}
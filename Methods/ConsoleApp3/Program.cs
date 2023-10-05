public class Program
{
    public static void Main()
    {
        int a = GetAverage(95);
        Console.WriteLine(a);

        Console.WriteLine(CheckDevidedBy21(99));

        SumDigitOfNumber(234);
        int[] arr1 = { 2, 34, 45, 56, 76 };
        double[] arr2 = { 2, 34, 45, 56, 76 };
        float[] arr3 = { 2, 34, 45, 56, 76 };
        //Console.WriteLine(MultiOfDevidedByTwo(arr));

        Console.WriteLine(CustomMethod(arr1));
        Console.WriteLine(CustomMethod(arr2));
        Console.WriteLine(CustomMethod(arr3));
        Console.WriteLine(CustomMethod(50, 12, 5, 6, 4, 7, 6));
    }

    #region 1. 1-den M-edek ededler icerisinde 15-e bolunenlerin ededi ortasini geri qaytarsan method 
    static int GetAverage(int m)
    {
        int sum = 0;
        int count = 0;
        for (int i = 1; i < m; i++)
        {
            if (i % 15 == 0)
            {
                count++;
                sum += i;
            }
        }
        return sum / count;
    }

    #endregion

    #region 2. N-den 100-edek ededler icerisinde 21-e bolunen ededin olub olmadigini tapib geri qaytaran method
    static bool CheckDevidedBy21(int n)
    {
        for (int i = n; i < 100; i++)
        {
            if (i % 21 == 0)
            {
                return true;
            }
        }
        return false;
    }
    #endregion

    #region 3. Verilmis ededin reqemlerinin cemini tapib ekranda yazdirin (Mes: 234 -> 9)
    static void SumDigitOfNumber(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine(sum);
    }

    #endregion

    #region 4. Arrayde 2e bolunen ededleri tapib hasilini geri qaytaran method
    static int MultiOfDevidedByTwo(int[] arr)
    {
        int multi = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                multi += arr[i];
            }
        }

        return multi;
    }

    #endregion

    #region Task 5
    //Verilmiş integer array-in  bütün elementlərini
    //string şəkildə qaytaran metod.Misalçün parametr olaraq {1,-4,9,-8}
    //dəyərləri olan array daxil edilsə arqument kimi metod bizə "1 -4 9 -8"
    //dəyərləri olan qaytarmalıdır. Hemin methodu butun elementlerin cəmini geriyə
    //qaytaran şəkildə, içərisində mənfi dəyər olub-olmadığını geriyə qaytaran şəkildə
    //və içərisinə n sayda parametr qəbul edib, həmin parametrlərin hasilini geri qaytaran
    //şəkildə yazırsınız (method overloading).

    static string CustomMethod(int[] arr)
    {
        string str = string.Empty;
        for (int i = 0; i < arr.Length; i++)
        {
            str += arr[i] + " ";
        }
        return str;
    }

    static double CustomMethod(double[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    static bool CustomMethod(float[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                return true;
            }
        }
        return false;
    }

    static int CustomMethod(int m, params byte[] arr)
    {
        m = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            m *= arr[i];
        }
        return m;
    }
    #endregion
}
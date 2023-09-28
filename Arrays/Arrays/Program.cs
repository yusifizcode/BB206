using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrayde 2e bolunen ededlerin sayini tapin.

            //int[] arr = { 1, 2, 34, 5, 7, 6 };
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine($"Cut ededlerin sayi: {count}");

            #endregion

            #region Arrayde cut ededlerin cemini tapin.

            //int[] arr = { 1, 2, 34, 5, 7, 6 };
            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        sum += arr[i];
            //    }
            //}

            //Console.WriteLine($"Cut ededlerin cemi: {sum}");

            #endregion

            #region Array verilir ve n ededi daxil olunur, eger n ededi arrayin icerisindeki istenilen bir ededden boyukdurse true, deyilse false yazdirin.

            //int[] arr = { 1, 2, 34, 5, 7, 6 };
            //int n = 0;
            //bool check = false;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (n > arr[i])
            //    {
            //        check = true;
            //        break;
            //    }
            //}

            //Console.WriteLine(check);

            #endregion

            #region Array verilib [1,2,3,4,4,4,5,6,3,7] en cox tekrarlanan ededi tapin.

            int[] arr = { 1, 2, 3, 4, 4, 4, 5, 5, 5, 6, 3, 7 };
            int count = 0;
            int maxCount = 0;
            int repNum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    repNum = arr[i];
                }
            }

            Console.WriteLine(repNum);
            #endregion

            #region Ededlerden ibaret bir array verilir, bu arrayin icerisindeki en boyuk elementi tapin.

            //int[] arr = { 1, 2, 34, 5, 7, 6 };
            //int maxNum = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > maxNum)
            //    {
            //        maxNum = arr[i];
            //    }
            //}

            //Console.WriteLine(maxNum);

            #endregion

        }
    }
}

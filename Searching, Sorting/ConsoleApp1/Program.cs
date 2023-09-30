using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HomeWork 1

            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int hasil = 1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        hasil *= arr[i];

            //    }
            //}
            //Console.WriteLine(hasil);

            #endregion

            #region HomeWork 2

            //string word = "ters";
            //string word2 = "";
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    word2 += word[i];
            //}
            //Console.WriteLine(word2);

            #endregion

            #region HomeWork 3

            //int[] array = { 4, 5, 6, 7, 13, 15 };
            //double sum = 0;
            //double avg = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];

            //}
            //avg = sum / array.Length;
            //Console.WriteLine(avg);

            #endregion

            #region Bubble Sort

            int[] arr = { 3, 345, 5465, 676, 12, 343, 1, 34 };
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }

            #endregion

            #region Linear Search
            Console.WriteLine("------------Linear Search");
            int wantedNum = 5465;
            int countLin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (wantedNum == arr[i])
                {
                    System.Console.WriteLine($"{i} - {countLin}");
                    break;
                }
                countLin++;
            }
            #endregion

            #region Binary Search
            Console.WriteLine("------------Binary Search");
            int minIndex = 0;
            int maxIndex = arr.Length - 1;
            int mid;
            int countBin = 0;
            while (minIndex <= maxIndex)
            {
                mid = (minIndex + maxIndex) / 2;

                if (arr[mid] == wantedNum)
                {
                    Console.WriteLine($"Axtardiginiz ededin index: {mid} - {countBin}");
                    break;
                }
                else if (arr[mid] > wantedNum)
                {
                    maxIndex = mid - 1;
                }
                else
                {
                    minIndex = mid + 1;
                }
                countBin++;
            }

            #endregion
        }
    }
}

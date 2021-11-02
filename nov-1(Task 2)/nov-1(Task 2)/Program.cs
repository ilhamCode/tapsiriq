using System;
using System.Linq;

namespace nov_1_Task_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lapet = { 1,3,4,5,7,8,22,35,43,51};
            int[] moped = { 2, 9, 14, 13, 15 };
            // verse(lapet);
            //sorting(lapet, moped);
            //minmax(lapet);
            //tekcut(lapet);

        }


        static void verse(int []arr)
        {
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }

        static void sorting(int[]ar1,int[] ar2)
        {
            int[] yeni = ar1.Concat(ar2).ToArray();
            Array.Sort(yeni);
            Array.Reverse(yeni);
            foreach (var item in yeni)
            {
                Console.WriteLine(item);
            }

        }

        static void minmax (int[] arr) {

            Array.Sort(arr);
            int min = arr[0];
            int max = arr[arr.Length-1];
            Console.WriteLine($"maximum is : {max}");
            Console.WriteLine($"minimum is : {min}");
        }


        static void tekcut(int [] arr) {
            int[] tekler = new int [0];
            int[] cutler = new int[0];
            for (int i = 0; i <arr.Length ; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Array.Resize(ref tekler, tekler.Length+1);
                    tekler[tekler.Length-1] = arr[i];
                }
                else {
                    Array.Resize(ref cutler, cutler.Length+1);
                    cutler[cutler.Length-1] = arr[i];

                }
            }

            foreach (var item in tekler)
            {
                Console.WriteLine(item);
            }
            foreach (var item in cutler)
            {
                Console.WriteLine(item);
            }
        }


    }
}

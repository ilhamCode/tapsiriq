using System;

namespace nov_1_task_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] qurumsaq = { 7, 8, 3, 7, 4, 3, 5 };
            //duplicate(qurumsaq);
            //sumOfAll(qurumsaq);
            bool cavab = isExisting(qurumsaq, 3);
            Console.WriteLine(cavab);
        }

        static void duplicate(int[ ] arr )
        {
            int sayi2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int eded = arr[i];
                int sayi = 1;

                for (int o = 1; o < arr.Length; o++)
                {
                    if (o == eded) {

                        sayi = sayi + 1;

                    }
                }
                if (sayi > 1) sayi2 += 1;

            }
            Console.WriteLine(sayi2);

        }
        static void sumOfAll(int[] arr){
            int eded = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                eded = eded + arr[i];
            }
            Console.WriteLine(eded);

        
        }

        static bool isExisting(int[] arr,int eded)
        {
            bool status = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == eded) {
                    status = true;
                   
                }

            }
            return status;

        }
    }
}

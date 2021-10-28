using System;

namespace october_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //tekcut();
            //duzbucaqli();
            vaksin();
        }

        static  void tekcut()
        {
            int eded = Convert.ToInt32(Console.ReadLine());
            if (eded%2 == 0)
            {
                Console.WriteLine("eded cutdur");
            }
            else
            {

                Console.WriteLine("eded tekdir");
            }


        } 
        static void duzbucaqli()
        {
            int eni = Convert.ToInt32(Console.ReadLine());
            int uzunu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"perimetri : {2*(eni+uzunu)}");
            Console.WriteLine($"sahesi : {eni*uzunu}");

        }

        static void vaksin()
        {

            Console.WriteLine("Yasinizi daxil edin   ");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas > 12)
            {
                Console.WriteLine("vaksin vurula biler");
            }
            else
            {
                Console.WriteLine("12 yasina catmayanlara vaksin vurula bilmez");

            }
        }
    }
}

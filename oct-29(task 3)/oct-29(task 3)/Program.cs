using System;

namespace oct_29_task_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Box qutu = new Box(5,6,7);
           int volume =  qutu.volumeOfBox(qutu);
            Console.WriteLine(volume);
        }
        
    }
}

using System;

namespace nov_5_task_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog rooney = new Dog();
            Console.WriteLine("Type a name for your dog");
            Console.WriteLine("");
            rooney.name = Console.ReadLine();
            rooney.getname();
            rooney.eat();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace nov_5_task_3_
{
   public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine(name + " is eating");
        }
    }
}

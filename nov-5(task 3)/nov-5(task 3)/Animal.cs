using System;
using System.Collections.Generic;
using System.Text;

namespace nov_5_task_3_
{
   public abstract class Animal
    {
       public string name { get; set; }

        public void getname() { Console.WriteLine(name); }
        public void setname(string name) { this.name = name; }
        public abstract void eat();

    }
}


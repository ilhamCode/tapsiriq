using System;
using System.Collections.Generic;
using System.Text;

namespace oct_29_task_3_
{
    class Box
    {
      public  int width;
       public  int length;
       public  int height;
        public Box(int width,int length,int height)
        {
            this.width = width;
            this.length = length;
            this.height = height;
        }

        public int volumeOfBox(Box qutu)
        {
            int volume = qutu.height * qutu.length * qutu.width;
            return volume;
        }
    }
}

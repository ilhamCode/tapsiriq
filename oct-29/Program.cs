using System;

namespace oct_29
{







    class Program
    {
        static void Main(string[] args)
        {
            
            Car bmw = new Car("Bmw","745LI","Vanta Black",88,4,8.5);
            bmw.introduce();
           int range =  bmw.rangeCount();
           Console.WriteLine(range);

           Bicycle mybike =new Bicycle("Trek","Verve+","blue");
           Bicycle response = mybike.whatbic();
           Console.WriteLine(response.brand + "  " + response.model); 

           Employee guy = new Employee();
           guy.name="zeynal";
           guy.surname = "qenberov";
           guy.position = "middle developer";
           guy.dailySalary = 56;
          Console.WriteLine(guy.hesabla());
        }
    }
}

using System;

namespace oct_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //hesabla();
            //tekle();
            //misli();
            //topla();
            //circle();
            //triangle();   
userinput();
        }

        static void hesabla(){
            for(int i = 1;i<=100;i++){
                Console.WriteLine(i);
            }
        }

        static void tekle(){
            for(int i = 0;i<=100;i++){
                if(i%2!=0){
                    Console.WriteLine(i);
                }
            }
        }

        static void misli(){
            int eded = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"ededin iki misli : {eded*2}10");
        }

        static void topla(){
            int yenieded = 0;
            for(int i=0;i<=10;i++){
            yenieded = yenieded+i;                
            }
            Console.WriteLine(yenieded);
        }

        static void circle(){
            int radius = 5;
            Console.WriteLine($"Cevrenin sahesi : {2*Math.PI*radius}");
            Console.WriteLine($"Cevrenin perimetri : {Math.PI*Math.Pow(radius,2)}");

        }

        static void calculate(){
            int ilkeded= Convert.ToInt32(Console.ReadLine());
            char isare=Convert.ToChar(Console.ReadKey().KeyChar);
            int ikincieded= Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine(ilkeded isare ikincieded);


        }

        static void triangle(){
                int eded = Convert.ToInt32(Console.ReadLine());
                int yenieded = eded*3;
                String netice = Convert.ToString(eded);
                for(int o=yenieded;o>=0;o--){
                        Console.WriteLine("");
                for(int i = o;i<yenieded;i++){
                    Console.Write(netice);
                }
}
        }
static void userinput(){

    String username = Console.ReadLine();
    String password = Console.ReadLine();
    string usr = "";
    string psw = "";
    int attempt = 0;
    while(attempt<3){
        if(username==usr){
            Console.WriteLine("kecdiniz");
            break;
        }else{
            Console.WriteLine("sifre yanlisdir");
            attempt+=1;
            username = Console.ReadLine();
            password = Console.ReadLine();
        }
    }
            if(attempt>=3) Console.WriteLine("giris baglandi");


}


    }
}

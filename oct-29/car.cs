using System;

class Car:Vehicle{
  
    public double fuelcapacity;
    public int doorcount;
    public double consumtion;

    
    public Car(string brand,string model,string color,double fuelcapacity,int doorcount,double consumption):base(brand,model,color){
            
            this.fuelcapacity = fuelcapacity;
            this.doorcount = doorcount;
            this.consumtion = consumption;
    }

    public void introduce(){
            Console.WriteLine($"Car brand is called : {brand}");
            Console.WriteLine($"Car model is called : {model}");
    }

    public int rangeCount(){

            
            double range = (fuelcapacity/consumtion)*100;
            return Convert.ToInt32(range);
    }
}
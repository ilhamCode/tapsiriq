using System;
class Bicycle:Vehicle{

public double wheelSize;

public Bicycle(string brand,string model,string color,double wheelSize):base(brand,model,color){
    this.brand = brand;
    this.model = model;
    this.color = color;
    this.wheelSize = wheelSize;
}

public Bicycle(string brand,string model,string color):base(brand,model,color){


}

public Bicycle whatbic(){
    Bicycle member = new Bicycle(brand,model,color);
    return member;
}

} 


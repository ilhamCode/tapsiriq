using System;
class Person{
    public string name;
    public string surname;
    public int age;
    public string gender;

    public void greet(){
        Console.WriteLine($"Hi {name} {surname}");
    }

    public void setage(){
        age = Convert.ToInt32(Console.ReadLine());
    }

}
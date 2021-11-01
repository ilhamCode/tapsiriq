using System;
class Student:Person{
    int year;
    int gpa;

    public void Study(){
        Console.WriteLine("I study");
    }

    public void ShowAge(){
        Console.WriteLine($"My age is : {age} years old ");
    }
}
using System;

class Student : Person{         //student class is inheriting Person
    
    public string department;
    int matricno{get;}
    int cgpa{get; set;}
   

    
}

class Person{       //base class
    public string firstname;
    public string surname;
    public string age;
    private string gender;
    private string phoneNumber;

     public string Fullname(){
            return surname + " " + firstname;
        }    
}

public class TestClass{
    //Creating an object for the Student Class
    public static void Main(){
        Student student1 = new Student();
        student1.firstname = "Angela";
        student1.surname = "Andrew";
        student1.department = "Computer Science";
        Console.WriteLine(student1.Fullname());

    }
}
using System.Reflection;
using System;

namespace ss
{
class Program {
  public static void Main () {
    var person = new Person("Angelina", "Female");
    var employee = new Employee("Ostap", "Male", "Cook"); 
    var student = new Student("Oleg", "Brovarskoy", "Male"); 
    var teacher = new Teacher("Alex", "Male");

    Console.WriteLine("\nPerson:");
    person.Print();

    Console.WriteLine("\nEmloyee:");
    employee.Print();

    Console.WriteLine("\nStudent:");
    student.Print();

    Console.WriteLine("\nTeacher:");
    teacher.Print();
  }
}

class Person{
  public string Name{get; set;}
  public string Sex{get; set;}
  public Person(string name, string sex){
    Name = name;
    Sex = sex;
  }
  public Person(){
    Name = "NoName";
    Sex = "NoSex";
  }
    public void Print(){
    Console.WriteLine("This person name is: " + Name);
    Console.WriteLine("This person sex is: " + Sex);
  }
}

class Employee : Person{
  public string Post{get; set;}
  public Employee(string name, string sex, string post){
    Name = name;
    Sex = sex;
    Post = post;
  }
  public Employee(){
    Name = "NoName";
    Sex = "NoSex";
    Post = "NoPost";
  }
    public void Print(){
    Console.WriteLine("This person name is: " + Name);
    Console.WriteLine("This person sex is: " + Sex);
    Console.WriteLine("This person post is: " + Post);
  }
}

class Student : Person{
  public string Surname{get; set;} 
  public Student(string name,  string surname, string sex){
    Name = name;
    Sex = sex;
    Surname = surname;
  }
  public void Print(){
    Console.WriteLine("This person name is: " + Name);
    Console.WriteLine("This person surname is: " + Surname);
    Console.WriteLine("This person sex is: " + Sex);

  }
}

class Teacher : Employee {
  public Teacher(string name, string sex){
    Name = name;
    Sex = sex;
    Post = "History Teacher";
  }
  public void Print(){
    Console.WriteLine("This person name is: " + Name);
    Console.WriteLine("This person sex is: " + Sex);
    Console.WriteLine("This person post is: " + Post);
  }
abstract class Dean : Employee {
  public abstract string deanManagment();
  }
}
}
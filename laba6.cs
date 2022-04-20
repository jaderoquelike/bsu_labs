using System.Reflection;
using System;

namespace ss
{
    class Programm{
        public static void Main(string[] args){
        //Начало программы, первый класс
        //Вывод конструктора питомцев
        var dannah = new Pet("Pes");
        var doggo = new Pet("Dog", "Dachshund", "Dannah");
        var anotherDoggo = new Pet(doggo);
        //Вывод конструктора ветврачей
        var man = new Vet("Sania Hoffman");
        var theManBehindTheVet = new Vet("Valera Bundershaff", 20, "Ordinary-Doc");
        var copyOfMan = new Vet(theManBehindTheVet);
        //Вывод в консоль
        dannah.Print();
        doggo.Print();
        anotherDoggo.Print();
        man.Print();
        theManBehindTheVet.Print();
        copyOfMan.Print();
        //Выше этой надписи находятся компоненты лабы 3
        //Вывод в консоль тестов
        Console.WriteLine("\nНиже описан вывод нужных по лабораторной работе 6 методов:\n");
        Console.WriteLine("Первый класс Pet");
        Console.WriteLine(doggo.Equals(dannah));
        Console.WriteLine(doggo.Equals(anotherDoggo));
        Console.WriteLine(doggo.GetHashCode());
        Console.WriteLine(dannah.GetHashCode());
        Console.WriteLine(doggo.ToString());
        //Второй класс
        Console.WriteLine("\nВторой класс Vet");
        Console.WriteLine(theManBehindTheVet.Equals(man));
        Console.WriteLine(theManBehindTheVet.Equals(copyOfMan));
        Console.WriteLine(theManBehindTheVet.GetHashCode());
        Console.WriteLine(man.GetHashCode());
        Console.WriteLine(theManBehindTheVet.ToString());
        
        }
    }
    class Pet{
    //Питомцы, второй класс
        private string specie = "Undefined";   
            public string Specie{
            get{ return specie; }
            set{ specie = value; }
        }
        private string breed = "Undefined";
            public string Breed{
            get{ return breed; }
            set{ breed = value; }
        }
        private string dicease = "Undefined";
            public string Dicease{
            get{ return dicease; }
            set{ dicease = value; }
        }
        //конструкторы начало
        public Pet(string _Specie){
            Specie = _Specie;
        }
        //Констуктор с одним полем
        public Pet(){
            Specie = "Jack Russel";
        }
        //Конструктор без параметров
        public Pet(string _Specie, string _Breed, string _Dicease){
            Specie = _Specie;
            Breed = _Breed;
            Dicease = _Dicease;
        }
        //Конструтор с полным набором параметров
        public Pet(Pet previousPet){
            Specie = previousPet.Specie;
            Breed = previousPet.Breed;
            Dicease = previousPet.Dicease;
        }
        //Коструктор с копированием параметров
        public void Print(){
            Console.WriteLine("Pet");
            Console.WriteLine("Specie: " + specie);
            Console.WriteLine("Breed: " + breed);
            Console.WriteLine("Dicease: " + dicease);
        }
    //Лаба 6
    public override bool Equals(object obj){
      if (obj==null)
        return false;
      Pet pet = obj as Pet;
      if(pet as Pet == null)
        return false;
      return pet.specie == this.specie && pet.breed == this.breed && pet.dicease == this.dicease;
    }
    public override int GetHashCode(){
    return Specie.GetHashCode() + Breed.GetHashCode() + Dicease.GetHashCode();
    }
    public override string ToString(){
    return $"Вывод по ToString: {Specie}: {Breed}: {Dicease}";
    }
}
    }
    class Vet{
    //Ветврачи, третий класс
        private string name = "Undefined";
            public string Name{
            get{ return name; }
            set{ name = value; }
        }
        private  int exp;
            public int Exp{
            get{ return exp; }
            set{ exp = value; }
        }
        private  string spec = "Undefined";
            public string Spec{
            get{ return spec; }
            set{ spec = value; }
        }
        //конструкторы начало
        public Vet(string _Name){
            Name = _Name;
        }
        //Констуктор с одним полем
        public Vet(){
            Name = "Valery Mcfarland";
        }
        //Конструктор без параметров
        public Vet(string _Name, int _Exp, string _Spec){
            Name = _Name;
            Exp = _Exp;
            Spec = _Spec;
        }
        //Конструтор с полным набором параметров
        public Vet(Vet previousVet){
            Name = previousVet.Name;
            Exp = previousVet.Exp;
            Spec = previousVet.Spec;
        }
        //Коструктор с копированием параметров
        public void Print(){
            Console.WriteLine("Vet");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Experience: " + exp + " years");
            Console.WriteLine("Specialization: " + spec);
        }
    //Лаба 6
    public override bool Equals(object obj){
      if (obj==null)
        return false;
      Vet vet = obj as Vet;
      if(vet as Vet == null)
        return false;
      return vet.name == this.name && vet.exp == this.exp && vet.spec == this.spec;
    }
    public override int GetHashCode(){
    return Name.GetHashCode() + Exp.GetHashCode() + Spec.GetHashCode();
    }
    public override string ToString(){
    return $"Вывод по ToString: {Name}: {Exp}: {Spec}";
    }
  }




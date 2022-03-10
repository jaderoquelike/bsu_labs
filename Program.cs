using System.Reflection;
using System;

namespace ss
{
    class Programm{
        public static void Main(string[] args){
        //Начало программы, первый класс
        //Вывод конструктора питомцев
        var dannah = new Pet("Pes");
        var sharik = new Pet();
        var doggo = new Pet("Dog", "Dachshund", "Dannah");
        var anotherDoggo = new Pet(doggo);
        //Вывод конструктора ветврачей
        var man = new Vet("Sania Hoffman");
        var anotherMan = new Vet();
        var theManBehindTheVet = new Vet("Valera Bundershaff", 20, "Ordinary-Doc");
        var copyOfMan = new Vet(theManBehindTheVet);
        //Вывод в консоль
        dannah.Print();
        sharik.Print();
        doggo.Print();
        anotherDoggo.Print();
        man.Print();
        anotherMan.Print();
        theManBehindTheVet.Print();
        copyOfMan.Print();
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
    }
}
using System.Reflection;
using System;

namespace ss
{
    class Programm{
        public static void Main(string[] args){
        string str = "Hello my name is Roman nice to meet you hope we get along testingtest";
        //Строка
        string[] words = str.Split(" ");
        //Делим строку на слова
        int numofWords = words.Length;
        //Считаем кол-во слов
        int avrg = str.Length / numofWords;
        //Считаем среднее кол-во символов на слово
        for(int i=0; i<numofWords; i++){
            if(words[i].Length <= words[avrg].Length + 2 && words[i].Length >= words[avrg].Length - 2){
                Console.WriteLine(words[i]);
            }
        }
        //Выводим только те слова что отличаются в среднем на два символа
        }
    }
}

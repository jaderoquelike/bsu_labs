using System.Collections.Generic;
using System.Reflection;
using System;

namespace laba11alg
{
    class Programm{
        public static void Main(string[] args){
        List<int> list = new List<int>{1, -3, 3, 4};
        int i;
        int positive = 0;
        int negative = 0;
        for(i=0; i< list.Count; i++){
            if(i>0){
                positive++;
            }else{
                negative++;
            }
        }
        Console.WriteLine("Количество негативных значений в списке равно: " + negative + "\nКоличество положительных элементов в списке равно: " + positive);
        }
    }
}

using System.Reflection;
using System;

namespace ss
{
    class Programm{
    public static void Main(string[] args){
    const int n = 9;
    int two = 0;
    int three = 0;
    int four = 0;
    int five = 0;
    int[] arr = new int[n]{4, 3, 5, 5, 3, 2, 3, 5, 3};
    int i;
    for(i=0; i<n; i++){
        if(arr[i] == 5){
            five++;
        } else if(arr[i] == 4){
            four++;
        } else if(arr[i] == 3){
            three++;
        } else if (arr[i] == 2){
            two++;
        }
    };
    double bad = 1 - (four * 0.1 + five * 0.1);             //100% - ((n-(four+five))*100%);
    double mid = ((four * 4)+(five*5)+(three*3)+(two*2)/n) * 0.01;             //(((four * 4) + (five * 5) + (three * 3) + (two * 2)) / n) * 100%;
    double good = 1 - bad;
        Console.WriteLine("Кол-во пятёрок: " + five);
        Console.WriteLine("Кол-во четверок: " + four);
        Console.WriteLine("Кол-во троек: " + three);
        Console.WriteLine("Кол-во двоек: " + two);
        Console.WriteLine("Кол-во повышенных оценок: " + good);
        Console.WriteLine("Процент успеваемости: " + mid);
    }
}
}
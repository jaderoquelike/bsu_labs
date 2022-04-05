using System;

class Program {
  public static void Main(){
    const int N = 5;
    int acc = 0;
    int[,] arr = new int[N,N];
    int[] arrX = new int[5]{0, 0, 0, 0, 0};
    for (int i = 0; i < N; i++){
      for (int j = 0; j < N; j++){
        arr[i,j] = int.Parse(Console.ReadLine());
      }
    }
    for (int i=0; i<N; i++){
      for (int j=0; j<N; j++){
      acc += arr[i, j];
      arrX[i] = acc/N;
      }
      Console.WriteLine("Среднее арефметическое равно " + arrX[i]);
    }
}
}
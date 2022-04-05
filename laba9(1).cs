using System;

class Program {
  public static void Main () {
    const int N = 5;
    int[,] arr = new int[N,N];
    int[] arrX = new int[5]{1, 1, 1, 1, 1};
    for (int i = 0; i < N; i++){
      for (int j = 0; j < N; j++){
        arr[i,j] = int.Parse(Console.ReadLine());
      }
    }
    for (int i = 0; i < N; i++){
      for (int j = 0; j < N; j++){
        if (i > j) arrX[i] *= arr[i,j];
      }
    }
    for (int i = 0; i<N; i++){
      Console.WriteLine( "Значение равно: " + arrX[i] + ' ');
    }
}
}
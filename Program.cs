using System;

class Program {
    static void Main(string[] args) {
        int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        int m = arr.GetLength(0); 
        int n = arr.GetLength(1); 

        double[] avgCol = new double[n];

        
        for (int j = 0; j < n; j++) {
            int sum = 0; 
            for (int i = 0; i < m; i++) {
                sum += arr[i, j];
            }
            avgCol[j] = (double) sum / m; 
        }

      
        for (int j = 0; j < n; j++) {
            Console.WriteLine("Среднее арифметическое элементов в столбце {0}: {1}", j, avgCol[j]);
        }
    }
}

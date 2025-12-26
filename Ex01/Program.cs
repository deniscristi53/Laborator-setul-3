using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        int suma = 0;

        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
            suma += v[i];
        }

        Console.WriteLine(suma);
    }
}

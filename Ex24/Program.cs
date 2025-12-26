using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        Console.Write(v[0] + " ");
        for (int i = 1; i < n; i++)
            if (v[i] != v[i - 1])
                Console.Write(v[i] + " ");
    }
}

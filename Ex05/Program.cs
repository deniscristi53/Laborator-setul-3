using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n + 1];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int val = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        for (int i = n; i > k; i--)
            v[i] = v[i - 1];

        v[k] = val;

        for (int i = 0; i <= n; i++)
            Console.Write(v[i] + " ");
    }
}

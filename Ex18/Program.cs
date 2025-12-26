using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n + 1];

        for (int i = 0; i <= n; i++)
            a[i] = int.Parse(Console.ReadLine());

        int x = int.Parse(Console.ReadLine());
        int val = 0;

        for (int i = n; i >= 0; i--)
            val = val * x + a[i];

        Console.WriteLine(val);
    }
}

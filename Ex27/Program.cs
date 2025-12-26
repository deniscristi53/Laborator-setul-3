using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int index = int.Parse(Console.ReadLine());

        Array.Sort(v);

        Console.WriteLine(v[index]);
    }
}

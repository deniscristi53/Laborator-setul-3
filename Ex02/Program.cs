using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int k = int.Parse(Console.ReadLine());
        int poz = -1;

        for (int i = 0; i < n; i++)
            if (v[i] == k)
            {
                poz = i;
                break;
            }

        Console.WriteLine(poz);
    }
}

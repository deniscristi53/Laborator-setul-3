using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        int k = 0;

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            if (v[i] != 0)
                v[k++] = v[i];

        while (k < n)
            v[k++] = 0;

        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");
    }
}

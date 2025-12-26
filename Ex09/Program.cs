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
        k %= n;

        for (int r = 0; r < k; r++)
        {
            int primul = v[0];
            for (int i = 0; i < n - 1; i++)
                v[i] = v[i + 1];
            v[n - 1] = primul;
        }

        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");
    }
}

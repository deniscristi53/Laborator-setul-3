using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v1 = new int[n];
        for (int i = 0; i < n; i++)
            v1[i] = int.Parse(Console.ReadLine());

        int m = int.Parse(Console.ReadLine());
        int[] v2 = new int[m];
        for (int i = 0; i < m; i++)
            v2[i] = int.Parse(Console.ReadLine());

        int i1 = 0, i2 = 0;
        while (i1 < n && i2 < m)
        {
            if (v1[i1] <= v2[i2])
                Console.Write(v1[i1++] + " ");
            else
                Console.Write(v2[i2++] + " ");
        }

        while (i1 < n) Console.Write(v1[i1++] + " ");
        while (i2 < m) Console.Write(v2[i2++] + " ");
    }
}

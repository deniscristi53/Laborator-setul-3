using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] prim = new bool[n + 1];

        for (int i = 2; i <= n; i++)
            prim[i] = true;

        for (int i = 2; i * i <= n; i++)
            if (prim[i])
                for (int j = i * i; j <= n; j += i)
                    prim[j] = false;

        for (int i = 2; i <= n; i++)
            if (prim[i])
                Console.Write(i + " ");
    }
}

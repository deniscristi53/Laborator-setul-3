using System;

class Program
{
    static int Cmmdc(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int g = v[0];
        for (int i = 1; i < n; i++)
            g = Cmmdc(g, v[i]);

        Console.WriteLine(g);
    }
}

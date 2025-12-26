using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int x = int.Parse(Console.ReadLine());
        int cnt = 0;

        for (int i = 0; i < n; i++)
            if (v[i] == x)
                cnt++;

        Console.WriteLine(cnt);
    }
}

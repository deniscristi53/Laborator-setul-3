using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        int m = 0;

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            bool ok = true;
            for (int j = 0; j < m; j++)
                if (v[i] == v[j])
                    ok = false;

            if (ok)
                v[m++] = v[i];
        }

        for (int i = 0; i < m; i++)
            Console.Write(v[i] + " ");
    }
}

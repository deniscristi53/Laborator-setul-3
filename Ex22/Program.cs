using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        int m = int.Parse(Console.ReadLine());
        int[] b = new int[m];
        for (int i = 0; i < m; i++)
            b[i] = int.Parse(Console.ReadLine());

        int[] c = new int[n + m];
        int k = 0;

        for (int i = 0; i < n; i++)
            c[k++] = a[i];

        for (int i = 0; i < m; i++)
        {
            bool ok = true;
            for (int j = 0; j < n; j++)
                if (b[i] == a[j])
                    ok = false;

            if (ok)
                c[k++] = b[i];
        }

        for (int i = 0; i < k; i++)
            Console.Write(c[i] + " ");
    }
}

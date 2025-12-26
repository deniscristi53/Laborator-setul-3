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

        for (int i = 0; i < n; i++)
        {
            bool gasit = false;
            for (int j = 0; j < m; j++)
                if (a[i] == b[j])
                    gasit = true;

            if (gasit)
            {
                bool afisat = false;
                for (int k = 0; k < i; k++)
                    if (a[k] == a[i])
                        afisat = true;

                if (!afisat)
                    Console.Write(a[i] + " ");
            }
        }
    }
}

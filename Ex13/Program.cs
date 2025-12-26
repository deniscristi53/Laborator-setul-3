using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            int x = v[i];
            int j = i - 1;

            while (j >= 0 && v[j] > x)
            {
                v[j + 1] = v[j];
                j--;
            }
            v[j + 1] = x;
        }

        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");
    }
}

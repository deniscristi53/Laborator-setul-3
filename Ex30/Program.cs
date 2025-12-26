using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] E = new int[n];
        int[] W = new int[n];

        for (int i = 0; i < n; i++)
            E[i] = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
            W[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
            for (int j = i + 1; j < n; j++)
                if (E[i] > E[j] || (E[i] == E[j] && W[i] < W[j]))
                {
                    int aux = E[i]; E[i] = E[j]; E[j] = aux;
                    aux = W[i]; W[i] = W[j]; W[j] = aux;
                }

        for (int i = 0; i < n; i++)
            Console.WriteLine(E[i] + " " + W[i]);
    }
}

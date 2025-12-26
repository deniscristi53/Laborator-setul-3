using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int candidat = 0, cnt = 0;
        for (int i = 0; i < n; i++)
        {
            if (cnt == 0)
            {
                candidat = v[i];
                cnt = 1;
            }
            else if (v[i] == candidat)
                cnt++;
            else
                cnt--;
        }

        cnt = 0;
        for (int i = 0; i < n; i++)
            if (v[i] == candidat)
                cnt++;

        if (cnt > n / 2)
            Console.WriteLine(candidat);
        else
            Console.WriteLine("nu exista");
    }
}

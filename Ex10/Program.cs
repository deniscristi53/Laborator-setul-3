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

        int st = 0, dr = n - 1, poz = -1;

        while (st <= dr)
        {
            int mid = (st + dr) / 2;

            if (v[mid] == x)
            {
                poz = mid;
                break;
            }
            if (v[mid] < x)
                st = mid + 1;
            else
                dr = mid - 1;
        }

        Console.WriteLine(poz);
    }
}

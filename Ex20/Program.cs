using System;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int cnt = 0;

        for (int i = 0; i <= a.Length - b.Length; i++)
        {
            bool ok = true;
            for (int j = 0; j < b.Length; j++)
                if (a[i + j] != b[j])
                    ok = false;

            if (ok) cnt++;
        }

        Console.WriteLine(cnt);
    }
}

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        string rez = "";

        while (n > 0)
        {
            int r = n % b;
            if (r < 10) rez = r + rez;
            else rez = (char)('A' + r - 10) + rez;
            n /= b;
        }

        Console.WriteLine(rez);
    }
}

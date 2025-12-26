using System;

class Program
{
    static void QuickSort(int[] v, int st, int dr)
    {
        int i = st, j = dr;
        int pivot = v[(st + dr) / 2];

        while (i <= j)
        {
            while (v[i] < pivot) i++;
            while (v[j] > pivot) j--;

            if (i <= j)
            {
                int aux = v[i];
                v[i] = v[j];
                v[j] = aux;
                i++; j--;
            }
        }

        if (st < j) QuickSort(v, st, j);
        if (i < dr) QuickSort(v, i, dr);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        QuickSort(v, 0, n - 1);

        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");
    }
}

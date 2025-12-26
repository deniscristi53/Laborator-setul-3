using System;

class Program
{
    static void Merge(int[] v, int st, int m, int dr)
    {
        int[] temp = new int[dr - st + 1];
        int i = st, j = m + 1, k = 0;

        while (i <= m && j <= dr)
            if (v[i] <= v[j])
                temp[k++] = v[i++];
            else
                temp[k++] = v[j++];

        while (i <= m) temp[k++] = v[i++];
        while (j <= dr) temp[k++] = v[j++];

        for (i = st, k = 0; i <= dr; i++, k++)
            v[i] = temp[k];
    }

    static void MergeSort(int[] v, int st, int dr)
    {
        if (st < dr)
        {
            int m = (st + dr) / 2;
            MergeSort(v, st, m);
            MergeSort(v, m + 1, dr);
            Merge(v, st, m, dr);
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        MergeSort(v, 0, n - 1);

        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");
    }
}

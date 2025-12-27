//Set 1 exercitul 14

using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Introduceti orice numar:");
        int numar = int.Parse(Console.ReadLine());

        int nrInvers = 0;
        int nrInitial = numar;

        while (numar != 0)
        {
            int pal = numar % 10;
            nrInvers = nrInvers * 10 + pal;
            numar /= 10;
        }

        if (nrInitial == nrInvers)
        {
            Console.WriteLine($"Numarul {nrInitial} este palindrom");
        }
        else
        {
            Console.WriteLine($"Numarul {nrInitial} nu este palindrom");
        }
    }
}
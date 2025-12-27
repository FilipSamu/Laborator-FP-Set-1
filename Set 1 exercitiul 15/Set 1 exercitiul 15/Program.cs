//Set 1 exercitiul 15

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti 3 numere:");

        string numere = Console.ReadLine();
        string[] v = numere.Split(' ');

        int a = int.Parse(v[0]);
        int b = int.Parse(v[1]);
        int c = int.Parse(v[2]);

        int min, mid, max;

        if (a <= b && a <= c)
            min = a;
        else if (b <= a && b <= c)
            min = b;
        else
            min = c;


        if (a >= b && a >= c)
            max = a;
        else if (b >= a && b >= c)
            max = b;
        else
            max = c;

        mid = a + b + c - min - max;

        Console.WriteLine($"Numerele in ordine crescatoare sunt:{min} {mid} {max}");
    }
}
// Setul 1 exercitiul 12

using System;
using System.ComponentModel.Design;

class program
{
    static void Main()
    {
        Console.WriteLine("Cate numere divizibile cu n se afla in intervalul dat");
               Console.Write("Introduceti valoarea lui a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Introduceti valoare lui b:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Introduceti numarul de divizibilitate(n):");
        int n = int.Parse(Console.ReadLine());
        int nrdiv = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % n == 0)
            {
                nrdiv++;
            }
            
        }
            Console.WriteLine($"In intervalul [{a}, {b}], sunt {nrdiv} numere divizibile cu {n}");
    }
}

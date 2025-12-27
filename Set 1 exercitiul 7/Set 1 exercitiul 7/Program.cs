//Set 1 exercitiul 7

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti valoarea lui a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Introduceti valoarea lui b: ");
        int b = int.Parse(Console.ReadLine());

        int c = a;
        int d = b;

        Console.WriteLine($"Valorile initiale sunt: a = {a}, b = {b}");
        Console.WriteLine($"Valorile inversate sunt: a = {d}, b = {c}");
    }
}
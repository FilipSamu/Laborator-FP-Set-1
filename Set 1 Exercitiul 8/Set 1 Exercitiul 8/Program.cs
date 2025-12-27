// Set 1 exercitiul 8

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti valoarea pentru a: ");
             int a = int.Parse(Console.ReadLine());
        Console.Write("Introduceti valoarea pentru b: ");
             int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Valorile initiale sunt: a = {a}, b = {b}");

        a = a + b; 
        b = a - b; 
        a = a - b; 

        Console.WriteLine($"Valorile inversate sunt: a = {a}, b = {b}");
    }
}
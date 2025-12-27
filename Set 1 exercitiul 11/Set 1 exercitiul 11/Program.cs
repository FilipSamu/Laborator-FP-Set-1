//Set 1, exercitiul 11

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti un numar oarecare:");
            int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Numarul in ordine inversa este:");

        while (n > 0)
        {
            int cifra = n % 10;
            Console.Write(cifra);
            n = n / 10;
        }
    }
}
//Set 1 exercitiul 18

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti numarul:");
        int n = int.Parse(Console.ReadLine());

        int d = 2;

        Console.WriteLine("Descompunerea in factori primi este:");

        while (n > 1)
        {
            int putere = 0;

            while (n % d == 0)
            {
                putere++;
                n = n / d;
            }

            if (putere > 0)
            {
                Console.Write($"{d}^{putere}");

                if (n > 1)
                {
                    Console.Write(" x ");
                }
            }

            d++;
        }
    }
}
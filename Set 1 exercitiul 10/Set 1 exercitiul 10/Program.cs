using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti un numar intreg:");
        int numar = int.Parse(Console.ReadLine());

        bool estePrim(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        if (estePrim(numar))
        {
            Console.WriteLine("Numarul este prim.");
        }
        else
        {
            Console.WriteLine("Numarul nu este prim.");
        }
    }
}
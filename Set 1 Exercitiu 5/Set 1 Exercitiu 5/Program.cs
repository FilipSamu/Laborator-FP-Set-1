//Tema lab, set 1 , exercitiu 5

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti un numar intreg:");
        long numar = long.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti a k-a cifra de la sfarsitul numarului:");
        int k = int.Parse(Console.ReadLine());
        long cifra = ExtrageCifraDeLaSfarsit(numar, k);
        if (cifra != -1)
        {
            Console.WriteLine($"Cifra de pe pozitia {k} de la sfarsitul numarului {numar} este: {cifra}");
        }
        else
        {
            Console.WriteLine($"Numarul {numar} nu are atatea cifre.");
        }
    }
     static long ExtrageCifraDeLaSfarsit(long numar, int k)
    {
        for (long i = 1; i < k; i++)
        {
            numar /= 10;
            if (numar == 0)
            {
                return -1;
            }
        }
        return Math.Abs(numar % 10);
    }
}


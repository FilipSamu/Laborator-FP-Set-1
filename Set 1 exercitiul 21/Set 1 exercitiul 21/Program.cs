//Set 1 exercitiul 21

using System;

class Program
{
    static void Main()
    {
        int stanga = 1;
        int dreapta = 1024;
        string raspuns;

        Console.WriteLine("Ganditi-va la un numar intre 1 si 1024.");
        Console.WriteLine("Raspundeti cu 'da' sau 'nu'.");

        while (stanga < dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;

            Console.WriteLine($"Numarul este mai mare sau egal decat {mijloc}?");
            raspuns = Console.ReadLine();

            if (raspuns == "da")
            {
                stanga = mijloc;
            }
            else
            {
                dreapta = mijloc - 1;
            }
            
        }

        Console.WriteLine($"Numarul la care v-ati gandit este {stanga}");
    }
}
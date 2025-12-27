//Set 1 exercitiul 13

using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Introduceti un an:");
        int an1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti un alt an:");
        int an2 = int.Parse(Console.ReadLine());

        int numarAnB = 0;

        for (int i = an1; i <= an2; i++)
        {
            if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
            {
                numarAnB++;
            }
        }

        Console.WriteLine($"Intre {an1} si {an2} sunt {numarAnB} de ani bisecti");
    }
}
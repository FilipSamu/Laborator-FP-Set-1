//Set 1 exercitiul 17

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti primul numar:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar:");
        int b = int.Parse(Console.ReadLine());

        int aInitial = a;
        int bInitial = b;

        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }

        int cmmdc = a;
        int cmmmc = (aInitial * bInitial) / cmmdc;

        Console.WriteLine($"CMMDC = {cmmdc}");
        Console.WriteLine($"CMMMC = {cmmmc}");
    }
}
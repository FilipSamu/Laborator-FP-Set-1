//Set 1 exercitiul 16
// Student note: aici nu am stiut cum sa fac afara array uri

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti 5 numere:");
        string linie = Console.ReadLine();
        string[] v = linie.Split(' ');

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        int aux;


        if (a > b)
        { 
            aux = a; a = b; b = aux;
        }
        if (b > c) 
        { 
            aux = b; b = c; c = aux;
        }
        if (c > d)
        { 
            aux = c; c = d; d = aux;
        }
        if (d > e) 
        { 
            aux = d; d = e; e = aux;
        }


        if (a > b) 
        { 
            aux = a; a = b; b = aux;
        }
        if (b > c) 
        { 
            aux = b; b = c; c = aux; 
        }
        if (c > d) 
        { 
            aux = c; c = d; d = aux;
        }


        if (a > b) 
        { 
            aux = a; a = b; b = aux;
        }
        if (b > c) 
        { 
            aux = b; b = c; c = aux;
        }


        if (a > b) 
        { 
            aux = a; a = b; b = aux;
        }

        Console.WriteLine($"Numerele in ordine crescatoare sunt:{a} {b} {c} {d} {e}");
    }
}

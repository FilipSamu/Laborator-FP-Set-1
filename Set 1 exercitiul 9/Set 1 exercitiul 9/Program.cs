//Setul 1 Exercitiul 9

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti un numar intreg: ");
        int numar = int.Parse(Console.ReadLine());
        List<int> divizori = new List<int>();

        for(int i = 1; i<= numar; i++)
        {
            if(numar % i == 0)
            {
                divizori.Add(i);
            }
        }

        Console.WriteLine($"Divizorii numarului {numar} sunt:");

           for(int i = 0; i < divizori.Count; i++)
        {
            Console.WriteLine(divizori[i]);
        }
        


    }
}
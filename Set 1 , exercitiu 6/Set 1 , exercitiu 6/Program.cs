using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Introduceti marimea primei ,supposedly, lature a triunghiului:");
        double a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti marimea celei de a 2 a latura a triunghiului:");
        double b = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti marimea celei de a 3 a latura a triunghiului:");
        double c = int.Parse(Console.ReadLine());

        if(a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Cele 3 laturi pot forma un triunghi");
        }
        else
        {
            Console.WriteLine("Cele 3 laturi nu pot forma un triunghi");
        }
    }

}
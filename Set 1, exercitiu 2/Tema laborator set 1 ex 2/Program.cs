using System;

Console.WriteLine("Rezolvarea ecuatiei de gradul 2: ax^2 + bx + c = 0");

Console.WriteLine("Introduceti a:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti b:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti c:");
int c = int.Parse(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("Ecuatia nu este de gradul 2.");

    if (b == 0 && c == 0)
    {
        Console.WriteLine("Ecuatia are o infinitate de solutii.");
    }
    else if (b == 0 && c != 0)
    {
        Console.WriteLine("Ecuatia nu are solutii.");
    }
    else
    {
        double x = -(double)c / b;
        Console.WriteLine("Ecuatia este de gradul 1.");
        Console.WriteLine($"X = {x}");
    }
}
else
{
    int delta = b * b - 4 * a * c;

    if (delta > 0)
    {
        double radical = Math.Pow(delta, 0.5);

        double x1 = (-b + radical) / (2 * a);
        double x2 = (-b - radical) / (2 * a);

        Console.WriteLine($"X1 = {x1}");
        Console.WriteLine($"X2 = {x2}");
    }
    else if (delta == 0)
    {
        double x = -b / (2.0 * a);

        Console.WriteLine($"X = {x}");
    }
    else
    {
        Console.WriteLine("Ecuatia nu are solutii reale.");
    }
}



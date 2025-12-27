//Set 1, exercitiul 3

using System;

Console.WriteLine("Introduceti primul numar:");
int numar1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduceti al doilea numar:");
int numar2 = int.Parse(Console.ReadLine());

if (numar1 % numar2 == 0)
{
    Console.WriteLine($"{numar1} este divizibil cu {numar2}");
}
else
{
    Console.WriteLine("Numerele introduse nu sunt divizibile");
}
using System;
using System.Runtime.Intrinsics.X86;

//Setul 1, exercitiu 1.

Console.WriteLine("Rezolvarea ecuatie de gradul 1 cu o necunsocuta de tip ax+b=?");
        
Console.WriteLine("Introdudecti primul numar(a): ");
 int a = int.Parse(Console.ReadLine());

Console.WriteLine("Introdudecti al doilea numar(b): ");
 int b = int.Parse(Console.ReadLine());

float EcuatieDeGradul1(int a , int b)
{
   if (a == 0 && b == 0)
    {
        Console.WriteLine("X este egal cu 0");
        return 0;
    }
   else if (a == 0 && b != 0)
    {
                 Console.WriteLine("Ecuatia nu are solutii.");
        return 0;
    }
    else
    {
        return -(float)b / a;
    }
}

float rezultat = EcuatieDeGradul1(a , b);

Console.WriteLine($"X este egal cu {rezultat}");
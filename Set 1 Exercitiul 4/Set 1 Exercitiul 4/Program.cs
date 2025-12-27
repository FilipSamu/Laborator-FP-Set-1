//Tema lab, set 1, exercitiu 4

using System;

Console.WriteLine("Introduceti un an:");
int an = int.Parse(Console.ReadLine());

if ((an % 4 == 0 && an % 100 != 0 ) || an % 400 == 0)
{
    Console.WriteLine($"Anul {an} este bisect.");
}
else
{
    Console.WriteLine($"Anul {an} nu este bisect.");
}

//Student note: am sa comentez si varianta asta pentru orice eventualitate.
// As fi putut folosii si bool.

//bool esteBisect = (an % 4 == 0 && an % 100 != 0 ) || an % 400 == 0;

//if (esteBisect)
//{
//    Console.WriteLine($"Anul {an} este bisect.");
//}
//else
//{
//    Console.WriteLine($"Anul {an} nu este bisect.");
//}
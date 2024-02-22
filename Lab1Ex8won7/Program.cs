/*Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele
trei valori in ordine descrescatoare.
• Exemplu: citim 3 9 0 Afisam : 9 3 0*/


Console.WriteLine("Introduce primul numar; ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce primul numar; ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce primul numar; ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Numerele in ordine descrescatoare sunt: ");

if (x < y)
{
    if (y < z)
    {
        Console.WriteLine($"{z}, {y}, {x}");
    }

    else if (x < y)
    {
        Console.WriteLine($"{y},{z},{x}");
    }

    else
    {
        Console.WriteLine($"{y}, {x}, {z}");
    }
}

else if (y < z)
{
    if (y < z)
    {
        Console.WriteLine($"{z}, {x}, {y}");
    }

    else
    {
        Console.WriteLine($"{x}, {z}, {y}");
    }
}

else
{
    Console.WriteLine($"{x}, {y}; {z} ");
}

Console.ReadLine();
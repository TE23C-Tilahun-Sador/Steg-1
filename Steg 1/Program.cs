// if (6 > 3)
// {
//     Console.WriteLine("Hello World");
//     Console.ReadLine();
// }

// Console.WriteLine("Skriv ditt användarnamn: ");
// string Användarnamn = Console.ReadLine();

// if(Användarnamn == "noname")
// {
//     Console.WriteLine("Welcome!");
//     Console.ReadLine();
// }


int gissning = 0;

Console.WriteLine("Gissa på ett tal: ");
string gissaText = Console.ReadLine();

bool lyckad = int.TryParse(gissaText, out gissning);

while (lyckad = false)
{
    Console.WriteLine("Gissa på ett tal: ");
     gissaText = Console.ReadLine();

     lyckad = int.TryParse(gissaText, out gissning);
}

if (gissning == 23)
{
    Console.WriteLine("Du har rätt");
    Console.ReadLine();
}

else if (gissning < 23)
{
    Console.WriteLine("Du har fel");
    Console.WriteLine("Du gissa för lågt");
    Console.ReadLine();
}

else if (gissning > 23)
{
    Console.WriteLine("Du har fel");
    Console.WriteLine("Du gissa för högt");
    Console.ReadLine();
}





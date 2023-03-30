Console.WriteLine($"Numero de gols do Corinthians");

int corinthians = int.Parse(Console.ReadLine());

Console.WriteLine($"Numero de gols do Chelsea");

int chelsea = int.Parse(Console.ReadLine());

if( corinthians == chelsea )
{
   Console.WriteLine($"Empatou");
   
}

else if( corinthians < chelsea )
{
    Console.WriteLine($"Corinthians perdeu");
    
}

else 

Console.WriteLine($"Corinthians ganhou");






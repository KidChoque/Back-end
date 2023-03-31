Console.WriteLine($" Digite a sua Frequência ");

float frequência = float.Parse(Console.ReadLine()) / 100;

Console.WriteLine($" Digite a sua Média ");

float media = float.Parse(Console.ReadLine());

if( frequência < 0.75 )
{
    Console.WriteLine($" Reprovado ");
    
}

else if( media >= 7){
    Console.WriteLine($"Aprovado");
    
}

else if( media >= 3 )
{
    Console.WriteLine($" Recuperação ");
    
}

else {
    Console.WriteLine($"Reprovado");
    
}
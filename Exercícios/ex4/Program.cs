Console.WriteLine($"Digite sua senha");

int senha = int.Parse(Console.ReadLine());

int correta = 1234;

if( senha == correta )
{
    Console.WriteLine($"Acesso permitido");
    
}

else {
    Console.WriteLine($"Acesso negado");
    
}


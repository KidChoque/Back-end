Console.WriteLine($"Digite a medida dos lados de um triângulo: ");

float lado1 = float.Parse(Console.ReadLine());

float lado2 = float.Parse(Console.ReadLine());

float lado3 = float.Parse(Console.ReadLine());

if( lado1 == lado2 && lado2 == lado3 )
{
    Console.WriteLine($"Triângulo Equilátero");    
}

else if( lado1 == lado2 || lado2 == lado3 || lado1 == lado3 )
{
    Console.WriteLine($"Trângulo Isósceles");    
}

else {
    Console.WriteLine($"Triângulo Escaleno");
    
}


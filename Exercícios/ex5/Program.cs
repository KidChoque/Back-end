Console.WriteLine($"Digite o número de maçãs");

float numero = float.Parse(Console.ReadLine());

float menosdoze = 0.3f;

float maiorigualdoze = 0.25f;


if( numero >= 12 ){
    float preço = numero * maiorigualdoze;
    Console.WriteLine($"O preço da maçãs é { preço }");
    
}

else if( numero < 12 ){
    float preço = numero * menosdoze;
    Console.WriteLine( $"O preço da maçãs é { preço }");
    
}



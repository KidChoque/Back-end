Console.Write($"Informe seu salário: ");

float salário = float.Parse(Console.ReadLine());

float orcamento = 700;


Console.Write($"Informe os gastos: ");

float gastos = float.Parse(Console.ReadLine());

if(gastos <= orcamento)
{
   Console.WriteLine($"Estamos de boa");
   
}
else if(gastos > orcamento)
{
    Console.WriteLine($"Tomamos na tarrasqueta");
    
}

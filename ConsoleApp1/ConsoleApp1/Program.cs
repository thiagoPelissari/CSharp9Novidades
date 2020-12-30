using ConsoleApp1;
using System;

//2 Top Levels calls
 
string name = "Thiago";

// 1 Is not
if (name is not null)
    Console.WriteLine("Não é Nulo!");
else
    Console.WriteLine("É Nulo!");


Console.WriteLine($"O resultado é: {Add(5, 5)}");

//4 Type shorthand instantiation - Atalho de instanciação de tipos
Pessoa p = new() { Id = 1, Nome = "Thiago", SobreNome = "Pelissari" };

p.SobreNome = "Pellizzari";

//Relational <, >, >=, <=
//Logical not, and, or

int temp = 11;

//5. Relational & Logical pattern matching in switch expression
string resultadoTemp = temp switch
{
    > 0 and <= 10 => "Frio",
    <= -5 => " Muito Congelante",
    _ => "Desconhecido"

};


Console.WriteLine($"Temperatura: {resultadoTemp}");


double Add(double x, double y)
{
    return x + y;
}
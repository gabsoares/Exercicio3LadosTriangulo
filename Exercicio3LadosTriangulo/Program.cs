﻿double lado1, lado2, lado3;

Console.Write("Digite o primeiro valor do triângulo: ");
lado1 = double.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor do triângulo: ");
lado2 = double.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor do triângulo: ");
lado3 = double.Parse(Console.ReadLine());

if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
{
    if (lado1 == lado2 && lado1 == lado3)
    {
        Console.WriteLine("Triângulo equilátero");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("Triângulo isósceles");
    }
    else if (lado1 != lado2 && lado1 != lado3)
    {
        Console.WriteLine("Triângulo escaleno");
    }
    else
    {
        Console.WriteLine("É um triângulo, mas não é isósceles, equilátero nem escaleno");
    }
}
else
{
    Console.WriteLine("Os valores informados não formam nenhum tipo de triângulo");
}

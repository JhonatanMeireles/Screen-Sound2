// See https://aka.ms/new-console-template for more information

using Exercicio4_Calculadora.OperacoesMatematica;

Console.WriteLine("Informe o primeiro número:");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo número:");
double number2 = double.Parse(Console.ReadLine());
Console.WriteLine("Escolha um dos operadores (+, -, *, /, ^, ou r) para o calculo:");
char operador = char.Parse(Console.ReadLine());

double v = Calculadora.Calcular(number1, number2, operador);
Console.WriteLine(v);

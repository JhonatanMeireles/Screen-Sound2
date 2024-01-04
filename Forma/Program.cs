using Forma;

Console.WriteLine("Vamos encontrar a área de um retangulo...");
Thread.Sleep(2000);
Console.WriteLine("Informe um número que represente a largura:");
double largura = double.Parse(Console.ReadLine());
Console.WriteLine("Informe um número que represente o comprimento:");
double comprimento = double.Parse(Console.ReadLine());
Retangulo retangulo = new Retangulo(comprimento, largura);
Console.WriteLine("Vamos ver o resultado encontrado da área do retangulo...");
Thread.Sleep(2000);
retangulo.Calcular();

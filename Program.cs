Calculadora calc = new Calculadora();
Console.WriteLine("Informe o valor de x: ");
double x = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
double y = Convert.ToDouble (Console.ReadLine());

double resultadoSoma = calc.Soma(x,y);
Console.WriteLine($"O resultado da soma de {x} e {y} é igual a : {resultadoSoma}");

Console.WriteLine($"O resultado  da subtração é: {calc.Subtracao(x,y)}");

Console.WriteLine($"O resultado da multiplicação é: {calc.Multiplicar(x,y)}");

Console.WriteLine($"O resultado da divisão é: {calc.Divisao(x,y)}");
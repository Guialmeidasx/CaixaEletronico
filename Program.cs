decimal valorSaque, valorRestante = 1.2M;
int  nota1, nota2, nota5, nota10, nota20, nota50, nota100, nota200;
 
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(".....Caixa Eletrônico.....\n");
Console.ResetColor();
 
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("----- Valor de Saque -----:R$");
valorSaque = Convert.ToDecimal(Console.ReadLine());
Console.ResetColor();
 
if  (valorSaque <=0)
{
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("Valor não permitido para saque\n");
return;
}
Console.ResetColor();
 
 
valorRestante = Math.Round(valorRestante,0);
 
valorRestante = valorSaque;
 
nota200 = (int)(valorRestante / 200);
valorRestante = valorRestante % 200;
 
nota100 = (int)(valorRestante / 100);
valorRestante = valorRestante % 100;
 
nota50 = (int)(valorRestante / 50);
valorRestante = valorRestante % 50;
 
nota20 = (int)(valorRestante / 20);
valorRestante = valorRestante % 20;
 
nota10 = (int)(valorRestante / 10);
valorRestante = valorRestante % 10;
 
nota5 = (int)(valorRestante / 5);
valorRestante = valorRestante % 5;
 
nota2 = (int)(valorRestante / 2);
valorRestante = valorRestante % 2;
 
nota1 = (int)(valorRestante / 1);
valorRestante = valorRestante % 1;
 
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine ("Nota(s) para entregar:\n");
 
if (nota1 > 0) Console.WriteLine($"{nota1} nota(s) de R$1,00");
if (nota2 > 0) Console.WriteLine($"{nota2} nota(s) de R$2,00");
if (nota5 > 0) Console.WriteLine($"{nota5} nota(s) de R$5,00");
if (nota10 > 0) Console.WriteLine($"{nota10} nota(s) de R$10,00");
if (nota20 > 0) Console.WriteLine($"{nota20} nota(s) de R$20,00");
if (nota50 > 0) Console.WriteLine($"{nota50} nota(s) de R$50,00");
if (nota100 > 0) Console.WriteLine($"{nota100} nota(s) de R$100,00");
if (nota200 > 0) Console.WriteLine($"{nota200} nota(s) de R$200,00");
 
Console.ResetColor();
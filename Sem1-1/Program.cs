// Принимает на вход 2 числа и проверяет, не является ли первое квадратом второго

Console.WriteLine ("Введи первое число: ");
int num1 = int.Parse (Console.ReadLine ());
Console.WriteLine ("Введи второе число: ");
int num2 = int.Parse (Console.ReadLine ());
if (num1 == num2 * num2)
{
	Console.WriteLine ("ЯВЛЯЕТСЯ");
}
else
Console.WriteLine ("НЕ ЯВЛЯЕТСЯ");	


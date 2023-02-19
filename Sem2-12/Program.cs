//Принимает на вход 2 числа и проверяет кратно ли второе число первому. Если нет, то выводит остаток.

//Мой вариант
Console.WriteLine ("Введите первое число: ");
string? num1Line = Console.ReadLine();
Console.WriteLine ("Введите второе число: ");
string? num2Line = Console.ReadLine ();
if (num1Line != null && num2Line != null)
{
	int num1 = int.Parse (num1Line);
	int num2 = int.Parse (num2Line);
	int result = num1 % num2;
	if (result == 0)
	{
        	Console.WriteLine ("Кратно");
	}	
	else
	{
        	Console.WriteLine ("Остаток - " + result);
	}
}

//Вариант препода
Console.WriteLine ("Введите первое число: ");
int number1 = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine ("Введите второе число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());
if (number1 % number2 == 0)
{
	Console.WriteLine ("Кратно");
}
else
{
	Console.WriteLine ("Не кратно, остаток - " + number1%number2);
}







// Программа получает 2 числа и сравнивает их

Console.WriteLine ("Введите первое число:");
string? num1Line = Console.ReadLine();
Console.WriteLine ("Введите второе число:");
string? num2Line = Console.ReadLine ();
if (num1Line != null && num2Line != null)
{
	int num1 = Convert.ToInt32 (num1Line);
	int num2 = Convert.ToInt32 (num2Line);
//	Console.WriteLine (num1*num2);
	
	if (num1 > num2)
	{
		Console.WriteLine ("Число " + num1Line + " больше");
	}
	else
	{
		if (num1 < num2) 
		{	
			Console.WriteLine ("Число " + num2Line + " больше");
		}	
		else 
		{
			Console.WriteLine ("Числа равны");
		}
	}
}


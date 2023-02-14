//Получает на вход число и выводит все четные числа от 1 до него 
Console.WriteLine("Введите положительное число:");
string? numLine = Console.ReadLine ();
if (numLine != null)
{
	int num = Convert.ToInt32 (numLine);
	if (num < 1)
	{
		Console.WriteLine ("Ошибка!!!	" + numLine + " - не положительное чмсло!");
	}
	else
	{
		string resLine = String.Empty;
		int count = 2;
		while (count <= num)
		{
			resLine = (resLine + " " + Convert.ToString (count) + ",");
			count = count + 2;
		}
		Console.WriteLine (resLine + ".");
	}
}


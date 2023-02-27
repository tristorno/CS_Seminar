//Принимает на вход число и возвращает сумму чисел от 1 до него самого


int Income (string msg)
{
	Console.WriteLine(msg);
	return int.Parse(Console.ReadLine()??"0");
}

int CountSum (int num)
{
	int result = 0;
	if (num > 0)
	{
		for (int i = 1; i <= num; i++)
		result = result + i;
	}
	else
	{
		for (int j = 1; j >= num; j--)
		result = result + j;
	}
	return result;
}



void Outcome (int res)
{
	Console.WriteLine ("Сумма чисел равна "+res);
}




int number = Income ("Введите число: ");
int res = CountSum (number);
Outcome (res);

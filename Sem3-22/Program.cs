// Принимает число n и выдает таблицу квадратов чисел от 1 до n


int DataIncome (string msg) //Считываю ввод
{
	Console.WriteLine (msg);
	return int.Parse (Console.ReadLine() ?? "0"); 
}

void CalcAnswer (int num) //Все вычисления
{
	for (int i = 1; i <= num; i++)
	{
		Console.WriteLine ($"{i} * {i} = "+ i*i);
	}
}

int n = DataIncome ("Введите число ");
CalcAnswer (n);


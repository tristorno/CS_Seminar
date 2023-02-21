//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Income (string msg)
{
	Console.WriteLine (msg);
	return int.Parse(Console.ReadLine()??"0");
}

void Pow3Table (int num)
{
	string line1 = String.Empty;
	string line2 = String.Empty;
	//string line3 = "_";
	for (int i=1; i<=num; i++)
	{
		line1 = line1 + "\t |" + i;
		line2 = line2 + "\t |" + Math.Pow (i,3);
	}

	Console.WriteLine (line1);
	Console.WriteLine (line2);

}

int number = Income ("Введите число: ");
Pow3Table (number);

// Принимает на вход число и возвращает его факториал.

using System.Numerics;
int Income (string msg)
{
	Console.WriteLine (msg);
	return int.Parse(Console.ReadLine()??"0");
}

void Outcome (BigInteger factorial, int number)
{
	Console.WriteLine ($"Факториал числа {number} равен "+factorial);
}


BigInteger CountFactorial (int number)
{
	BigInteger factorial = 1;
	for (int i=2; i<=number; i++)
	{
		factorial=factorial*i;
	}
	return factorial;
}



int num = Income ("Введите число: ");
BigInteger fact = CountFactorial(num);
Outcome (fact, num);

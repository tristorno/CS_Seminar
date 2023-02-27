// Принимает на вход число и выдает кол-во цифр в числе

int Income (string msg)
{
	Console.WriteLine(msg);
	return int.Parse(Console.ReadLine()??"0");
}

int CountDigits (int numero)
{
	int dig=0;
	for (int i=1; numero>9; i++)
	{
		numero = numero/10;
		dig = i;
	}
	dig += 1;
	return dig;
}

void Outcome (int digits)
{
	Console.WriteLine ($"В числе всего {digits} цифр");
}


int num = Income ("Введите число: ");
int numberDigits = CountDigits(num);
Outcome (numberDigits);

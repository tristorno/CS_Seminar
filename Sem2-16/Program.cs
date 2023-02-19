// Принимает на вход два числа и проверяет. является ли одно квадратом другого. На выходе: да или нет
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");
/* мой код
int numMax;
int numMin;
if (num1 >= num2)
{
	numMax = num1;
	numMin = num2;
}
else
{
	numMax = num2;
	numMin = num1;
}
if (numMin*numMin==numMax)
{
	Console.WriteLine("ДА");
}
else
{
	Console.WriteLine("НЕТ");
}
*/
void Square (int arg1, int arg2)
{
	if (arg1==arg2*arg2)
	{
		Console.WriteLine("ДА");
	}
	else
	{
		Console.WriteLine("NO");
	}
}
Square (num1,num2);
Square (num2,num1);

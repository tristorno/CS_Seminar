// Выводит 3 цифру заданного числа, либо пишет об ее отсутствии
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0"); //считываю число и перевожу в int
if (num<100) //Проверяю на наличие третьей цифры
{
	Console.WriteLine("Третья цифра отсутствует");
}
else
{
	while (num>999)
	{
		num=num/10;
	}
	Console.WriteLine ("Третья цифра - "+num%10);
}

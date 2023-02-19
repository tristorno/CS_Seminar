//Принимает на вход число и проверяет кратно ли оно одновременно 7 и 23. Вывод: да или нет.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");
if (num%7==0 && num%23==0)
{
	Console.WriteLine("ДА");
}
else
{
	Console.WriteLine("НЕТ");
}

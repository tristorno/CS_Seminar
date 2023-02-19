//Принимает на вход трехзначное число и возвращает вторую цифру
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()??"0");
if (num<1000 && num>99)
{
	Console.WriteLine(num/10%10);
}
else
{
	Console.WriteLine ($"Число {num} не трехзначное!");
}

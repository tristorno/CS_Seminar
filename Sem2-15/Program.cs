//Принимает на вход цифру-день недели. На выход выдает является ли этот день выходным (да или нет). С использованием Dictionary.
Console.WriteLine("Введите цифру дня недели в формате 1-7: ");
int num = int.Parse(Console.ReadLine()??"0");
var week = new Dictionary<int, string>()
{
	{1, "Нет"},
	{2, "Нет"},
	{3, "Нет"},
	{4, "Нет"},
	{5, "Нет"},
        {6, "Да"},
        {7, "Да"},
};
Console.WriteLine(week[num]);



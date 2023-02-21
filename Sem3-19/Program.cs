//Прогорамма принимает на вход четырехзначное число и проверяет через словарь, является ли оно палиндромом.

int DataIncome (string msg) //Считывание введенного числа
{
	Console.WriteLine (msg);
	int tmp = int.Parse (Console.ReadLine() ?? "0");
	if (tmp < 1000 || tmp > 9999)
	{
		Console.WriteLine($"!!! ОШИБКА !!!");
		return 1;
	}
	else
	{
		return tmp;
	}
}


        var DictOfPalindromes = new Dictionary <int, string>(); //Создаю и заполняю словарь четырехзначных палиндромов
        DictOfPalindromes.Add (1, "Не четырехзначное число");
	for (int i = 1000; i < 10000; i++)
        {
                string? val = (i / 1000 == i % 10 && i / 100 % 10 == i / 10 % 10)? "Да" : "Нет";
                DictOfPalindromes.Add (i, val);
        }

int number = DataIncome ("Введите четырехзначное число: ");
Console.WriteLine (DictOfPalindromes [number]);


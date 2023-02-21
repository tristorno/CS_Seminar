//На вход получаем номер четверти на координатной плоскости и возвращает диапазон значений от нее.

//Метод получает номер четверти
int QuaterNum (string msg)
{
	Console.WriteLine(msg);
	return int.Parse (Console.ReadLine() ?? "0");
}

void Answer (int num)
{
	var quaters = new Dictionary <int, string>()
        {
                {1, "Положительный x и положительный y"},
                {2, "Положительный x и отрицательный y"},
                {3, "Отрицательный x и отрицательный y"},
                {4, "Отрицательный x и положительный y"},
        };
        Console.WriteLine (quaters[num]);
}

int num = QuaterNum ("Введите номер искомой четверти: ");
if (num < 1 || num > 4)
{
	Console.WriteLine("Ошибка! Число должно быть от 1 до 4");
}
else
{
	Answer(num);
}


//Считать введенное число и возвратить его квадрат

Console.WriteLine ("Введите число: ");
string? inputNum = Console.ReadLine();	//считать из консоли
int result; //объявил переменную в которую запишу пезультат умножения
if (inputNum != null)	//проверяю чтобы ввод был не пустым
{
	int number = int.Parse (inputNum); //Парсим введенное число
	result = number * number;      	//Нахожу квадрат
	//Делаю вывод:
	Console.WriteLine ("Квадрат этого числа равен: "+result);
}

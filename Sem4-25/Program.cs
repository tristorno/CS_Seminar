//Калькулятор с 4 основными операциями

//Ввод данных
string Income (string msg)
{
	Console.WriteLine (msg);
	return Console.ReadLine();
}


//Вывод данных
void Outcome (double number1, double number2, string  operation, double result)
{
	Console.WriteLine (number1 + operation + number2 + " = "+ result);
}

//Вычисление
double CountRes (double number1, string operation, double number2)
{
	double result = 0;
	if (operation == "+")	result = number1 + number2;
	if (operation == "-")   result = number1 - number2;
	if (operation == "*")   result = number1 * number2;
	if (operation == "/")   result = number1 / number2;
	if (operation == "^")	result = Math.Pow(number1,number2);
	return result;
}



//Конвертирование в double
double Convert (string num)
{
	return System.Convert.ToDouble(num);
}


string number1Str = Income ("Введите первое число: ");
string operation = Income ("Введите арифметическую операцию: +, -, *, /, или ^ для возведения в степень ");
string number2Str = Income ("Введите второе число: ");
double number1 = Convert (number1Str);
double number2 = Convert (number2Str);
double result = CountRes (number1, operation, number2);
Outcome (number1, number2, operation, result);




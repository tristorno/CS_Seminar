// Принимает на вход число и выводит сумму его цифр.

using System;
using System.Globalization;

//Ввод числа
string Income (string msg)
{
	Console.WriteLine(msg);
	return Console.ReadLine()??"0";
}


//Вывод результата.
void Outcome (int resultStr, int resultInt)
{
	Console.WriteLine ("\nСумма цифр при подсчете через тестовый массив равна "+ resultStr);
	Console.WriteLine ("Сумма цифр при подсчете числовым методом равна "+ resultInt);
	/*
	if (timeChar>timeInt)
	{
		Console.WriteLine ($"Скорость выполнения через символьный массив выше на {timeInt*100/timeChar}%");
	}
	else
	{
		Console.WriteLine ($"Скорость выполнения числовым методом выше на {timeChar*100/timeInt}%");
	}
*/
}



//Создание и заполнение массива тестом
char[] ArrayFilling (string number)
{
	char[] digit = new char [number.Length];
	for (int i=0; i<number.Length; i++)
	{
		digit[i] = number[i];
	}
		return digit;
}

//Подсчет (от текста к числам)
int CountChar (char[] digit)
{
	int result = 0;
	for(int i=0; i<digit.Length; i++) 
	{	
		result=result+(System.Convert.ToInt32(digit[i])-48);
	}
	return result;
}

//Подсчет числовым способом
int CountInt (string numberStr)
{
	int result = 0;
	int number = System.Convert.ToInt32(numberStr);
	while (number > 9)
	{
		result+=number%10;
		number=number/10;	
	}
	return result+number;
}

//Замер времени начала выполнения
DateTime CountTime()
{
	DateTime timeNow = DateTime.Now;
	return timeNow;
}

string number = Income("Введите число: ");
DateTime d1 = CountTime();
char [] digit = ArrayFilling (number);
int resultStr = CountChar(digit);
DateTime d2 = CountTime();
int resultInt = CountInt (number);
DateTime d3 = CountTime();
Console.WriteLine($"Время подсчета текстовым методом равно {d2-d1}");
Console.WriteLine($"Время подсчета числовым методом равно {d3-d2}");
Outcome (resultStr, resultInt);

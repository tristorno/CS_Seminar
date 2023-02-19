//Вывести рандомное число от 10 до 99, сравнить какая из цифр этого числа бОльшая и вывести его.

System.Random numSintezator = new System.Random();

/*
Вариант 1.

int rndNum = numSintezator.Next (10,100);
int num1 = rndNum / 10;
int num2 = rndNum % 10;
if (num1 > num2)
{
	Console.WriteLine("Наибольшая цифра = " + num1);
}
else
{

        Console.WriteLine("Наибольшая цифра = " + num2);
}
*/

//Вариант 2
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
int num1 = ((int) digits [0]) - 48;
int num2 = ((int) digits [1]) - 48;
int resNum = (num1 > num2)? num1 : num2;
Console.WriteLine("Наибольшая цифра = " + resNum);

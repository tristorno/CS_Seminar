﻿////////////////////////////////////////////////////////////////////////////////////////
//Принимает 3 числа и проверяет, может ли существовать треугольник с такими сторонами.//
////////////////////////////////////////////////////////////////////////////////////////

//Ввод значений
int Income (string msg)
{
    Console.WriteLine (msg);
    int number = int.Parse(Console.ReadLine()??"0");

    return number;
}

//Вычисления и вывод//
void Count (int n1, int n2, int n3)
{
    bool res = false;
    if (n1<=n2+n3 && n2<=n1+n3 && n3<= n1+n2)
    {
        res=true;
    }

    Console.WriteLine(res);
}

int n1 = Income("Введите длинну первой стороны тругольника: ");
int n2 = Income("Введите длинну второй стороны тругольника: ");
int n3 = Income("Введите длинну третьей стороны тругольника: ");
Count(n1, n2, n3);
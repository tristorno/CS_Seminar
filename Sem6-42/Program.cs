/////////////////////////////////////////////////////////
//Программа преобразования десятичного числа в двоичное//
/////////////////////////////////////////////////////////

//Ввод данных
int Income(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//Вывод данных//
void Outcome (int number, string res)
{
    Console.WriteLine(number+" в двоичном счислении будет: "+res );
}

//Перевод в двоичное счисление//
string Binary (int number)
{
    string result = string.Empty;
    while (number>1)
    {
        result=Convert.ToString(number%2)+result;
        number=number/2;
    }
    return number+result;
}

int number = Income ("Введите число: ");
string res = Binary (number);
Outcome (number, res);
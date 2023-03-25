////////////////////////////////////////////////
//Вывести все натуральные числа от N до одного//
////////////////////////////////////////////////

int number = (Income("Введите число: "));
GenerateString (number);

////////////////////
///////Методы///////


///Ввод
int Income (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}


///Генерация строки рекурсией
void GenerateString (int num)
{
    Console.Write(num+" ");
    if (num==1)
    {}
    else {
    GenerateString(num-1);
    }
}
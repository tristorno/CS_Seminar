///////////////////////////////////////////////////////////////////////////////////////////////////////////
// Создать двумерный массив.///////////////////////////////////////////////////////////////////////////////
//Найти в массиве введенное число и покрасить его в другой цвет или написать, такого числа в массиве нет.//
///////////////////////////////////////////////////////////////////////////////////////////////////////////

int number = Income("Введите число: ");
int[,] array = GenerateArray();
Outcome(array, number);



//////////////////////////
///МЕТОДЫ/////////////////

///Вывод
void Outcome (int[,] array, int number)
{
     Console.WriteLine ($"В массиве найдено {FindNumber(array, number)} значений.");
     for (int i = 0; i < array.GetLength(0); i++)
     {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i,j] == number)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write($"|{array[i,j]}|\t");
            Console.ResetColor();
        }
        Console.WriteLine();
     }
}


///Ввод
int Income (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}


///Рандомайзер
int Randomize (int min, int max)
{
    return new Random().Next(min,max);
}


///Генерация массива
int[,] GenerateArray ()
{
    int[,] array = new int [Randomize(2, 10), Randomize(3,18)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=Randomize(-9,100);
        }
    }

    return array; 
}


///Поиск числа в массиве
int FindNumber (int[,] array, int number)
{
    int finds = 0; //место для найденных значений
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]==number)
            finds++;
        }
    }
    return finds;
}
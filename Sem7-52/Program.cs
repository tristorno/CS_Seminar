//////////////////////////////////////////////
//.....................................///////
//Задать произвольный двумерный массив.///////
//Вывести ср арифметическое каждого столбца.//
//////////////////////////////////////////////

int[,] array = GenerateArray();
OutcomeArray(array);
OutcomeCount(array);



////////////////////////////////////
///МЕТОДЫ///////////////////////////


///Вывод массива
void OutcomeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write($"|{array[i, j]}|\t");
        }
        Console.WriteLine();
    }
}


//Вывод результата
void OutcomeCount(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write ($"Cреднее арифметическое чисел столбца {j+1} равна: ");
        Console.WriteLine (Math.Round(CountInColumn(j, array),2));
    }
}

///Рандомайзер
int Randomize(int min, int max)
{
    return new Random().Next(min, max);
}


///Генератор массива
int[,] GenerateArray()
{
    int[,] array = new int[Randomize(2, 30), Randomize(3, 18)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Randomize(-999, 10000);
        }
    }
    return array;
}


///Подсчет столбцов
double CountInColumn(int j, int[,] array)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += array[i, j];
    }
    return result/array.GetLength(0);
}
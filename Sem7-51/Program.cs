////////////////////////////////////////////////////////////////////////////
//Задать двумерный массив.//////////////////////////////////////////////////
//Подсчитать сумму значений элементов по главной диагонали 0:0, 1:1 и т.д.//
////////////////////////////////////////////////////////////////////////////

int[,] array = GenerateArray();
int result = CountDiagValues(array);
Outcome(array, result);




///////////////
///МЕТОДЫ//////

///Генерация массива
int[,] GenerateArray()
{
    int[,] array = new int[Randomize(2, 40), Randomize(2, 15)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Randomize(-9, 100);
        }
    }
    return array;
}


///Вывод данных
void Outcome(int[,] array, int result)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Сумма значений по главной диагонали равна: " + result);
}



///Рандомайзер
int Randomize(int min, int max)
{
    return new Random().Next(min, max);
}


///Подсчет значений элементов по диагонали
int CountDiagValues(int[,] array)
{
    int result = 0;
    int minSize = (array.GetLength(0) < array.GetLength(1)) ? array.GetLength(0) : array.GetLength(1);
    int i = 0;
    while (i < minSize)
    {
        result += array[i,i];
        i++;
    }
    return result;
}
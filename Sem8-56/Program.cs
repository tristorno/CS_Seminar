//////////////////////////////////////////////////////////////////////
//Подсчитать в каждой строке двумерного массива///////////////////////
//сумму значений элементов и выдать номер строки с наименьшей суммой//
//////////////////////////////////////////////////////////////////////

int[,] arr2d = GenerateArr();
OutcomeArr2d(arr2d);
int[] resultArr = FillSum(arr2d);
OutcomeArr(resultArr);
SearchMinSum (resultArr);

/////////////////////
////////МЕТОДЫ///////


///Рандомайзер
int Randomize(int min, int max)
{
    return new Random().Next(min, max);
}


///Генерация массива
int[,] GenerateArr()
{
    int[,] array = new int[Randomize(2, 7), Randomize(2, 18)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Randomize(-999, 10000);
        }
    }
    return array;
}


///Вывод 2d массива
void OutcomeArr2d(int[,] array)
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


///Подсчет сумм значений в строках
int CountValues(int[,] array, int rowIndex)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[rowIndex, j];
    }
    return sum;
}


///Создание и заполнение массива с итогом подсчета
int[] FillSum(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];

 for (int i = 0; i < sumArray.Length; i++)
    {
        sumArray[i] = CountValues(array, i);
    }
    return sumArray;
}


///Вывод 1d массива
void OutcomeArr (int[] array)
{
    Console.WriteLine ("Суммы строк:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine ($"|{array[i]}|\t");
    }
    Console.WriteLine();
}


///Поиск наименьшей суммы и вывод результата
void SearchMinSum (int[] array)
{
    int minRow = -1;
    int minSum = 10000;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < minSum)
        {
            minSum = array[i];
            minRow = i;
        }
    }
    Console.WriteLine ($"Минимальная сумма {minSum} в строке номер {minRow+1} (индекс {minRow})");
}

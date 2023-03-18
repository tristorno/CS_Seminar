/////////////////////////////////////////////////
//Найти наименьший элемент в двумерном массиве.//
//Удалить строку и столбец с этим элементом.///// 
/////////////////////////////////////////////////

int[,] array = GenerateArray();
OutcomeArray(array);
int[] minimum = (SearchMinValue(array));
OutcomeInt(minimum);
int[,] arrayModif = DeleteRowCol(array, minimum);
OutcomeArray(arrayModif);


////////////////////
///////МЕТОДЫ///////
//хххххххххххххххх//



//Рандомайзер
int Randomize(int min, int max)
{
    return new Random().Next(min, max);
}


//Вывод массива
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


//Генерация массива
int[,] GenerateArray()
{
    int[,] array = new int[Randomize(2, 27), Randomize(2, 18)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Randomize(-999, 10000);
        }
    }
    return array;
}

//Поиск наименьшего элемента
int[] SearchMinValue(int[,] array)
{
    int[] minimum = new int[3] { 0, 0, 9999 };             //Сюда записывается минимальное значение [2]
                                                           //и его координаты [0,1]
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minimum[2])
            {
                minimum[2] = array[i, j];
                minimum[0] = i;
                minimum[1] = j;
            }
        }
    }
    return minimum;

}


//Вывод чисел
void OutcomeInt(int[] min)
{
    Console.WriteLine("Минимальное значение массива равно " + min[2]);
    Console.WriteLine($"Адрес минимального значения: {min[0]};{min[1]}");
}


//Удаление строки и столбца
int[,] DeleteRowCol(int[,] arrayOrigin, int[] min)
{
    int[,] arrayModif =
    new int[(arrayOrigin.GetLength(0) - 1), (arrayOrigin.GetLength(1) - 1)];
    for (int i = 0; i < arrayModif.GetLength(0); i++)
    {
        for (int j = 0; j < arrayModif.GetLength(1); j++)
        {
            if (i < min[0] && j < min[1])
            {
                arrayModif[i, j] = arrayOrigin[i, j];
            }
            else if (i < min[0] && j >= min[1])
            {
                arrayModif[i, j] = arrayOrigin[i, j + 1];
            }
            else if (i >= min[0] && j < min[1])
            {
                arrayModif[i, j] = arrayOrigin[i + 1, j];
            }
            else if (i >= min[0] && j >= min[1])
            {
                arrayModif[i, j] = arrayOrigin[i + 1, j + 1];
            }
        }
    }
    return arrayModif;
}
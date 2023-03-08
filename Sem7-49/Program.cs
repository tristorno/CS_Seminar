////////////////////////////////////////////////////////////////////////////////////////
//Создать и заполнить двумерный массив./////////////////////////////////////////////////
//Для элементов, у которых оба индекса четные, значения зпменить на квадраты значений.//
////////////////////////////////////////////////////////////////////////////////////////

int[,] array = GenerateArray();
Outcome("Первоначальный массив:", array);
int[,] modArray = ModifyArray(array);
Outcome("Измененный массив:", modArray);



////////////////////////////
///МЕТОДЫ///////////////////

//Генерация и заполнение массива
int[,] GenerateArray()
{
    int[,] array = new int[Randomize(2, 30), Randomize(2, 15)];
    for (int i = 0; i < array.GetLongLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Randomize(1, 51);
        }
    }
    return array;
    ;
}

//Рандомайзер
int Randomize(int min, int max)
{
    return new Random().Next(min, max);
}

//Вывод
void Outcome(string msgFin, int[,] array)
{
    Console.WriteLine(msgFin);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


//Замена значений у четных элементов на их квадрат
int[,] ModifyArray(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 2; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] = Convert.ToInt32(Math.Pow(array[i,j],2));
        }
    }

    return array;
}

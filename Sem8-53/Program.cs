//////////////////////////////////////////////////////////////////
//Поменять местами первую и последнюю строки двумерного массива.//
//////////////////////////////////////////////////////////////////


int[,] array = GenerateArray();
Outcome(array);
ChangeRows(array);
Outcome(array);




/////////////////////////////
///////////МЕТОДЫ////////////
//*************************//

//Вывод массива
void Outcome(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0 || i == (array.GetLength(0)) - 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.Write($"|{array[i, j]}|\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


//Рандомайзер
int Randomize(int min, int max)
{
    return new Random().Next(min, max);
}


//Смена строк
void ChangeRows(int[,] array)
{
    int[,] tempArr = new int[2, array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tempArr[0, i] = array[0, i];
        tempArr[1, i] = array[array.GetLength(0)-1, i];
        array[0,i] = tempArr [1,i];
        array[array.GetLength(0)-1,i]=tempArr[0,i];
    }
}


//Генерация массива
int[,] GenerateArray()
{
    int[,] array = new int[Randomize(3, 15), Randomize(3, 18)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Randomize(-999, 1000);
        }
    }
    return array;
}
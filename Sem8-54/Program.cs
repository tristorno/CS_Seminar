//__________________________________________________________________________________//
//Упорядочить по убыванию значения элементов внутри каждой строки двумерного массива//
//////////////////////////////////////////////////////////////////////////////////////

int[,] array = GenerateArray();
OutcomeArray(array);
SortArray(array);
OutcomeArray (array);

////////////////////
///////МЕТОДЫ///////


///Рандомайзер
int Randomize(int min, int max)
{
    return new Random().Next(min, max);
}


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
    Console.WriteLine();
}


///Генератор массива
int[,] GenerateArray()
{
    int[,] array = new int[Randomize(2, 8), Randomize(2, 18)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Randomize(-999, 10000);
        }
    }
    return array;
}


///Сортировка массива
void SortArray(int[,] array)
{
    //int k=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int k = 0;
        while (k<array.GetLength(1))
        {
            for (int j = 0; j < array.GetLength(1)-1-k; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int tmp = array[i,j];
                    array[i,j] = array[i, j+1];
                    array[i, j+1] = tmp;
                }
            }
            k++;
        }
    }
}

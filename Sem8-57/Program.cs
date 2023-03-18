////////////////////////////////////////////////////////////
//Составить частотный словарь элементов двумерного массива//
////////////////////////////////////////////////////////////

int [,] array = GenerateArray();
OutcomeArray (array);
CountElementsFrequency (array);


///////////////////
//////МЕТОДЫ///////


///Рандомайзер
int Randomize (int min, int max)
{
    return new Random().Next(min, max);
}


///Генератор массива
int[,] GenerateArray ()
{
    int[,] array = new int[Randomize(2,30), Randomize (2,18)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Randomize (0,11);
        }
    }
    return array;
}

///Вывод массива
void OutcomeArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"|{array[i,j]}|\t");
        }
        Console.WriteLine();
    }

}


///Подсчет
void CountElementsFrequency (int[,] array2D)
{
    int[] arrayFreqElem = new int [11];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayFreqElem[array[i,j]]++;
        }
    }
    Console.WriteLine();
    for (int i = 0; i < arrayFreqElem.Length; i++)
    {
                Console.Write($"[{arrayFreqElem[i]}]\t");
    }
}
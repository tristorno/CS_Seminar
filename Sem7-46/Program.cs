//////////////////////////////////////
//Создать двумерный рандомный массив//
//////////////////////////////////////

int[,] array = GenerateArray();
Outcome(array);



///////////////////////////////////////////////
//МЕТОДЫ//

///Генерация массива
int[,] GenerateArray()
{
    //Random rnd = new Random() ;
    int[,] array = new int[Randomize (2,50), Randomize (2,27)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Randomize (-999, 1000);
        }
    }

    return array;
}


///Вывод
void Outcome(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]");
        }
        Console.WriteLine();
    }

}


//Рандомайзер
int Randomize(int min, int max)
{
    return new Random().Next(min, max);
}

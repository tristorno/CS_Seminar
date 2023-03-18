////////////////////////////////////////////////////////
//Сгенерировать трехмерный массив 2х2х2.////////////////
//Вывести на экран построчно все элементы с индексами.//
////////////////////////////////////////////////////////

Outcome(GenerateArr());


////////////////////
///////МЕТОДЫ///////


///Рандомайзер
int Randomize (int min, int max)
{
    return new Random().Next(min, max);
}

///Вывод массива
void Outcome (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"|{array[i,j,k]} ({i},{j},{k})|\t");
            }
            Console.WriteLine();
        }
    }

}


///Генератор массива
int[,,] GenerateArr ()
{
    int[,,] array = new int [2,2,2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = Randomize (-99, 1000);
            }
        }
    }

    return array;
}
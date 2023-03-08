/////////////////////////////////////////////////
//Создать двумерный массив (m,n)/////////////////
//Заполнить массив значениями равными сумме m+n// 
/////////////////////////////////////////////////


int[,] array = GenerateArray();
Outcome(array);


//МЕТОДЫ//
/********/

//Генерация и заполнение массива
int [,] GenerateArray ()
{
    int[,] array = new int[Randomize(2,20), Randomize (3,20)];
    for (int i = 0; i < array .GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            array[i,j] = i+j;
        }
    }

    return array;
}


//Вывод массива
void Outcome (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
              Console.Write($"[{array[i,j]}]\t");
        }
        Console.WriteLine();
    }
}



//Рандомайзер
int Randomize (int min, int max)
{
    return new Random().Next(min , max);
}

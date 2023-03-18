//////////////////////////////////////////////////
//Заменить столбцы на строки в двумерном массиве//
//или написать, что это невозможно////////////////
//////////////////////////////////////////////////


int[,] arr = GenerateArray();
OutcomeArray(arr);
bool flag = IfRowsEqualColumns(arr);//флаг, нужно ли запускать второй раз вывод массива
if (flag==true) 
{
    int[,] arrayMod = ColumnRowExchange(arr);
    OutcomeArray(arrayMod);
}
else
{
    OutcomeMsg();
}


//////////////////
///// МЕТОДЫ /////


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
    Console.WriteLine();
    Console.WriteLine("-------------------------------------");
    Console.WriteLine();
}

///Рандомайзер
int Randomize(int min, int max)
{
    return new Random().Next(min,max);
}

///Генерация массива
int[,] GenerateArray ()
{
    int[,] array = new int[Randomize(5,8), Randomize(5,8)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Randomize(-99, 1000);
        }
    }

    return array;
}

///Замена строк на столбцы
int[,] ColumnRowExchange (int [,] array)
{
    int[,] arrayMod = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arrayMod[i,j] = array [j,i];
            }
        }
        return arrayMod;
}        
    

///Проверка на совпадение кол-ва строк и столбцов
bool IfRowsEqualColumns (int[,] arrow)
{
    bool equality = (arrow.GetLength(0)==arrow.GetLength(1))?
    true : false;
    return equality;
}

///Вывод сообщения
void OutcomeMsg()
{
    Console.WriteLine("Замена столбцов на строки не возможна.");
    Console.WriteLine("Количество строк не совпадает.");
}
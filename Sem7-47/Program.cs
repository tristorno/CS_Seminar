/////////////////////////////////////////////////////////////////////////////////
//Создать двумерный массив случайных вещественных чисел (округление до десятых)//
//Вывксти массив, раскрасив его в 16 цветов//////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////

double[,] array = GenerateArray();
Output(array);


////////////////////
///МЕТОДЫ///////////

///Генерация массива
double[,] GenerateArray()
{
    double[,] array = new double
    [Convert.ToInt32(Randomize(2, 20)), Convert.ToInt32(Randomize(3, 10))];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(Randomize(-9, 99), 1);
        }
    }
    return array;
}


///Раскраска
ConsoleColor Color()
{
    var color = new Dictionary <int, ConsoleColor>()
    {
        {1, ConsoleColor.Black},
        {2, ConsoleColor.Blue},
        {3, ConsoleColor.Cyan},
        {4, ConsoleColor.DarkBlue },
        {5,  ConsoleColor.DarkCyan },
        {6,  ConsoleColor.DarkGray },
        {7,  ConsoleColor.DarkGreen },
        {8,  ConsoleColor.DarkMagenta },
        {9,  ConsoleColor.DarkRed },
        {10,  ConsoleColor.DarkYellow },
        {11,  ConsoleColor.Gray },
        {12,  ConsoleColor.Green },
        {13,  ConsoleColor.Magenta },
        {14,  ConsoleColor.Red },
        {15,  ConsoleColor.White },
        {16,  ConsoleColor.Yellow }
    };

    return color[Convert.ToInt32(Randomize(1, 16))];

}


///Вывод массива
void Output(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = Color();
            Console.Write($"|{array[i, j]}|\t");
        }
        Console.ResetColor();
        Console.WriteLine();
    }

}



///Рандомайзер
double Randomize(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max) + rnd.NextDouble();
}
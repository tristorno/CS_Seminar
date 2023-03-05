////////////////////////////////////////
// Создавть поэлементную копию массива//
////////////////////////////////////////


//Генерация массива
int[] GenArray()
{
    Random rnd = new Random();
    int[] array = new int[rnd.Next(5, 10000)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-999, 1000);
    }
    return array;
}


//Вывод результата
void Outcome(string msgEnd, int[] array)
{
    Console.WriteLine(msgEnd);
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"[{array[i]}],");
    }
    Console.WriteLine($"[{array [array.Length-1]}].");
}


//Создание копии массива
int[] CopyArray(int[] array)
{
    int[] lastArray = new int[array.Length];
    for (int i = 0; i < lastArray.Length; i++)
    {
        lastArray[i] = array[i];
    }
    return lastArray;
}



//Код программы
int[] originArray = GenArray();
Outcome("Исходный массив: ", originArray);
int[] lastArray = CopyArray(originArray);
Outcome("Скопированный массив: ", lastArray);
/////////////////////////////////////////////////////////////
//Перевернуть массив
/////////////////////////////////////////////////////////////

//Генерация массива
int[] GenArray () 
{
    Random rnd = new Random();
    int[] array = new int[rnd.Next(5, 1000)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9999, 10000);
    }
    return array;
}

//Вывод на экран
void Outcome(string msgEnd, int[] array)
{
    Console.WriteLine (msgEnd);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}]");
    }
    Console.WriteLine();
}

//Перевертывание массива
int[] Transarray (int[] array)
{
    for (int i = 0; i < ((array.Length-1)/ 2); i++)
    {
        int buf = array[array.Length-1-i];
        array[array.Length-1-i] = array[i];
        array[i] = buf;
    }
    return array;
}


int[] array = GenArray();
Outcome("Исходный массив", array);
Transarray(array);
Outcome("Перевернутый массив", array);
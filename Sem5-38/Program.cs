// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Отсортируйте массив методом вставки

double[] GenArray()
{
    Random rnd = new Random();
    double[] array = new double [rnd.Next(5,10000)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = /*Convert.ToDouble (rnd.Next(-999;1000)) +*/ rnd.NextDouble();
    }
    return array;
}    

void Outcome (double[] array, double result)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write ($"[{array[i]}]");
    }
    Console.WriteLine ();
    Console.WriteLine ("Разница максимального и минимального чисел равна: "+result);
}

double CountDif (double[] array)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
       max = (array[i]>max)? array[i]:max;
       min = (array[i]<min)? array[i]:min;
    }
    return max-min;
}

double[] array = GenArray ();
double result = CountDif(array);
Outcome (array, result);

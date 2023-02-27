// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Ввести с клавиатуры длину массива и диапазон значений элементов.

int Income (string msg)
{
	Console.WriteLine (msg);
	return int.Parse(Console.ReadLine()??"0");
}

int[] Body (int arrayLength, int minValue, int maxValue)
{
	int[] array = new int [arrayLength];
	for (int i=0; i<arrayLength; i++)
	{
		array[i] = new Random().Next(minValue, maxValue+1);
	}
		return array;	
}


void Outcome (int[] array)
{
	string result = String.Empty;
	for (int i=0; i<array.Length; i++)
	{
		result = result + ", "+(System.Convert.ToString(array[i]));
	}
	Console.WriteLine (result);
}





int arrayLength = Income ("Задайте длинну массива: ");
int minValue = Income ("Задайте минимальное значение массива: ");
int maxValue = Income ("Задайте максимальное значение массива: ");
int[] array = Body (arrayLength, minValue, maxValue);
Outcome (array);

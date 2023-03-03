//Сгенерить массив случайных трехзначных положительных чисел.
//Вывести количество четных чисел
//Отсортировать методом пузырька
//Отсортировать методом подсчета
//Сравнить методы сортировки

using System.Globalization;

//Генерация массива
int[] GenArray ()
{
	Random rnd = new Random();
	int[] array = new int[rnd.Next(5,10001)];
	for (int i=0; i<array.Length; i++)
	{
		array[i]=rnd.Next(100,1000);
	}
	Console.WriteLine(array.Length);
	return array;
}

//Подсчет количества четных чисел в массиве
void CountEvenNums(int[] array)
{
	int num = 0;
	for (int i=0; i<array.Length; i++)
	{
		if (array[i]%2==0)
		{
			num++;
		}
	
	}

	Console.WriteLine("Количество четных чисел в массиве = "+num);
}


//Сортировка методом пузырька
int[] BubbleSort (int[] array)
{
	int temp = 0;
	//int[] arrBubble = new int[array.Length];
	for (int i=0; i<array.Length; i++)
	{
		for (int j=0; j<array.Length-1-i; j++)
		{
			if (array[j] > array[j+1])
			{
				temp = array[j+1];
				array[j+1] = array[j];
				array[j] = temp;		
			}
		}
	
	}
	return array;
}



//Вывод массива
void Outcome (int[] array)
{
	for (int i=0; i<array.Length; i++)
	{
		Console.Write ($"[{array[i]}]");
	}
	Console.WriteLine();
}


//Сортировка методом подсчета - не сделал
/*int[] CountSort (int[] array)
{
	int[] tempArray = new int[array.Length];
	for (int i=0; i<array.Length; i++)
	{
		tempArray[i]=
	}

	return array
}

*/


int[] array = GenArray();
Outcome(array);
CountEvenNums(array);
DateTime d1 = DateTime.Now;
int[] arrBubble = BubbleSort (array);
Console.Write("Время выполнения сортировки равно: ");
Console.WriteLine(DateTime.Now-d1);
Outcome (arrBubble);

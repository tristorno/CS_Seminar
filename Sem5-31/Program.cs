//Задать массив из 12 элементов, заполненный случайными числами от -9 до +9. Вывести сумму отрицательных и положительных чисел в массиве.

int[] ArrayFill ()
{
	int[] array = new int [12];
	for (int i=0; i<array.Length; i++)
	{
		array[i] = new Random().Next(-9, 10);
	}
	return array;
}

void CountSum (int[] array)
{
	int resPos = 0;
	int resNeg = 0;
	for (int i=0; i<array.Length; i++)
	{
		if (array[i]>=0)
		{
			resPos += array[i];	
		}
		else
		{	
			resNeg += array[i];
		}	
	}
	Console.WriteLine ("Сумма отрицательных чисел в массиве равна "+resNeg); 
	Console.WriteLine ("Сумма положительных чисел в массиве равна "+resPos);
}




int[] array = ArrayFill();
CountSum (array);

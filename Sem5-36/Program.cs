//Сгенерить массив
//Найти сумму элементов на нечетных позициях.
//Вывести все пары (задание не понял).


int[] GenArray ()
{
	Random rnd = new Random();
	int[] array = new int [rnd.Next (5, 100000)];
	for (int i=0; i<array.Length; i++) 
	{
		array[i] = rnd.Next (-9999, 10000);
	}

	return array;
}

void SumCount (int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i=i+2)
	{
		sum += array[i];
	}
	/*for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine (array[i]);
	}
	*/
	Console.WriteLine(sum);
	
}

int[] array = GenArray ();
SumCount (array);
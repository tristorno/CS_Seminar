//Задать массив из 123 случайных чисел с длинной массива 123. Вывести сам массив и кол-во чисел между 10 и 99.

int [] GenArray()
{
	int [] array = new int [123];
	Random rnd = new Random();
	for(int i=0; i<123; i++)
	{
		array[i] = rnd.Next(1,124);
	}
	return array;
}

int Count (int[] array)
{
	int res=0;
	for (int i=0; i<array.Length;i++)
	{
		if (array[i]>10 && array[i]<99)
		{
			res++;
		}
	
	}
		//Console.WriteLine (res);
	return res;
}



void Outcome (int res, int[] array)
{
	for (int i=0; i<array.Length; i++)
	{
		Console.Write ($"[{array[i]}]");
	}
	Console.WriteLine("-->"+res);

}




int[] array = GenArray();
int result = Count(array);
Outcome(result, array);

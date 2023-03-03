//Найти произведение пары чисел в одномерном массиве (1 и последний, второй и предпоследний и т.д.). Результат записать в другой массив.

int[] GenArray ()
{
	Random rnd = new Random();
	int[] array = new int [rnd.Next(2,100000)];
	for (int i=0; i<array.Length; i++)
	{
		array[i]=rnd.Next(-99999,100000);
	}
	//Console.WriteLine(array.Length);
	return array;
}

void Outcome (int[] arrayRes)
{
	for(int i=0; i<arrayRes.Length; i++)
	{
		Console.Write ($"|{arrayRes[i]}|");
	} 
	Console.WriteLine();
}


int[] CreateArrayRes (int[] array)
{
	int length = (array.Length%2==0)? array.Length/2 : array.Length/2+1;
	int[] arrayRes = new int[length];
	for(int i=0; i<length; i++)
	{
		arrayRes[i]=array[i]*array[array.Length-1-i];
		//arrayRes[i]=array[i]*3;
	}
	if(length%2==1)
	{
		arrayRes[length]=array[length]; //если длинна массива нечетная, то средний элемент переносится без умножения
	}
	
	//Console.WriteLine(length);

	return arrayRes;
}





int[] array = GenArray();
int[] arrayRes = CreateArrayRes(array);
Outcome(array);
Outcome(arrayRes);

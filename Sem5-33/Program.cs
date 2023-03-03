//Задать массив и проверить входит ли в него введенное число 

int[] GenArray ()
{	
	Random rnd = new Random();
	int[] array = new int [rnd.Next(2,1000)];
	for (int i=0; i<array.Length; i++)
	{
		array[i] = rnd.Next(-999,1000);
	}
	return array;
}

void FindNumber (int number, int[] array)
{
	int find = 0;
	for (int i=0; i<array.Length; i++)
	{
		if (array[i]==number)
		{
			find += 1;
		}	

	}
	Console.WriteLine($"Число {number} найдено в массиве {find} раз");	
}


int Income (string msg)
{
	Console.WriteLine(msg);
	return int.Parse(Console.ReadLine()??"0");
}

int[] array = GenArray();
int number = Income("Введите число: ");
FindNumber(number, array);

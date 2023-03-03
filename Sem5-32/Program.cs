// Меняет все положительные числа в массиве на отрицательные и наоборот

//Recieve values from user
int Income (string msg)
{
 	Console.WriteLine(msg);
	return int.Parse (Console.ReadLine()??"0"); //convert string into integer
}

//Print the result
void Outcome (int[] array)
{
	for (int i=0; i<array.Length; i++) 
	{
		Console.Write($"[{array[i]}] "); //print array's elements as a row	
	}
	Console.WriteLine();

}

//Create the array and fill it in with values
int[] CreateArray (int arrLength, int arrBegin, int arrEnd)
{
	int[] array = new int[arrLength];
	for(int i=0; i<arrLength; i++)
	{
		array[i] = new Random().Next(arrBegin, arrEnd+1); //fill in with random values
	}
	return array;
}

//Reverse signes of digits
int[] ReverseSign (int[] array)
{
	for (int i=0; i<array.Length; i++)
	{
		array[i]=i*(-1); //reverse the sign
	}
	return array;
}





int arrLength = Income ("Введите длинну массива: ");
int arrBegin = Income ("Введите минимальное значение диапазона значений  массива: ");
int arrEnd = Income ("Введите максимальное значение диапазона значений массива: ");
int[] array = CreateArray (arrLength, arrBegin, arrEnd);
Outcome (array);
int[] arrayRev = ReverseSign (array);
Outcome (arrayRev);

// Программы генерирует и выводит массив из 8 элементов, заполненных 0 и 1 в случайном порядке.

int[] array = new int[8];
for (int i=0; i<8; i++)
{
	array [i] = new Random().Next(0,2);
	Console.WriteLine(array[i]);
}	


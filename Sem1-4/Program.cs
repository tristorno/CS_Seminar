// Принимается на вход 3 числа и выводится наибольшее из них

int [] numbers = new int [3];
Console.WriteLine("Введите первое число:");
numbers[0] = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число:");
numbers[1] = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите третье число:");
numbers[2] = Convert.ToInt32 (Console.ReadLine());
int max_num = numbers[0];
int count = 0;
while (count < 2)
{
	if (numbers[count] > max_num)
	{
		max_num = numbers[count];
	}	
	count++;
}
Console.WriteLine("Максимальное число - " + max_num);

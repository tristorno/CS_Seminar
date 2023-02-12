// Получвет на вход число N, на выходе дает все целые числа от -N до N

Console.WriteLine("Введите число:");
int endNum = Convert.ToInt32 (Console.ReadLine ());
int mediaNum = endNum - 0;
int beginNum = endNum - mediaNum * 2;
int count = beginNum;
//Решение преподавателя.
//string res = String.Empty
//while (count <= endnum)
//{
//res = res + count + " ";
//count ++;
//}


while (count <= endNum)
{
	Console.WriteLine (count);
	count ++;
}

//Принимаем координаты x и y, возвращаем номер чертверти, где находится эта точка.
int ReadData(string msg)
{
	Console.WriteLine(msg);
	return int.Parse(Console.ReadLine()??"0");
}

void Quater(int x, int y)
{
	if (x>0&&y>0) Console.WriteLine("Точка в 1 четверти");
	if (x>0&&y<0) Console.WriteLine("Точка в 2 четверти");
	if (x<0&&y<0) Console.WriteLine("Точка в 3 четверти");
	if (x<0&&y>0) Console.WriteLine("Точка в 4 четверти");
}


int x = ReadData("Введите x: ");
int y = ReadData("Введите y: ");
Quater(x,y);

//Console.WriteLine("Получен "+x+" "+y);

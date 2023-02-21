// Принимает координаты двух точек в трехмерном пространстве. На выход дать расстояние между ними.

int Income (string msg)
{
	Console.WriteLine (msg);
	return int.Parse (Console.ReadLine() ?? "0");
}


void Outcome (double length)
{
	Console.WriteLine("Расстояние между точками равно "+length);
}


double LengthCount (int x1, int y1, int z1, int x2, int y2, int z2)
{
	return Math.Sqrt (Math.Pow ((x1-x2),2) + Math.Pow ((y1-y2),2) + Math.Pow ((z1-z2),2));
}


int xA = Income ("Введите абсциссу первой точки: ");
int yA = Income ("Введите ординату первой точки: ");
int zA = Income ("Введите аппликату первой точки: ");
int xB = Income ("Введите абсциссу второй точки: ");
int yB = Income ("Введите ординату второй точки: ");
int zB = Income ("Введите аппликату второй точки: ");
double length = LengthCount (xA, yA, zA, xB, yB, zB);
Outcome (length);

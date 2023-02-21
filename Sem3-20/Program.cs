// Принимает координаты двух точек в двумерном простанстве и возвращает длинну отрезка.
int Coordinate (string msg)
{
	Console.WriteLine (msg);
	return int.Parse (Console.ReadLine() ?? "0");
}

void CountOfLength (int x1, int y1, int x2, int y2) 
{
	int xMin = (x1 <= x2)? x1 : x2;
	int xMax = (x1 > x2)? x1 : x2;
	int yMin = (y1 <= x2)? y1 : y2;
	int yMax = (y1 > y2)? y1 : y2;
	Console.WriteLine(Math.Sqrt((xMax-xMin)*(xMax-xMin)+(yMax-yMin)*(yMax-yMin)));

}

int xA = Coordinate ("Введи абсциссу точки A: ");
int yA = Coordinate ("Введи ординату точки A: ");
int xB = Coordinate ("Введи абсциссу точки B: ");
int yB = Coordinate ("Введи ординату точки B: ");
CountOfLength (xA, yA, xB, yB);
//Console.WriteLine(xMax);

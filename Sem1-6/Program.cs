//Программа принимает на вход число и проверяет его на четность. На выход отдает "да" или "нет"
Console.WriteLine("Введите число для проверки его четности:");
int num = Convert.ToInt32 (Console.ReadLine ());
if (num % 2 == 0) 
{
	Console.WriteLine ("да");
}	
else
{
	Console.WriteLine ("нет");
}

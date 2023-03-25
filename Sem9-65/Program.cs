//////////////////////////////////////////////////////////////
//Вывести все натуральные числа от M до N с помощью рекурсии//
//////////////////////////////////////////////////////////////
int M = Input ("Введите число M: ");
int N = Input ("Введите число N: ");
GenerateString (M,N);

////////////////////
///////МЕТОДЫ///////


///Генерация рекурсией и вывод
void GenerateString (int M, int N)
{
    Console.Write(M+" ");
    if (M==N){}
    else
    {
        if (M<=N)
        {
            GenerateString (M+1, N);
        }
        else
        {
            GenerateString (M-1, N);
        }
    }
}


///Ввод
int Input (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
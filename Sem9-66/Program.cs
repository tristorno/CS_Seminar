//////////////////////////////////////
//Вывести сумму элементов от M до N.//
//Решение сделать через рекурсию//////
//////////////////////////////////////

int M = Income ("Введите первое число: ");
int N = Income ("Введите второе число: ");
if (M<N)    {
    Console.WriteLine(CountSum(M,N));
}
else    {
    Console.WriteLine(CountSum(N,M));
}

////////////////////
///////МЕТОДЫ///////


///Пользовательский ввод
int Income (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}


///Решение через рекурсию
int CountSum (int M, int N)
{
    if (M>=N) {
        return N;
    }
    else    {
        return (M+CountSum(M+1, N));
    }
}
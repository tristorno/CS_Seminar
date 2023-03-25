///////////////////////////////////////////
//Вывести все натуральные числа от 1 до N./
//Решение должно быть с помощью рекурсии///
///////////////////////////////////////////

int N = Income("Введите число: ");
//int[] resArr = FillArrIn(N);
Outcome(1, N);

////////////////////
///////МЕТОДЫ///////


///Ввод
int Income (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}


///Вывод
void Outcome (int res, int N)
{
    Console.Write (res+" ");
    if (res==N)
    {}
    else    
        if (res<N)  {
            Outcome(res+1, N);
        }
        else  {
            Outcome(res-1,N);    
        }
}
///////////////////////////////////////////////////////////////////////////////////
//Вывести первые N строк треугольника Паскаля в виде равнобедренного треугольника//
///////////////////////////////////////////////////////////////////////////////////

int nRows = Income("Введите число: ");
Outcome (nRows);
//Console.WriteLine(Factorial(5));


//////////////////
///// МЕТОДЫ /////


//Вывод на экран
void Outcome (int nRow)
{
    for (int i = 0; i <nRow; i++)
    {
       for (int k = 0; k < nRow-i; k++)
       {
        Console.Write(" ");
       }
       
       for (int j = 0; j <= i; j++)
       {
       Console.Write(" ");
       Console.Write(Factorial(i)/(Factorial(j)*Factorial(i-j)));
       }
       Console.WriteLine (); 
    }
       

}


//Подсчет. Любое число находится по биномальному коэффициенту
// n!/(k!*(n-k))!, где n - номер строки, k - номер позиции с краю строки начиная с нуля.

//Вычисление факториала числа
long Factorial (int number)
{
    long factorial = 1;
    for (int i = 1; i<=number; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}


//Ввод
int Income (string msg)
{
    Console.WriteLine (msg);
    return int.Parse(Console.ReadLine()??"0");
}

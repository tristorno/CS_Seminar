/////////////////////////////////////////////////
//Вывести первые N чисел Фибоначчи без рекурсии//
/////////////////////////////////////////////////

using System.Numerics;

//Ввод//
int Income (string msg)
{
    Console.WriteLine (msg);
    return int.Parse(Console.ReadLine()??"0");
}


//Вывод//
void Outcome (string msgEnd, BigInteger[] array)
{
    Console.Write (msgEnd+"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i]+", ");
    }
    Console.WriteLine("]");
}


//Вычисления чисел Фибоначчи//
BigInteger[] Fibonacci (int number)
{
    BigInteger[] array = new BigInteger [number];
    array[0]=0;
    array [1]= 1;
    for (int i = 2; i<number; i++)
    {
        array[i]=array[i-1]+array[i-2];
    }
     
    return array;
}



//Код прогораммы//
int number = Income ("Введите число: ");
BigInteger[] array = Fibonacci(number);
Outcome ($"Числа Фибоначчи до {number}:", array);
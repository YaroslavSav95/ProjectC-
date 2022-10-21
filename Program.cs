// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число ");
int N=int.Parse(Console.ReadLine());
int i=N;
Num();
Reverse(N);
void Num()
{
    Reverse(N);
}
void Reverse(int N)
{
    int NewN=i-1;
    Console.WriteLine(NewN);
    i--;
    if(i>2)
    Reverse(N);
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число М ");
int M=int.Parse(Console.ReadLine());
Console.Write("Введите число N ");
int N=int.Parse(Console.ReadLine());
int result=0;
Reverse(N,M,result);
void Reverse(int N,int M,int result)
{
    if(M>N)
    {
        Console.WriteLine(result);
        return;
    }
    result=result+(M++);
    Reverse(N,M,result);
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m=");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите число n=");
int n=int.Parse(Console.ReadLine());
FunAk(m,n);
Result();
void Result()
{
    FunAk(m,n);
}
int FunAk(int m,int n)
{
    if(m==0)
    return n+1;
    if(m!=0 && n==0)
    return FunAk(m-1,1);
    if(m>0 && n>0)
    return FunAk(m-1,FunAk(m,n-1));
    return FunAk(m,n);
}
Console.WriteLine(FunAk(m,n));
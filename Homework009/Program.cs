/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void ShowNums(int num)
{
    Console.Write( num +" ");
    if (num > 1) ShowNums (num - 1);
    else Console.Write("xxx");
}

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int SumNumber (int num1, int num2)
{
    if (num2 > num1)
    {
        return SumNumber(num1 + 1, num2) + num1;
    }
    else if (num1 > num2) 
    {
        return SumNumber(num1-1,num2) + num1;
    }
    else 
    {
        return num1;
    }
}



Console.Write("input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumber(num1, num2));
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Ackermann(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
        else if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
        return 0; 
    }
    
Console.Write("input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ackermann(num1, num2));
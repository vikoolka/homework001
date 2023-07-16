//Урок 3. Базовые алгоритмы. Продолжение
/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

bool Palindrome(int number)
    {
        string numberString = number.ToString();

        for (int i = 0; i < numberString.Length / 2; i++)
        {
            if (numberString[i] != numberString[numberString.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (Palindrome(number))
        {
            Console.WriteLine("Да, число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом.");
        }


/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
/*
double Lenght(int x1, int y1, int z1, int x2, int y2, int z2)
{   
    double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return result;
}
Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round((Lenght(x1, y1, z1, x2, y2, z2)), 2));

*/
/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
4
1 - 1
2 - 8
3 - 27
4 - 64*/

/*
void Cube(int number)
{
    int count = 0;
    while (count <= number)
    {
        Console.WriteLine($"{count} - {count*count*count}");
        count++;
    }
}

Console.Write("Input number: ");
int result = Convert.ToInt32(Console.ReadLine());
Cube(result);
*/
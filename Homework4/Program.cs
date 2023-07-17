//Урок 4. Функции
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*
int Gen(int number1, int number2)
{
    {
        int count = 1;
        int result = number1;
        while (number2 > count)
        {
            result = result*number1;
            count++;
        }
        return result;
    }
}

Console.Write("Input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = Gen(number1, number2);
Console.WriteLine($"Число {number1} в натуральной степени {number2} равно {result}");
*/
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
/*
int Sum(int unit)
{
    int sum = 0;
    while (unit > 0)
    {
        int digit = unit % 10;
        sum += digit;
        unit /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Sum(number);
Console.WriteLine($"Сумма цифр числа {number} равно {result}");

*/

/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Разработать метод CreateArray(int size), 
генерирующий массив на основе данных, вводимых пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] CreateArray(int size)
    {
        int[] array = new int[size];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите длину массива ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(lenght);
ShowArray(myArray);
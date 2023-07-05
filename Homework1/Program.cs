/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
/*Console.Write("Input first number ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine(number1);
}
else if(number2 > number1)
{
    Console.WriteLine(number2);
}*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*Console.Write("Input first number ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine(number1);
}
else if(number2 > number1 && number2 > number3)
{
    Console.WriteLine(number2);
}
else if(number3 > number1 && number3 > number2)
{
    Console.WriteLine(number3);
}
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

/*Console.Write("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is not even.");
        }*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= N)
{
    Console.Write(current + " ");
    current = current + 2;
}
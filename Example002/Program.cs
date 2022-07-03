// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine()!);

//Console.WriteLine((int)Math.Log10(num) + 1);

// Задано число N, найти произведение числел от 1 до N

int factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *=i;
    }
    return result;
}
System.Console.WriteLine(factorial(num));
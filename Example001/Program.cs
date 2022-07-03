// 7 - сумма всех чисел

int GetSumm(int a)
{
    int sum = 0;

    for (int i = 1; i <= a; i++)
    {
        sum +=i;
    }
    return sum; 
}
System.Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(GetSumm(num));


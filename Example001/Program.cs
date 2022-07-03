// 7 - сумма всех чисел

int GetSumm(int a)
{
    int sum = 0;

    for (int i = 1; i <= a; i++) // return a*(a+1)/2 - арифмитическая прогрессия
    {
        sum +=i;
    }
    return sum; 
}
System.Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSumm(num));
Console.WriteLine(GetSummFast(num));

int GetSummFast(int a)
{
    return a * (a + 1) / 2;
}
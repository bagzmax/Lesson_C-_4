// адача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

//void PrintRandomArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//         System.Console.WriteLine(array[i]);
//     }
   
// }

// System.Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// PrintRandomArray(num);


Console.WriteLine("\nВывод массива:"); 
        for (int i = 0; i < array.Length; i++) 
        {
            Console.Write(array[i] + " ");  
        }

nt[] array = new int[8];
int length = array.Length;

for (int i = 0; i < length; i++)
{
    array [i] = new Random().Next(0, 2);
}

foreach (var item in array)
{
    Console.Write(item + " ");
}

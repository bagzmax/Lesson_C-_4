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


//Console.WriteLine("\nВывод массива:"); 
// for (int i = 0; i < array.Length; i++) 
// {
//     Console.Write(array[i] + " ");  
// }

//int[] array = new int[8];
//int length = array.Length;

int[] GetArrayRandom(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}

void FillArrayRandom(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(2);
    }
}

void PrintArray(int[] massiv)
{
    foreach (var item in massiv) // для каждой переменной (var) item в массиве что-то сделать
    {
        Console.Write(item + " ");
    }
}

int[] array = new int[8];
FillArrayRandom(array);
PrintArray(array);

int[] array2 = GetArrayRandom(8);
System.Console.WriteLine();
PrintArray(array2);
using System;

class Program
{
    static void Main()
    {

        Console.Write("Введіть розмір масиву: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        Random rand = new Random();

        int i = 0;
        while (i < size)
        {
            array[i] = rand.Next(-10, 21);
            i++;
        }

        Console.WriteLine("Вихідний масив:");
        PrintArray(array);

        int minIndex = 0, maxIndex = 0;
        i = 1;
        while (i < size)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
            i++;
        }

        int temp = array[minIndex];
        array[minIndex] = array[maxIndex];
        array[maxIndex] = temp;

        Console.WriteLine("Масив після обміну мінімального та максимального елементів:");
        PrintArray(array);
    }

    private static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}        
     

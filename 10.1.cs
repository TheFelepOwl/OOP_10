using System;

public class Program
{
    public static void Main()
    {

        Console.Write("Размер массива: ");

        int sum=0, size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }

        Console.WriteLine("\nМассив случайных чисел:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n\nСмумма первых 3 и последних 6 элементов:");
        for(int i = 0; i < array.Length; i++)
        {
            if(i<3||i>=array.Length-6)
                sum=sum+array[i];

        }

        Console.WriteLine(sum);
        
    }
}








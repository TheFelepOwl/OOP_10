using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Size: ");

        int size=int.Parse(Console.ReadLine());


        int count=0;

        int [] array= new int[size];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-50, 50);
        }

        Console.WriteLine("Array:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > 1)
                count++;
        }

        Console.WriteLine("\nThe number of elements is greater than 1: "+ count);
    }
}
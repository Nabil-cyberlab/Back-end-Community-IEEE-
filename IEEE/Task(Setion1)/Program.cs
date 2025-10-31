using System;

class Program
{
    static void Main()
    {

        // Task1
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine("Sum = " + sum);
        // Task2
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        int largest = numbers[0];
        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > largest)
                largest = numbers[i];
        }
        Console.WriteLine("The largest number is: " + largest);
        //Task 3
        string[] names = new string[3];
        double[] grades = new double[3];
        double total = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter name of student " + (i + 1) + ": ");
            names[i] = Console.ReadLine();

            Console.Write("Enter grade of " + names[i] + ": ");
            grades[i] = Convert.ToDouble(Console.ReadLine());

            total += grades[i];
        }
        double average = total / 3;
        Console.WriteLine("Average grade = " + average);

        Console.WriteLine("Students above average:");
        for (int i = 0; i < 3; i++)
        {
            if (grades[i] > average)
                Console.WriteLine(names[i]);
        }
    }
}

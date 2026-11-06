namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 10, 20, 30, 40 };
        int sum = 0;

        Console.Write("All elements: ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
            sum = sum + array[i];
        }

        Console.WriteLine();
        Console.WriteLine("Sum: " + sum);

        double average = (double)sum / array.Length;
        Console.WriteLine("Average: " + average);
    }
}
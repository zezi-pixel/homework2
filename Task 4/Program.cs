namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers you want to enter:");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 10)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many words you want to enter:");
        int arraySize = int.Parse(Console.ReadLine());

        string[] array = new string[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = Console.ReadLine();
        }
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length > 4)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
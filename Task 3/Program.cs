namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 10, 15, 20 };
        array[1] = 100;
        
        Console.WriteLine("After changing index 1 to 100:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] * 2;
        }
        Console.WriteLine("After multiplying every element by 2:");
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
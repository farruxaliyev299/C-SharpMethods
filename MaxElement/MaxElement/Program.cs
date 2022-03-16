class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Max(5,6,9,15,7));
    }


    static int Max(params int[] array)
    {
        int max=array[0];
        for (int i= 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}


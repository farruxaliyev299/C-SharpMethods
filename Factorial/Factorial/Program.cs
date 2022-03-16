class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Factorial(5));
    }

    static int Factorial(int number)
    {
        int result = number;
        for (int i = number - 1; i > 0; i--)
        {
            result = result * i;
        }
        return result;
    }
}
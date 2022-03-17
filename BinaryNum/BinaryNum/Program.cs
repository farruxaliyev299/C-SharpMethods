class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Binary(15));
    }

    static int Binary(int num)
    {
        int count = 0;

        while (num >= 1)
        {
            if (num % 2 == 1)
            {
                count++;
            }
            num /= 2;                        
        }
        return count;
    }
}

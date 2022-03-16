class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Binary(30));
    }

    static int Binary(int num)
    {
        int count = 0;

        while (num >= 1)
        {
            num /= 2;
            count++;
        }
        return count;
    }
}

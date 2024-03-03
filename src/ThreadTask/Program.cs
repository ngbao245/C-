class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 11; i++)
        {
            var x = i;
            Thread a = new Thread(() =>
            {
                Console.WriteLine(i);
            });
            a.Start();
            Thread.Sleep(3);
        }
        Console.WriteLine();
    }
}



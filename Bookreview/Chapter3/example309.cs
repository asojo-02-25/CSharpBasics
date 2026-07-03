namespace Bookreview;

class Example309
{
    public static void Run()
    {
        List<int> list = new List<int>();
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            list.Add(rnd.Next(1, 100));
        }

        Console.WriteLine(string.Join(" ", list));

        for (int i = 0; i < 100; i += 10)
        {
            Console.Write($"{i}以上{i+10}未満 : ");

            foreach (int num in list)
            {
                if (i <= num && num < i + 10)
                {
                    
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
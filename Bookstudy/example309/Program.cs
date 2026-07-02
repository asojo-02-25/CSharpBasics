namespace example309;

class Program
{
    static void Main(string[] args)
    {
        Random rdm = new Random();
        List<int> numbers = new List<int>();
        
        for (int i  = 0; i < 10; i++)
        {
            numbers.Add(rdm.Next(1, 100));
        }

        Console.WriteLine(string.Join(" ", numbers));

        for (int i = 0; i < 100; i += 10)
        {
            Console.Write($"{i}以上{i + 10}未満 : ");
            foreach (int n in numbers)
            {
                if (i <= n && n < i + 10)
                {
                    Console.Write(n + " ");
                }
            }
        }
    }
}
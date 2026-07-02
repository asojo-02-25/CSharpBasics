namespace example308;

class Program
{
    static void Main(string[] args)
    {
        Random rdm = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rdm.Next(1, 101);
        }
        Console.WriteLine(string.Join(" ", numbers));

        int[] result = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            int max = 0;
            int pos = 0;
   
            for (int j = 0; j < numbers.Length; j++)
            {
                if (max < numbers[j])
                {
                    max = numbers[j];
                    pos = j;
                }
            }
            result[i] = max;
            numbers[pos] = 0;
        }
        Console.WriteLine(string.Join(" ", result));
    }
}
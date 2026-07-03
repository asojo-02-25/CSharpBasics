namespace Bookreview;

class Example308
{
    public static void Run()
    {
        Random rnd = new Random();
        List<int> list = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            list.Add(rnd.Next(1, 101));
        }

        Console.WriteLine(string.Join(" ", list));

        List<int> orderd = new List<int>();
        int max = 0;
        int idx = 0;

        for (int i = 0; i <  list.Count; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] > max)
                {
                    max = list[j];
                    idx = j;
                }
            }
            orderd.Add(max);
            list[idx] = 0;
            max = 0;
            idx = 0;
        }
        Console.WriteLine(string.Join(" ", orderd));
    }
}
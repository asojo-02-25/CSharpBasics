namespace question408;

class Bingo
{
    private int[,] data;
    private int size;

    public Bingo() : this(5)
    {

    }

    public Bingo(int size)
    {
        Init(size);
        
    }

    public void Shuffle()
    {
        Random rnd = new Random();
        int num = 1;

        while (num <= size * size)
        {
            int m = rnd.Next(size);
            int n = rnd.Next(size);

            if (data[m, n] == 0)
            {
                data[m, n] = num;
                num++;
            }
        }
    }

    public void Init(int size)
    {
        this.size = size;
        data = new int[size, size];
        Shuffle();
    }

    public void Show()
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                Console.Write($"{data[i, j],2:d}|");
            }
            Console.WriteLine();
        }
        for (int j = 0; j < data.GetLength(1); j++)
        {
            Console.Write("----");
        }
        Console.WriteLine();
    }

}
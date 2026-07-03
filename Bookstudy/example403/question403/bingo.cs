using System.Drawing;

namespace question403;

class Bingo
{
    public int[,] data;
    public void Init(int size)
    {
        data = new int[size, size];
       
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
    public void Show()
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0;  j < data.GetLength(1); j++)
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
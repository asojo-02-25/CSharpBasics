namespace question403;

class Program
{
    static void Main()
    {
        Bingo bingo = new Bingo();

        Console.Write("ビンゴの縦、横のサイズを入力");
        int size = int.Parse(Console.ReadLine()!);

        bingo.Init(size);
        bingo.Show();
    }
}
namespace question408;

class Program
{
    static void Main()
    {
        Console.Write("ビンゴの縦、横のサイズを入力");
        int size = int.Parse(Console.ReadLine());
        Bingo bingo = new Bingo(size);
        bingo.Show();
    }
}
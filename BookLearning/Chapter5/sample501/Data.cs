namespace BookLearning;

class Data
{
    private static int num = 0;
    private int id;

    public Data(int id)
    {
        this.id = id;
        num++;
        Console.WriteLine($"値 : {this.id} 数 : {num}");
    }

    public static void ShowNumber()
    {
        Console.WriteLine($"Dataオブジェクトの数 : {num}");
    }
}
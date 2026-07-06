namespace BookLearning.Chapter5;

class Sample502
{
    private static int snum = 0;
    public int inum = 0;

    public static void Foo()
    {
        Console.WriteLine("Fooメソッド(staticなメソッド)");
    }

    public void Bar()
    {
        Console.WriteLine("Barメソッド(publicなメソッド)");
    }

    public static void Run()
    {
        Sample502 s = new Sample502();

        Console.WriteLine($"sのインスタンスフィールド : inum = {s.inum}");
        Console.WriteLine($"sample502のスタティックフィールド : snum = {snum}");
        Foo();
        s.Bar();
    }
}
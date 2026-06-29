namespace question401;

class Program
{
    static void Main(string[] args)
    {
        //インスタンスの生成
        Rectangle r = new Rectangle();
        //図形の幅と高さを入力
        Console.Write("幅(cm)");
        r.width = double.Parse(Console.ReadLine());
        Console.Write("高さ(cm)");
        r.height = double.Parse(Console.ReadLine());
        //面積の表示
        Console.WriteLine($"面積:{r.GetArea()}cm2");
        Console.WriteLine($"周の長さ:{r.GetPerimeter()}cm");
    }
}
namespace question402;

class Program
{
    static void Main(string[] arg)
    {
        Console.Write("文字を入力してください。");
        string str = Console.ReadLine() ?? "";

        Console.WriteLine($"大文字:{str.ToUpper()}");
        Console.WriteLine($"小文字:{str.ToLower()}");
    }
}
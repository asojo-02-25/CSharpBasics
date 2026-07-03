namespace question402;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("英文を入力してください : ");
        string text = Console.ReadLine()!;

        Console.WriteLine($"大文字 : {text.ToUpper()}");
        Console.WriteLine($"小文字 : {text.ToLower()}");
    }
}
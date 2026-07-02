namespace example303;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("数あてゲーム");

        Random rnd = new Random();
        int answer = rnd.Next(1, 11);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("0から10までの値を入力してください。");
            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("無効な値です。");
                return;
            }

            if (number > answer)
            {
                Console.WriteLine("大きすぎます。");

            }
            else if (number < answer)
            {
                Console.WriteLine("小さすぎます。");
            }
            else
            {
                Console.WriteLine("正解です！");
                return;
            }
        }
        Console.WriteLine("ゲームオーバー！");
        Console.WriteLine($"正解は{answer}です。");
    }
}
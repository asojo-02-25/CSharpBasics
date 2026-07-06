namespace Bookreview;

class Example401
{
    static public void Run()
    {
        Rectangle r = new Rectangle();

        Console.WriteLine("幅を入力してください");
        r.width = double.Parse(Console.ReadLine()!);

        Console.WriteLine("高さを入力してください");
        r.height = double.Parse(Console.ReadLine()!);

        r.GetArea();
        r.GetPerimeter();
    }

    class Rectangle
    {
        public double width = 0;
        public double height = 0;

        public void GetArea()
        {
            Console.WriteLine(width * height);
        }

        public void GetPerimeter()
        {
            Console.WriteLine(width * 2 + height * 2);
        }
    }
}
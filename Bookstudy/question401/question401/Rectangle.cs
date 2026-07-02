namespace question401;

class Rectangle
{
    //フィールドの設定
    public double width; 
    public double height;

    //メソッドの設定
    public double GetArea()
    {
        return width * height;
    }
    public double GetPerimeter()
    {
        return width * 2 + height * 2;
    }
}

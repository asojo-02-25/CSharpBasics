namespace example407;

class Student
{
    //名前、学年、年齢のフィールド
    private string name = "";
    private int grade = 0;
    private int age = 0;

    //引数なしコンストラクタ
    public Student() :this("名無し", 0, 0)
    {

    }
    //引数付きインストラクタ
    public Student(string name, int grade, int age)
    {
        setInformation(name, grade, age);
    }

    //情報の設定
    public void setInformation(string name, int grade, int age)
    {
        this.name = name;
        this.grade = grade;
        this.age = age;
    }

    //情報の表示
    public void showInformation()
    {
        Console.WriteLine($"名前 : {name} 学年 : {grade} 年齢 : {age}");
    }
}
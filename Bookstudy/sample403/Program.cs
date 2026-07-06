namespace BookStudy;

class Program
{
    static void Main(string[] args)
    {
        Person p1, p2;  //データの宣言 Person : データ型　p1, p2 : 変数名
        //1つ目のPersonクラスのインスタンスを作成
        p1 = new Person();
        //2つ目のPersonクラスのインスタンスを作成
        p2 = new Person();
        p1.Name = "山田太郎";
        p1.Age = 19;
        //メソッドでnameとageを設定
        p2.SetAgeAndName("佐藤花子", 23);

        p1.ShowAgeAndName();
        p2.ShowAgeAndName();
    }
}

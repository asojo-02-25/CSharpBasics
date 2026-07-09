using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter5
{
    internal class Sample510
    {
        static public void Run()
        {
            CellPhone cp = new CellPhone("hoge@email.com", "090-1234-5678");

            //電話番号クラスで電話とメールを送る
            cp.SendMail("fuga@email.com");
            cp.Call("011-123-4567");

            //電話インターフェースでインスタンスにアクセス
            IPhone phone = (IPhone)cp;
            phone.Call("011-9876-5432");

            //メールの送信メソッドは使用できない


            //メールインターフェースでインスタンスにアクセス
            IEmail email = (IEmail)cp;
            email.SendMail("bar@email.com");

            //電話の機能は利用できない
        }
    }

    class CellPhone : IPhone, IEmail
    {
        private string mailAdress;
        private string number;

        //コンストラクタ(メールアドレスと電話番号を設定)
        public CellPhone(string mailAdress, string number)
        {
            this.mailAdress = mailAdress;
            this.number = number;
        }

        //指定したメールアドレスにメールを送信する
        public void SendMail(string adress)
        {
            Console.WriteLine($"{adress}に{mailAdress}からメールを出します。");
        }

        //指定した番号に電話をかける
        public void Call(string number)
        {
            Console.WriteLine($"{number}に{this.number}から電話をかけます。");
        }
    }

    interface IPhone
    {
        void Call(string number);
    }

    interface IEmail
    {
        void SendMail(string adress);
    }
}

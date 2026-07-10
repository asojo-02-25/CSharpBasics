using System;
using System.Collections.Generic;
using System.Text;

namespace Bookreview.Chapter5
{
    internal class Sample510
    {
        static public void Run()
        {
            CellPhone c = new CellPhone("test@email.com", "012-345-6789");

            IPhone phone = (IPhone)c;
            phone.Call("098-765-4321");

            IEmail mail = (IEmail)c;
            mail.SendMail("test2@email.com");
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

    class CellPhone : IPhone, IEmail
    {
        private string adress;
        private string number;

        public CellPhone(string adress, string number)
        {
            this.adress = adress;
            this.number = number;
        }

        //指定したアドレスにメールを送る
        public void SendMail(string adress)
        {
            Console.WriteLine($"{adress}から{this.adress}にメールを送信");
        }

        //指定した番号に電話をかける
        public void Call(string number)
        {
            Console.WriteLine($"{number}から{this.number}に電話をかける");
        }
    }
}

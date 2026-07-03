namespace Sample405;

class Person2
{
    public void setNameAndAge(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void showNameAndAge()
    {
        Console.WriteLine($"名前 : {Name}, 年齢 : {Age}");
    }

    public string Name
    {
        private set; get;
    }

    public int Age
    {
        private set; get;
    }
}
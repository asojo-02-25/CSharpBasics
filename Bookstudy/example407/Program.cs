namespace example407;

class Program
{
    static void Main()
    {
        Student[] students = new Student[3];

        students[0] = new Student();
        students[1] = new Student("田中花子", 16, 1);
        students[2] = new Student("田中花子", 16, 1);

        foreach (Student s in students)
        {
            s.showInformation();
        }
    }
}
namespace BookLearning.Chapter5;

class Sample501
{
    static public void Run()
    {
        Data[] data = new Data[2];

        Data.ShowNumber();
        
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = new Data(i * 100);
            Data.ShowNumber();
        }
    }
}
namespace LearningC_Sharp.Problems;

public class DataTypeConversion
{
    public void Dtc()
    {
        int a = 500;
        float b = a;

        float c = 500.56f;
        int d = (int)c;
        // Console.WriteLine(Convert.ToString(1500));
        Console.WriteLine(int.TryParse("1500", out var result));
        Console.WriteLine(result);
    }
}
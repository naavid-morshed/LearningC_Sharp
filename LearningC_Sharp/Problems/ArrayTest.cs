namespace LearningC_Sharp.Problems;

public class ArrayTest
{
    private readonly int[] _arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    public void PrintArray()
    {
        // Console.WriteLine(_arr.FirstOrDefault());
        
        // _arr.ToList().ForEach(Console.Write);

        foreach (var t in _arr)
        {
            Console.Write(t + " ");
        }

        Console.WriteLine();
        for (var i = _arr.Length - 1; i >= 0; i--)
        {
            Console.Write(i + " ");
        }
    }
}
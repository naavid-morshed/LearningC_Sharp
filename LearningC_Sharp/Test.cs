using LearningC_Sharp.Problems; // is like import in java

namespace LearningC_Sharp;

public class Test
{
    public static void Main()
    {
        // Console.WriteLine("Enter your full name: ");
        // string? name = Console.ReadLine();
        // Console.WriteLine($"Your name is: {name}");
        //
        // string num = null;
        // Console.WriteLine(@"your file is located at: c:\drive\file\dir\file.ext");
        //
        // Console.WriteLine(num ?? "null");
        
        // var conversion = new DataTypeConversion();
        // conversion.Dtc();

        var tr = new ArrayTest();
        tr.PrintArray();
    }
}
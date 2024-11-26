namespace LearningC_Sharp.Problems;

public class SwitchCaseTest
{
    public void Sct()
    {
        // int number = 8;
        //
        // switch (number)
        // {
        //     case 1:
        //     case 2:
        //     case 3:
        //         Console.WriteLine("The number is 1, 2, or 3");
        //         break;
        //     case 4:
        //         Console.WriteLine("The number is 4");
        //         break;
        //     default:
        //         Console.WriteLine("The number is something else");
        //         break;
        // }

        // int number = 0;
        //
        // string result = number switch
        // {
        //     1 or 2 or 3 => $"The number is {number}",
        //     4 => "The number is 4",
        //     _ => "The number is something else"
        // };

        // Console.WriteLine(result);
        
        var value = ("Key", 2);

        switch (value)
        {
            case ("Key", 2) or ("Key", 1):
                Console.WriteLine("Pair (1,2) or (2,1)");
                break;
            default:
                Console.WriteLine("Other pair");
                break;
        }
    }
}
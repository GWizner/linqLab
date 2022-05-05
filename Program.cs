using System.Linq;
public class Program
{

    public static void Main(string[] args)
    {
        int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };
        nums.Min();
        int minVal = nums.Min();
        Console.WriteLine(minVal);
        Console.WriteLine();

        nums.Max();
        int maxVal = nums.Max();
        Console.WriteLine(maxVal);
        Console.WriteLine();

        var lessThan = nums.Where((x) => x < 10000).ToArray();
        var mLessThan = lessThan.Max();

        Console.WriteLine(mLessThan);
        Console.WriteLine();

        var between = nums.Where((x) => (x > 10) && (x < 100)).ToList();
        between.ForEach(x => Console.WriteLine(x));
        Console.WriteLine();
    
        var betweenI = nums.Where((x) => (x >= 100000) && (x <= 999999)).ToList();
        betweenI.ForEach(x => Console.WriteLine(x));
        Console.WriteLine();

        var even = nums.Count((x) => (x % 2) == 0);
        Console.WriteLine(even);
        Console.WriteLine();
    }
}
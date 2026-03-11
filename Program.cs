using apbd_cw1_git_s34002;
class Program
{
    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20 };
        double average = StatisticsHelper.CalculateAverage(numbers);
        Console.WriteLine($"srednia: {average}");
    }
}
using apbd_cw1_git_s34002;

class Program
{
    static void Main()
    {
        Console.WriteLine("wprowadz lizcby oddzielone spacja, aby obliczyc z nich srednia:");

        string input = Console.ReadLine();

        int[] numbers = input
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        double average = StatisticsHelper.CalculateAverage(numbers);

        Console.WriteLine($"srednia: {average}");
    }
}
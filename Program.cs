using apbd_cw1_git_s34002;
class Program
{
    static void Main()
    {
        Console.WriteLine("wprowadz liczby oddzielone spacja, aby obliczyc z nich srednia:");

        string input = Console.ReadLine();

        try
        {
            int[] numbers = input
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            double average = StatisticsHelper.CalculateAverage(numbers);
            int sum = StatisticsHelper.CalculateSum(numbers);

            Console.WriteLine($"srednia: {average}");
            Console.WriteLine($"suma: {sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("error, wpisuj tylko liczby.");
        }
    }
}
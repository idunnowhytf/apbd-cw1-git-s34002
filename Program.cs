class Program
{
    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"srednia: {average}");
    }

    static double CalculateAverage(int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return (double)sum / numbers.Length;
    }
}
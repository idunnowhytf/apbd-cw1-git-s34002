
using apbd_cw1_git_s34002;

Console.WriteLine("Hello, World!");
Console.WriteLine("enter numbers separated by space:");
string input = Console.ReadLine();
int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

Console.WriteLine($"Average: {StatisticsHelper.CalculateAverage(numbers)}");

if (numbers.Length == 0)
{
    Console.WriteLine("error");
    return;
}
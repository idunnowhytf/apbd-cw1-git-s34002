Console.WriteLine("Hello, World!");
Console.WriteLine("enter numbers separated by space:");
string input = Console.ReadLine();
int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

if (numbers.Length == 0)
{
    Console.WriteLine("error");
    return;
}
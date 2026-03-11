namespace apbd_cw1_git_s34002;
public static class StatisticsHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return (double)sum / numbers.Length;
    }
    
    public static int CalculateSum(int[] values)
    {
        int sum = 0;

        foreach (int value in values)
        {
            sum += value;
        }

        return sum;
    }
    public static int CalculateMax(int[] values)
    {
        int max = values[0];

        foreach (int value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }

        return max;
    }
    public static int CalculateMin(int[] values)
    {
        int min = values[0];
        return min;
    }
    
}

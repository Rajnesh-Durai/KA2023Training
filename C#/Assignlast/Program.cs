// See https://aka.ms/new-console-template for more information
internal class Program
{
    static long GetSuperDigit(long n)
    {
        // Base case: single-digit number
        if (n < 10)
        {
            return n;
        }

        // Calculate the digit sum of n
        long digitSum = 0;
        while (n > 0)
        {
            digitSum += n % 10;
            n /= 10;
        }

        // Recursively calculate the super digit of the digit sum
        return GetSuperDigit(digitSum);
    }
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Trim().Split();
        string n = input[0];
        int k = int.Parse(input[1]);

        // Calculate the digit sum of n
        long digitSum = 0;
        for (int i = 0; i < n.Length; i++)
        {
            digitSum += int.Parse(n[i].ToString());
        }

        // Calculate the super digit of n
        long superDigit = GetSuperDigit(digitSum);

        // Multiply the super digit by k
        superDigit *= k;

        // Calculate the super digit of the product
        superDigit = GetSuperDigit(superDigit);

        // Print the result
        Console.WriteLine(superDigit);

    }
}

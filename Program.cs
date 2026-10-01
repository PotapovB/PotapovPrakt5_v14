namespace PotapovPrakt5_v14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long value = long.Parse(Console.ReadLine());

            double temp = value;
            int divisor = 2;

            long left_closest = 1;
            long right_closest = 1;

            while (temp >= 1.0)
            {
                temp /= divisor;

                if (temp >= 1.0)
                {
                    left_closest *= divisor;
                }
                right_closest *= divisor;

                divisor++;
            }

            long right_diff = right_closest - value;
            long left_diff = value - left_closest;

            if (right_diff > left_diff)
            {
                Console.WriteLine($"{divisor - 2}! = {left_closest}");
            }
            else
            {
                Console.WriteLine($"{divisor - 1}! = {right_closest}");
            }
        }
    }
}

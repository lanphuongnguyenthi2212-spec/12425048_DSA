namespace Bài_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("n phải là số nguyên dương!");
            }
            else if (n == 1)
            {
                Console.WriteLine("Số Fibonacci thứ 1 là: 0");
            }
            else
            {
                long a = 0, b = 1;
                for (int i = 0; i < n - 2; i++)
                {
                    long next = a + b;
                    a = b;
                    b = next;
                }
                Console.WriteLine($"Số Fibonacci thứ {n} là: {b}");
            }
        }
    }
}

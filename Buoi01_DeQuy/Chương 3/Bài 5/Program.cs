namespace Bài_5
{
    internal class Program
    {
        static int UocLeMax(int n)
        {
            if (n % 2 != 0) return n; 
            return UocLeMax(n / 2);   
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine($"Ước lẻ lớn nhất của {n} là: {UocLeMax(n)}");
        }
    }
}

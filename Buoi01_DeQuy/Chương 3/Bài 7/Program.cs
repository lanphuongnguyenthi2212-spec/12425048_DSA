namespace Bài_7
{
    internal class Program
    {
        static int SoChuSo(int n)
        {
            if (n == 0) return 0; 
            return SoChuSo(n / 10) + 1; 
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Số chữ số của {n} là: {SoChuSo(n)}");
        }
    }
}

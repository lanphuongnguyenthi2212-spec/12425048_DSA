namespace Bài_2
{
    internal class Program
    {
        static int TinhTongBinhPhuong(int n)
        {
            if (n == 1) return 1; 
            return TinhTongBinhPhuong(n - 1) + n * n; 
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine($"S({n}) = {TinhTongBinhPhuong(n)}");
        }
    }
}

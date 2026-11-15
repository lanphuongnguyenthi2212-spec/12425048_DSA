namespace Bài_3
{
    internal class Program
    {
        static double TinhTongPhanSo(int n)
        {
            if (n == 1) return 1.0;
            return TinhTongPhanSo(n - 1) + 1.0 / n; 

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine($"S({n}) = {TinhTongPhanSo(n):F4}");
        }
    }
}

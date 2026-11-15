namespace Bài_8
{
    internal class Program
    {
        static double Can(int i, int n)
        {
            if (i == n) return Math.Sqrt(n); 
            return Math.Sqrt(i + Can(i + 1, n)); 
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n cho biểu thức căn lồng nhau: ");
            int n = int.Parse(Console.ReadLine() ?? "1");
            double ketQua = Can(1, n);
            Console.WriteLine($"S({n}) căn lồng nhau = {ketQua:F4}");
        }
    }
}

namespace Bài_1
{
    internal class Program
    {
        static int TinhTong(int n)
        {
            if (n == 1) return 1;
            return TinhTong(n - 1) + n;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"S({n}) = {TinhTong(n)}");
        }
    }
}
    


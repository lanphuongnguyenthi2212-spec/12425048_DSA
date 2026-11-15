namespace Bài_4
{
    internal class Program
    {
        static double LuyThua(double x, int n)
        {
            if (n == 0) return 1; 
            if (n < 0) return 1.0 / LuyThua(x, -n); 
            return LuyThua(x, n - 1) * x; 
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập cơ số x: ");
            double x = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhập số mũ n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"{x}^{n} = {LuyThua(x, n)}");
        }
    }
}

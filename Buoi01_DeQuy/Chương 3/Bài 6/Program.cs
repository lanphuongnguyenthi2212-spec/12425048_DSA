namespace Bài_6
{
    internal class Program
    {
        static int UCLN(int a, int b)
        {
            if (a % b == 0) return b;
            return UCLN(b, a % b);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine() ?? "1");
            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
        }
    }
}

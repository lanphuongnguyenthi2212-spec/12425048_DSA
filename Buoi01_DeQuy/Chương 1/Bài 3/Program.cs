namespace Bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập chuỗi:");
            string s = Console.ReadLine();

            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            Console.WriteLine("Chuỗi đảo ngược: " + reversed);
        }
    }
}

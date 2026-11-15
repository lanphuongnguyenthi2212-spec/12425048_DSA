namespace Bài_3
{
    internal class Program
    {       
            static bool KiemTraCoBan(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= n - 1; i++)
                {
                    if (n % i == 0) return false; 
                }
                return true;
            }

            static bool KiemTraCaiTien(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }

            public static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.Write("Nhập số nguyên dương n cần kiểm tra: ");
                int n = int.Parse(Console.ReadLine() ?? "0");

                if (KiemTraCaiTien(n))
                {
                    Console.WriteLine($"{n} LÀ số nguyên tố.");
                }
                else
                {
                    Console.WriteLine($"{n} KHÔNG PHẢI là số nguyên tố.");
                }
            }
        }
    }
    


using System.Diagnostics;

namespace Bài_1
{
    internal class Program
    {
            static void ThapHaNoi(int n, char nguon, char trungGian, char dich)
            {
                if (n == 1)
                {
                    Console.WriteLine($"Chuyển đĩa 1 từ {nguon} sang {dich}");
                    return;
                }

                ThapHaNoi(n - 1, nguon, dich, trungGian);

                Console.WriteLine($"Chuyển đĩa {n} từ {nguon} sang {dich}");

                ThapHaNoi(n - 1, trungGian, nguon, dich);
            }

            public static void Main(string[] args)
        {
                  Console.OutputEncoding = System.Text.Encoding.UTF8;

                  Console.Write("Nhập số lượng đĩa n: ");
                int n = int.Parse(Console.ReadLine());

                Stopwatch sw = Stopwatch.StartNew();
                ThapHaNoi(n, 'A', 'B', 'C');
                sw.Stop();

                Console.WriteLine($"Thời gian thực thi: {sw.Elapsed.TotalMilliseconds} ms");
            }
        }
    }
    


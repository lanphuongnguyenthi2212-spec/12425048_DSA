using System;
using System.Diagnostics;

class Bài_4
{
    static bool LaSoHoanHao_CoBan(int num)
    {
        if (num < 2) return false;
        int tongUoc = 0;
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0) tongUoc += i;
        }
        return tongUoc == num;
    }

   static bool LaSoHoanHao_CaiTien(int num)
    {
        if (num < 2) return false;
        int tongUoc = 1; 

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                tongUoc += i;
                if (i != num / i) 
                {
                    tongUoc += num / i;
                }
            }
        }
        return tongUoc == num;
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập N: ");
        int n = int.Parse(Console.ReadLine() ?? "10000");

        Stopwatch sw1 = Stopwatch.StartNew();
        Console.Write("\n[Giải thuật 1 - Cơ bản] Các số hoàn hảo: ");
        for (int i = 1; i < n; i++)
        {
            if (LaSoHoanHao_CoBan(i)) Console.Write(i + " ");
        }
        sw1.Stop();
        Console.WriteLine($"\n=> Thời gian chạy Giải thuật 1: {sw1.Elapsed.TotalMilliseconds} ms");

        Stopwatch sw2 = Stopwatch.StartNew();
        Console.Write("\n[Giải thuật 2 - Cải tiến] Các số hoàn hảo: ");
        for (int i = 1; i < n; i++)
        {
            if (LaSoHoanHao_CaiTien(i)) Console.Write(i + " ");
        }
        sw2.Stop();
        Console.WriteLine($"\n=> Thời gian chạy Giải thuật 2: {sw2.Elapsed.TotalMilliseconds} ms");
    }
}
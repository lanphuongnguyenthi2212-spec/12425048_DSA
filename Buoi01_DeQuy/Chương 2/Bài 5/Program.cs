using System;
using System.Diagnostics;

class Bài_5
{
    // Giải thuật 1: Đệ quy trực tiếp 
    static long Fibonacci_DeQuy(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;
        return Fibonacci_DeQuy(n - 1) + Fibonacci_DeQuy(n - 2);
    }

    // Giải thuật 2: Sử dụng vòng lặp 
    static long Fibonacci_VongLap(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;

        long a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return b;
    }

    // Giải thuật 3: Đệ quy có nhớ - Memoization 
    static long Fibonacci_Memoization(int n, long[] memo)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;
        if (memo[n] != -1) return memo[n]; 

        memo[n] = Fibonacci_Memoization(n - 1, memo) + Fibonacci_Memoization(n - 2, memo);
        return memo[n];
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên n cần tìm Fibonacci: ");
        int n = int.Parse(Console.ReadLine() ?? "10");

        if (n <= 40)
        {
            Stopwatch sw1 = Stopwatch.StartNew();
            long kq1 = Fibonacci_DeQuy(n);
            sw1.Stop();
            Console.WriteLine($"[Giải thuật 1 - Đệ quy trực tiếp] F({n}) = {kq1} | Thời gian: {sw1.Elapsed.TotalMilliseconds} ms");
        }
        else
        {
            Console.WriteLine($"[Giải thuật 1 - Đệ quy trực tiếp] Bỏ qua vì n = {n} quá lớn, chạy sẽ bị treo máy (O(2^n)).");
        }

        Stopwatch sw2 = Stopwatch.StartNew();
        long kq2 = Fibonacci_VongLap(n);
        sw2.Stop();
        Console.WriteLine($"\n[Giải thuật 2 - Vòng lặp] F({n}) = {kq2} | Thời gian: {sw2.Elapsed.TotalMilliseconds} ms");


        Stopwatch sw3 = Stopwatch.StartNew();
        long[] memo = new long[n + 1];
        for (int i = 0; i <= n; i++) memo[i] = -1; 
        long kq3 = Fibonacci_Memoization(n, memo);
        sw3.Stop();
        Console.WriteLine($"[Giải thuật 3 - Đệ quy có nhớ] F({n}) = {kq3} | Thời gian: {sw3.Elapsed.TotalMilliseconds} ms");
    
    }
}
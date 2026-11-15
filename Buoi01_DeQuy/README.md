# Buổi 01 – Đệ quy

Họ tên: Nguyễn Thị Lan Phương · MSV: 12425048

## Bài đã làm

Bài tập chia theo 3 chương, mỗi chương là một thư mục tổng và là một project console C#. Mỗi chương có file `Program.cs` là menu để chọn bài cần chạy; mỗi bài nằm ở một file riêng `Bai1.cs`, `Bai2.cs`, ...
```text
Buoi01_DeQuy/
├── README.md
├── Chương 1/   Chuong1.csproj, Program.cs, Bai1.cs ... Bai5.cs
├── Chương 2/   Chuong2.csproj, Program.cs, Bai1.cs ... Bai6.cs
└── Chương 3/   Chuong3.csproj, Program.cs, Bai1.cs ... Bai8.cs
```
**Chương 1**

| Menu | File | Nội dung |
| :---: | :---: | :--- |
| 1 | `Bai1.cs` | Tìm số lớn nhất, nhỏ nhất trong 1000 số ngẫu nhiên |
| 2 | `Bai2.cs` | FizzBuzz từ 1 đến 100 |
| 3 | `Bai3.cs` | Đảo ngược chuỗi |
| 4 | `Bai4.cs` | In mảng và sắp xếp tăng dần |
| 5 | `Bai5.cs` | Tìm số Fibonacci thứ n |

**Chương 2**

| Menu | File | Nội dung |
| :---: | :---: | :--- |
| 1 | `Bai1.cs` | Tháp Hà Nội (đệ quy), đo thời gian thực thi |
| 2 | `Bai2.cs` | Tìm kiếm nhị phân bằng đệ quy |
| 3 | `Bai3.cs` | Kiểm tra số nguyên tố |
| 4 | `Bai4.cs` | Liệt kê số hoàn hảo nhỏ hơn n |
| 5 | `Bai5.cs` | Fibonacci bằng vòng lặp |
| 6 | `Bai6.cs` | Sắp xếp nổi bọt (Bubble Sort) |

**Chương 3**

| Menu | File | Nội dung |
| :---: | :---: | :--- |
| 1 | `Bai1.cs` | S(n) = 1 + 2 + 3 + … + n |
| 2 | `Bai2.cs` | S(n) = 1 + 2² + 3² + … + n²|
| 3 | `Bai3.cs` | S(n) = 1 + 1/2 + 1/3 + … + 1/n |
| 4 | `Bai4.cs` | S(x, n) = xⁿ (n có thể âm)|
| 5 | `Bai5.cs` | Ước lẻ lớn nhất của n|
| 6 | `Bai6.cs` | Ước chung lớn nhất UCLN(a, b)
| 7 | `Bai7.cs` | Đếm số chữ số của n |
| 8 | `Bai8.cs` | S(n) = √(1 + √(2 + … + √n)) |

## CÁCH CHẠY
```text
dotnet run --project "Bài 1/Bài 1.csproj"
dotnet run --project "Bài 2/Bài 2.csproj"
dotnet run --project "Bài 3/Bài 3.csproj"
```
## CHƯƠNG 1
**BÀI 1**
```text
namespace Bài_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            int[] arr = new int[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 1000);
            }
            int max = arr[0];
            int min = arr[0];
            foreach (int x in arr)
            {
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
            }
            Console.WriteLine("Số lớn nhất: " + max);
            Console.WriteLine("Số nhỏ nhất: " + min);
        }
    }
}
```
**KẾT QUẢ**
```text
Số lớn nhất: 999
Số nhỏ nhất: 1
```
**BÀI 2**
```text
namespace Bài_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
```
**KẾT QUẢ**
```text
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
16
17
Fizz
19
Buzz
Fizz
22
23
Fizz
Buzz
26
Fizz
28
29
FizzBuzz
31
32
Fizz
34
Buzz
Fizz
37
38
Fizz
Buzz
41
Fizz
43
44
FizzBuzz
46
47
Fizz
49
Buzz
Fizz
52
53
Fizz
Buzz
56
Fizz
58
59
FizzBuzz
61
62
Fizz
64
Buzz
Fizz
67
68
Fizz
Buzz
71
Fizz
73
74
FizzBuzz
76
77
Fizz
79
Buzz
Fizz
82
83
Fizz
Buzz
86
Fizz
88
89
FizzBuzz
91
92
Fizz
94
Buzz
Fizz
97
98
Fizz
Buzz
```
**BÀI 3**
```text
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
```
**KẾT QUẢ**
```text
Nhập chuỗi:12345
Chuỗi đảo ngược: 54321
```
**BÀI 4**
```text
namespace Bài_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            int[] arr = new int[100];

            for (int i = 0; i < 100; i++)
            {
                arr[i] = rnd.Next(1, 101);
            }

            Console.WriteLine("Mảng ban đầu:");
            Console.WriteLine(string.Join(", ", arr));

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
```
**KẾT QUẢ**
```text
Mảng ban đầu:
90, 33, 93, 65, 38, 20, 50, 91, 33, 43, 70, 95, 17, 35, 48, 8, 98, 45, 62, 36, 93, 46, 47, 55, 91, 38, 32, 64, 9, 32, 69, 51, 9, 73, 23, 40, 25, 79, 54, 98, 2, 15, 81, 35, 16, 81, 1, 76, 46, 45, 82, 15, 69, 59, 31, 41, 10, 52, 58, 11, 2, 19, 53, 49, 32, 60, 11, 76, 98, 92, 76, 94, 63, 35, 39, 15, 48, 77, 26, 42, 23, 48, 42, 86, 70, 86, 5, 26, 1, 93, 34, 75, 10, 97, 91, 24, 77, 21, 80, 90
Mảng sau khi sắp xếp tăng dần:
1, 1, 2, 2, 5, 8, 9, 9, 10, 10, 11, 11, 15, 15, 15, 16, 17, 19, 20, 21, 23, 23, 24, 25, 26, 26, 31, 32, 32, 32, 33, 33, 34, 35, 35, 35, 36, 38, 38, 39, 40, 41, 42, 42, 43, 45, 45, 46, 46, 47, 48, 48, 48, 49, 50, 51, 52, 53, 54, 55, 58, 59, 60, 62, 63, 64, 65, 69, 69, 70, 70, 73, 75, 76, 76, 76, 77, 77, 79, 80, 81, 81, 82, 86, 86, 90, 90, 91, 91, 91, 92, 93, 93, 93, 94, 95, 97, 98, 98, 98
```
**BÀI 5**
```text
namespace Bài_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("n phải là số nguyên dương!");
            }
            else if (n == 1)
            {
                Console.WriteLine("Số Fibonacci thứ 1 là: 0");
            }
            else
            {
                long a = 0, b = 1;
                for (int i = 0; i < n - 2; i++)
                {
                    long next = a + b;
                    a = b;
                    b = next;
                }
                Console.WriteLine($"Số Fibonacci thứ {n} là: {b}");
            }
        }
    }
}

```
**KẾT QUẢ**
```text
Nhập số nguyên dương n: 9
Số Fibonacci thứ 9 là: 21
```
## CHƯƠNG 2
**BÀI 1**
```text
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
```
**KẾT QUẢ**
```text
Nhập số lượng đĩa n: 3
Chuyển đĩa 1 từ A sang C
Chuyển đĩa 2 từ A sang B
Chuyển đĩa 1 từ C sang B
Chuyển đĩa 3 từ A sang C
Chuyển đĩa 1 từ B sang A
Chuyển đĩa 2 từ B sang C
Chuyển đĩa 1 từ A sang C
Thời gian thực thi: 0.605 ms
```
**BÀI 2**
```text
using System.Diagnostics;

namespace Bài_2
{
    internal class Program
    {
        static int LinearSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == key) return i;
            return -1;
        }

        static int BinarySearch(int[] arr, int key)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == key) return mid;
                else if (arr[mid] < key) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] sizes = { 10, 20, 30, 35, 40, 45 };
            int repeat = 35;

            Console.WriteLine("{0,12} {1,20} {2,20}", "n", "Tuần tự (ms)", "Nhị phân (ms)");

            foreach (int n in sizes)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++) arr[i] = i;

                int key = n - 1;

                Stopwatch sw = new Stopwatch();

                sw.Start();
                for (int r = 0; r < repeat; r++) LinearSearch(arr, key);
                sw.Stop();
                double tLinear = sw.Elapsed.TotalMilliseconds;

                sw.Restart();
                for (int r = 0; r < repeat; r++) BinarySearch(arr, key);
                sw.Stop();
                double tBinary = sw.Elapsed.TotalMilliseconds;

                Console.WriteLine("{0,12} {1,20:F4} {2,20:F4}", n, tLinear, tBinary);
            }
        }
    }
}
```
**KẾT QUẢ**
```text
           n         Tuần tự (ms)        Nhị phân (ms)
          10               0.1967               0.0972
          20               0.0014               0.0009
          30               0.0050               0.0021
          35               0.0030               0.0007
          40               0.0040               0.0007
          45               0.0022               0.0011
```
**BÀI 3**
```text
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
```
**KẾT QUẢ**
```text
Nhập số nguyên dương n cần kiểm tra: 2
2 LÀ số nguyên tố.
```
**BÀI 4**
```text
using System;
using System.Diagnostics;

namespace Bài_4
{
    internal class Program
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
}
```
**KẾT QUẢ**
```text
Nhập N: 22

[Giải thuật 1 - Cơ bản] Các số hoàn hảo: 6
=> Thời gian chạy Giải thuật 1: 0.3464 ms

[Giải thuật 2 - Cải tiến] Các số hoàn hảo: 6
=> Thời gian chạy Giải thuật 2: 0.2813 ms
```
**BÀI 5**
```text
using System;
using System.Diagnostics;

namespace Bài_5
{
    internal class Program
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
}
```
**KẾT QUẢ**
```text
Nhập số nguyên n cần tìm Fibonacci: 12
[Giải thuật 1 - Đệ quy trực tiếp] F(12) = 144 | Thời gian: 0.306 ms

[Giải thuật 2 - Vòng lặp] F(12) = 144 | Thời gian: 0.238 ms
[Giải thuật 3 - Đệ quy có nhớ] F(12) = 144 | Thời gian: 0.2782 ms
```
**BÀI 6**
```text
using System;
using System.Diagnostics;

namespace Bài_6
{
    internal class Program
    {
        // Giải thuật 1: Sắp xếp nổi bọt (Bubble Sort) - Đơn giản, dễ hiểu
        static void BubbleSort(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Giải thuật 2: Sắp xếp chọn (Selection Sort) - Cải thiện hơn Bubble Sort một chút
        static void SelectionSort(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                double temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double[] originalArr = { 5, 6, 7, 8, 9, 10, 22, 12, 99, 4, 3 };

            double[] arr1 = (double[])originalArr.Clone();
            Stopwatch sw1 = Stopwatch.StartNew();
            BubbleSort(arr1);
            sw1.Stop();

            Console.WriteLine("Mảng sau khi sắp xếp (Bubble Sort):");
            Console.WriteLine(string.Join(", ", arr1));
            Console.WriteLine($"=> Thời gian chạy Bubble Sort: {sw1.Elapsed.TotalMilliseconds} ms\n");

            double[] arr2 = (double[])originalArr.Clone();
            Stopwatch sw2 = Stopwatch.StartNew();
            SelectionSort(arr2);
            sw2.Stop();

            Console.WriteLine("Mảng sau khi sắp xếp (Selection Sort):");
            Console.WriteLine(string.Join(", ", arr2));
            Console.WriteLine($"=> Thời gian chạy Selection Sort: {sw2.Elapsed.TotalMilliseconds} ms");
        }
    }
}
```
**KẾT QUẢ**
```text
Mảng sau khi sắp xếp (Bubble Sort):
3, 4, 5, 6, 7, 8, 9, 10, 12, 22, 99
=> Thời gian chạy Bubble Sort: 0.1544 ms

Mảng sau khi sắp xếp (Selection Sort):
3, 4, 5, 6, 7, 8, 9, 10, 12, 22, 99
=> Thời gian chạy Selection Sort: 0.1094 ms
```
## CHƯƠNG 3
**BÀI 1**
```text
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
```
**KẾT QUẢ**
```text
Nhập n: 2
S(2) = 3
```
**BÀI 2**
```text
namespace Bài_2
{
    internal class Program
    {
        static int TinhTongBinhPhuong(int n)
        {
            if (n == 1) return 1; 
            return TinhTongBinhPhuong(n - 1) + n * n; 
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine($"S({n}) = {TinhTongBinhPhuong(n)}");
        }
    }
}

```
**KẾT QUẢ**
```text
Nhập n: 12
S(12) = 650
```
**BÀI 3**
```text
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
```
**KẾT QUẢ**
```text
Nhập n: 16
S(16) = 3.3807
```
**BÀI 4**
```text
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
```
**KẾT QUẢ**
```text
Nhập cơ số x: 12
Nhập số mũ n: 2
12^2 = 144
```
**BÀI 5**
```text
namespace Bài_5
{
    internal class Program
    {
        static int UocLeMax(int n)
        {
            if (n % 2 != 0) return n; 
            return UocLeMax(n / 2);   
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine($"Ước lẻ lớn nhất của {n} là: {UocLeMax(n)}");
        }
    }
}
```
**KẾT QUẢ**
```text
Nhập số nguyên dương n: 2
Ước lẻ lớn nhất của 2 là: 1
```
**BÀI 6**
```text
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
```
**KẾT QUẢ**
```text
Nhập số a: 22
Nhập số b: 12
UCLN(22, 12) = 2
```
**BÀI 7**
```text
namespace Bài_7
{
    internal class Program
    {
        static int SoChuSo(int n)
        {
            if (n == 0) return 0; 
            return SoChuSo(n / 10) + 1; 
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Số chữ số của {n} là: {SoChuSo(n)}");
        }
    }
}
```
**KẾT QUẢ**
```text
Nhập số nguyên dương n: 1234
Số chữ số của 1234 là: 4
```
**BÀI 8**
```text
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
```
**KẾT QUẢ**
```text
Nhập n cho biểu thức căn lồng nhau: 23
S(23) căn lồng nhau = 1.7579
```





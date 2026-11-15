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
Nhập số nguyên dương n:9
Số Fibonacci thứ 9 là: 21
```
## CHƯƠNG 2
**BÀI 1**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 2**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 3**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 4**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 5**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 6**
```text

```
**KẾT QUẢ**
```text
```
## CHƯƠNG 3
**BÀI 1**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 2**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 3**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 4**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 5**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 6**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 7**
```text

```
**KẾT QUẢ**
```text
```
**BÀI 8**
```text

```
**KẾT QUẢ**
```text
```





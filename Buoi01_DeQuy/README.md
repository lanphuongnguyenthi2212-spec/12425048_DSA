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
```
**BÀI 3**
```text
```
**BÀI 4**
```text
```
**BÀI 5**
```text
```
## CHƯƠNG 2
**BÀI 1**
```text

```
**BÀI 2**
```text

```
**BÀI 3**
```text

```
**BÀI 4**
```text

```
**BÀI 5**
```text

```
**BÀI 6**
```text

```
## CHƯƠNG 3
**BÀI 1**
```text

```
**BÀI 2**
```text

```
**BÀI 3**
```text

```
**BÀI 4**
```text

```
**BÀI 5**
```text

```
**BÀI 6**
```text

```
**BÀI 7**
```text

```
**BÀI 8**
```text

```





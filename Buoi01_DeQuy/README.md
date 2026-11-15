Bài tập chia theo 3 chương, mỗi chương là một thư mục và là một project console C#. Mỗi chương có file Program.cs là menu để chọn bài cần chạy; mỗi bài nằm ở một file riêng Bai1.cs, Bai2.cs, …

Buoi01_DeQuy/
├── README.md
├── Chương 1/   Chuong1.csproj, Program.cs, Bai1.cs … Bai5.cs
├── Chương 2/   Chuong2.csproj, Program.cs, Bai1.cs … Bai6.cs
└── Chương 3/   Chuong3.csproj, Program.cs, Bai1.cs … Bai8.cs
Chương 1

Menu	File	Nội dung
1	Bai1.cs	Tìm số lớn nhất, nhỏ nhất trong 1000 số ngẫu nhiên
2	Bai2.cs	FizzBuzz từ 1 đến 100
3	Bai3.cs	Đảo ngược chuỗi
4	Bai4.cs	In mảng và sắp xếp tăng dần
5	Bai5.cs	Tìm số Fibonacci thứ n
Chương 2

Menu	File	Nội dung
1	Bai1.cs	Tháp Hà Nội (đệ quy), đo thời gian thực thi
2	Bai2.cs	Tìm kiếm nhị phân bằng đệ quy
3	Bai3.cs	Kiểm tra số nguyên tố
4	Bai4.cs	Liệt kê số hoàn hảo nhỏ hơn n
5	Bai5.cs	Fibonacci bằng vòng lặp
6	Bai6.cs	Sắp xếp nổi bọt (Bubble Sort)
Chương 3 (đệ quy)

Menu	File	Nội dung
1	Bai1.cs	S(n) = 1 + 2 + 3 + … + n
2	Bai2.cs	S(n) = 1 + 2² + 3² + … + n²
3	Bai3.cs	S(n) = 1 + 1/2 + 1/3 + … + 1/n
4	Bai4.cs	S(x, n) = xⁿ (n có thể âm)
5	Bai5.cs	Ước lẻ lớn nhất của n
6	Bai6.cs	Ước chung lớn nhất UCLN(a, b)
7	Bai7.cs	Đếm số chữ số của n
8	Bai8.cs	S(n) = √(1 + √(2 + … + √n))
Cách chạy
Chạy từ thư mục gốc của repo (cần cài .NET SDK 10.0). Tên thư mục có dấu cách nên phải đặt trong dấu ngoặc kép:

dotnet run --project "Buoi01_DeQuy/Chương 1"
dotnet run --project "Buoi01_DeQuy/Chương 2"
dotnet run --project "Buoi01_DeQuy/Chương 3"
Chương trình hiện menu, nhập số thứ tự bài để chạy, nhấn Enter để quay lại menu, nhập 0 để thoát.

Kết quả chạy
Chương 1
Menu:

========== BUOI 01 - CHUONG 1 ==========
1. Tim max/min trong 1000 so ngau nhien
2. FizzBuzz 1 den 100
3. Dao nguoc chuoi
4. In mang va sap xep tang dan
5. Tim so Fibonacci thu n
0. Thoat
Chon bai: 
Bài 1 – số ngẫu nhiên nên kết quả mỗi lần chạy một khác:

--- BÀI 1: TÌM MAX / MIN TRONG 1000 SỐ NGẪU NHIÊN ---
Đã khởi tạo mảng gồm 1000 phần tử ngẫu nhiên.
+ Số lớn nhất (Max) trong mảng là: 999
+ Số nhỏ nhất (Min) trong mảng là: 2
Bài 2:

--- BÀI 2: BÀI TOÁN FIZZBUZZ ---
1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz 
Bài 3 – nhập Xin chao:

--- BÀI 3: ĐẢO NGƯỢC CHUỖI ---
Nhập vào một chuỗi bất kỳ: Xin chao
Chuỗi sau khi đảo ngược: oahc niX
Bài 4 – mảng 50 số ngẫu nhiên:

--- BÀI 4: IN MẢNG VÀ SẮP XẾP TĂNG DẦN ---
Mảng ban đầu:
11, 75, 84, 86, 74, 55, 9, 49, 4, 59, 11, 42, 16, 60, 31, 95, 50, 6, 42, 29, 91, 33, 76, 71, 35, 86, 57, 15, 11, 50, 98, 67, 11, 42, 68, 93, 33, 40, 26, 75, 51, 64, 94, 98, 92, 81, 14, 51, 48, 40
Mảng sau khi sắp xếp tăng dần:
4, 6, 9, 11, 11, 11, 11, 14, 15, 16, 26, 29, 31, 33, 33, 35, 40, 40, 42, 42, 42, 48, 49, 50, 50, 51, 51, 55, 57, 59, 60, 64, 67, 68, 71, 74, 75, 75, 76, 81, 84, 86, 86, 91, 92, 93, 94, 95, 98, 98
Bài 5 – nhập n = 10:

--- BÀI 5: TÌM SỐ FIBONACCI THỨ N ---
Nhập số nguyên dương n: 10
Số Fibonacci thứ 10 là: 55
Chương 2
Menu:

========== BUOI 01 - CHUONG 2 ==========
1. Thap Ha Noi (do thoi gian)
2. Tim kiem nhi phan (de quy)
3. Kiem tra so nguyen to
4. Liet ke so hoan hao nho hon n
5. Fibonacci bang vong lap
6. Sap xep noi bot (Bubble Sort)
0. Thoat
Chon bai: 
Bài 1 – nhập n = 10 (thời gian thực thi thay đổi theo máy):

Nhap so luong dia n: 10
Thoi gian thuc thi: 0.0837 ms
Bài 2:

Tim thay tai vi tri: 7
Bài 3 – nhập 97:

Nhap so nguyen can kiem tra: 97
97 la so nguyen to.
Bài 4 – nhập n = 10000:

Nhap n de liet ke so hoan hao nho hon n: 10000
Cac so hoan hao nho hon 10000: 6 28 496 8128 
Bài 5 – nhập n = 30:

Nhap vi tri n cua so Fibonacci can tim: 30
So Fibonacci thu 30 la: 832040
Bài 6:

Day sau khi sap xep:
1.2  2.1  3.5  5.4  9.8  
Chương 3
Menu:

========== BUOI 01 - CHUONG 3 ==========
1. S(n) = 1 + 2 + ... + n
2. S(n) = 1 + 2^2 + ... + n^2
3. S(n) = 1 + 1/2 + ... + 1/n
4. S(x, n) = x^n
5. Uoc le lon nhat cua n
6. UCLN(a, b)
7. Dem so chu so cua n
8. S(n) = sqrt(1 + sqrt(2 + ... + sqrt(n)))
0. Thoat
Chon bai: 
Bài 1 – nhập n = 10:

Nhap n: 10
S(10) = 55
Bài 2 – nhập n = 10:

Nhap n: 10
S(10) = 385
Bài 3 – nhập n = 10:

Nhap n: 10
S(10) = 2.9290
Bài 4 – nhập x = 2, n = 10 và x = 2, n = −3:

Nhap co so x: 2
Nhap so mu n: 10
2^10 = 1024
Nhap co so x: 2
Nhap so mu n: -3
2^-3 = 0.125
Bài 5 – nhập n = 100:

Nhap so nguyen duong n: 100
Uoc so le lon nhat cua 100 la: 25
Bài 6 – nhập a = 48, b = 18:

Nhap a: 48
Nhap b: 18
UCLN(48, 18) = 6
Bài 7 – nhập n = 12345:

Nhap n: 12345
So chu so cua 12345 la: 5
Bài 8 – nhập n = 10:

Nhap n: 10
S(n) = 1.7579

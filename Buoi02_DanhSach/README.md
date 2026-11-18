# Buổi 02 – MẢNG VÀ DANH SÁCH LIÊN KẾT

Họ tên: Nguyễn Thị Lan Phương · MSV: 12425048

## Bài đã làm
**Bài tập chương 4**:  Bài 1, Bài 2, Bài 3, Bài 4, Bài 5 <br>
**Bài tập tự thực hành cuối sách**: Bài 7, Bài 8, Bài 9, Bài 10, Bài 11, Bài 12, Bài 13, Bài 14, Bài 15, Bài 16, Bài 17, Bài 18
## Cách Làm
dotnet run --project Buoi02_DanhSach
## Kết quả chạy
**MENU**
```text
================ MENU MẢNG VÀ DANH SÁCH LIÊN KẾT ================
1.  Mảng 1 chiều
2.  Quản lý danh sách nhân viên
3.  Ma trận vuông
4.  Danh sách liên kết đơn pHead
5.  Danh sách liên kết đơn l
7.  Quản lý nhiệt độ n ngày
8.  Thống kê tần suất từ trong chuỗi
9.  Xử lý dãy số nguyên
10. In ma trận theo thứ tự xoắn ốc
11. Kiểm tra ma trận đơn vị, ma trận đối xứng
12. Game Minesweeper (Đếm mìn xung quanh)
13. Đảo ngược danh sách liên kết đơn
14. Gộp hai danh sách liên kết đã sắp xếp
15. Phát hiện chu trình
16. Lịch sử duyệt web
17. Playlist nhạc
18. Hệ thống đặt hàng
0. Thoát chương trình
Nhập bài muốn chạy:
```
**Bài 1**
```text
Nhập số lượng phần tử n: 3
Nhập a[0] = 1
Nhập a[1] = 2
Nhập a[2] = 3
Dãy số vừa nhập: 1 2 3
Nhập giá trị x cần chèn: 5
Nhập vị trí k cần chèn (0 -> 3): 2
Dãy số sau khi chèn: 1 2 5 3
```
**Bài 2**
```text
Nhập số lượng nhân viên: 2
--- Nhập nhân viên thứ 1 ---
Mã nhân viên: 123
Họ và tên: Lan Anh
Năm sinh: 2000
Phòng ban: Kinh Doanh
Lương cơ bản: 4000000
Thưởng: 1200000
--- Nhập nhân viên thứ 2 ---
Mã nhân viên: 234
Họ và tên: Ngọc
Năm sinh: 2001
Phòng ban: IT
Lương cơ bản: 5000000
Thưởng: 2000000

a. Tổng thực lĩnh của tất cả nhân viên: 12200000

b. Danh sách nhân viên có lương cơ bản thấp nhất (4000000):
Mã: 123 | Tên: Lan Anh | Năm sinh: 2000 | Phòng: Kinh Doanh | Lương CB: 4000000 | Thưởng: 1200000

c. Số nhân viên có thưởng >= 1.200.000: 2

d. Danh sách sau khi sắp xếp theo phòng ban và mã NV:
Mã: 234 | Tên: Ngọc | Năm sinh: 2001 | Phòng: IT | Lương CB: 5000000 | Thưởng: 2000000
Mã: 123 | Tên: Lan Anh | Năm sinh: 2000 | Phòng: Kinh Doanh | Lương CB: 4000000 | Thưởng: 1200000

e. Danh sách sau khi tăng lương cơ bản lên 5%:
Mã: 234 | Tên: Ngọc | Năm sinh: 2001 | Phòng: IT | Lương CB: 5250000 | Thưởng: 2000000
Mã: 123 | Tên: Lan Anh | Năm sinh: 2000 | Phòng: Kinh Doanh | Lương CB: 4200000 | Thưởng: 1200000
```
**Bài 3**
```text
Nhập cấp ma trận vuông n: 2
a[0,0] = 1
a[0,1] = 2
a[1,0] = 3
a[1,1] = 4
a. Tổng tất cả phần tử ma trận: 10
b. Giá trị dương nhỏ nhất: 1
c. Tổng các phần tử trên đường chéo phụ: 5
d. Đường chéo chính tăng dần.
```
**Bài 4**
```text
Nhập số lượng phần tử cho DSLK: 5
Nhập phần tử thứ 1: 12
Nhập phần tử thứ 2: 34
Nhập phần tử thứ 3: 23
Nhập phần tử thứ 4: 56
Nhập phần tử thứ 5: 18
Danh sách hiện tại: 12 -> 34 -> 23 -> 56 -> 18 -> null
Nhập x cần đếm: 23
a. Có 1 phần tử bằng 23
b. Phần tử dương nhỏ nhất là: 12
Nhập giá trị cần xóa đầu tiên: 34
Đã xóa phần tử 34 đầu tiên!
Danh sách sau khi xóa: 12 -> 23 -> 56 -> 18 -> null
```
**Bài 5**
```text
Nhập số phần tử cho danh sách l: 2
Phần tử thứ 1: 18
Phần tử thứ 2: 20
a. Phần tử lớn nhất: 20
b. Tổng các phần tử: 38
c. Số lượng số nguyên tố: 0
d. Số âm: 0, Số 0: 0, Số dương: 2
Nhập x cần đếm: 20
e. Số lượng phần tử bằng 20: 1
f. Phần tử dương nhỏ nhất: 18
```
**Bài 7**
```text
Nhập số ngày n: 3
Nhập nhiệt độ ngày 1: 20
Nhập nhiệt độ ngày 2: 25
Nhập nhiệt độ ngày 3: 30
Ngày có nhiệt độ cao nhất: Ngày 3 (30 độ)
Ngày có nhiệt độ thấp nhất: Ngày 1 (20 độ)
Nhiệt độ trung bình: 25
```
**Bài 8**
```text
Nhập một chuỗi văn bản: Có con cá đang đi bơi
Tần suất xuất hiện các từ:
bơi: 1 lần
cá: 1 lần
có: 1 lần
con: 1 lần
đang: 1 lần
đi: 1 lần
```
**Bài 9**
```text
Nhập số lượng phần tử n: 5
a[0] = 1
a[1] = 6
a[2] = 9
a[3] = 7
a[4] = 10
Các số nguyên tố: 7
Các số chẵn: 6 10
Các số hoàn hảo: 6
```
**Bài 10**
```text
Nhập số dòng m: 4
Nhập số cột n: 4
a[0,0] = 12
a[0,1] = 22
a[0,2] = 16
a[0,3] = 8
a[1,0] = 19
a[1,1] = 7
a[1,2] = 18
a[1,3] = 11
a[2,0] = 0
a[2,1] = 2
a[2,2] = 3
a[2,3] = 5
a[3,0] = 6
a[3,1] = 78
a[3,2] = 9
a[3,3] = 09
In theo thứ tự xoắn ốc: 12 22 16 8 11 5 9 9 78 6 0 19 7 18 3 2
```
**Bài 11**
```text
Nhập cấp ma trận vuông n: 2
matrix[0,0] = 1
matrix[0,1] = 10
matrix[1,0] = 23
matrix[1,1] = 20
Ma trận đơn vị: Không
Ma trận đối xứng: Không
```
**Bài 12**
```text
Nhập số dòng m: 4
Nhập số cột n: 4
Nhập số lượng mìn: 3
Bảng Minesweeper (* là mìn):
* 1 1 1
1 1 1 *
1 1 2 1
1 * 1 0
```
**Bài 13**
```text
Nhập số phần tử: 2
Phần tử thứ 1: 45
Phần tử thứ 2: 55
Danh sách ban đầu: 45 -> 55 -> null
Danh sách sau khi đảo ngược: 55 -> 45 -> null
```
**Bài 14**
```text
Nhập số phần tử cho DS 1 (nhập tăng dần): 5
Phần tử 1: 12
Phần tử 2: 79
Phần tử 3: 76
Phần tử 4: 54
Phần tử 5: 19
Nhập số phần tử cho DS 2 (nhập tăng dần): 4
Phần tử 1: 1
Phần tử 2: 4
Phần tử 3: 6
Phần tử 4: 8
Danh sách sau khi gộp: 1 -> 4 -> 6 -> 8 -> 12 -> 79 -> 76 -> 54 -> 19 -> null
```
**Bài 15**
```text
Kiểm tra danh sách 2->3->4->5->6 (chưa nối vòng): Không có chu trình
Kiểm tra danh sách 2->3->4->5->6->2 (đã nối vòng): Có chu trình
```
**Bài 16**
```text
--- TRÌNH DUYỆT WEB ---
Trang hiện tại: google.com
1. Truy cập trang mới
2. Quay lại (Back)
3. Tiến tới (Forward)
0. Thoát Bài 16
Chọn: 1
Nhập địa chỉ web : github.com

--- TRÌNH DUYỆT WEB ---
Trang hiện tại: github.com
1. Truy cập trang mới
2. Quay lại (Back)
3. Tiến tới (Forward)
0. Thoát Bài 16
Chọn: 2

--- TRÌNH DUYỆT WEB ---
Trang hiện tại: google.com
1. Truy cập trang mới
2. Quay lại (Back)
3. Tiến tới (Forward)
0. Thoát Bài 16
Chọn: 3

--- TRÌNH DUYỆT WEB ---
Trang hiện tại: github.com
1. Truy cập trang mới
2. Quay lại (Back)
3. Tiến tới (Forward)
0. Thoát Bài 16
Chọn: 0
```
**Bài 17**
```text
--- PLAYLIST NHẠC ---
Bài hát đang phát: Chưa có bài nào
1. Thêm bài hát vào cuối playlist
2. Xóa bài hát theo tên
3. Bài tiếp theo (Next)
4. Bài trước đó (Previous)
5. Xem tất cả bài hát trong playlist
0. Thoát Bài 17
Chọn: 1
Nhập tên bài hát: Xương rồng
Đã thêm bài hát!

--- PLAYLIST NHẠC ---
Bài hát đang phát: Xương rồng
1. Thêm bài hát vào cuối playlist
2. Xóa bài hát theo tên
3. Bài tiếp theo (Next)
4. Bài trước đó (Previous)
5. Xem tất cả bài hát trong playlist
0. Thoát Bài 17
Chọn: 1
Nhập tên bài hát: Sau cơn mưa
Đã thêm bài hát!

--- PLAYLIST NHẠC ---
Bài hát đang phát: Xương rồng
1. Thêm bài hát vào cuối playlist
2. Xóa bài hát theo tên
3. Bài tiếp theo (Next)
4. Bài trước đó (Previous)
5. Xem tất cả bài hát trong playlist
0. Thoát Bài 17
Chọn: 3

--- PLAYLIST NHẠC ---
Bài hát đang phát: Sau cơn mưa
1. Thêm bài hát vào cuối playlist
2. Xóa bài hát theo tên
3. Bài tiếp theo (Next)
4. Bài trước đó (Previous)
5. Xem tất cả bài hát trong playlist
0. Thoát Bài 17
Chọn: 4

--- PLAYLIST NHẠC ---
Bài hát đang phát: Xương rồng
1. Thêm bài hát vào cuối playlist
2. Xóa bài hát theo tên
3. Bài tiếp theo (Next)
4. Bài trước đó (Previous)
5. Xem tất cả bài hát trong playlist
0. Thoát Bài 17
Chọn: 5
Danh sách nhạc: Xương rồng <-> Sau cơn mưa <-> null

--- PLAYLIST NHẠC ---
Bài hát đang phát: Xương rồng
1. Thêm bài hát vào cuối playlist
2. Xóa bài hát theo tên
3. Bài tiếp theo (Next)
4. Bài trước đó (Previous)
5. Xem tất cả bài hát trong playlist
0. Thoát Bài 17
Chọn: 0
```
**Bài 18**
```text
--- QUẢN LÝ ĐƠN HÀNG [DH02 - Na ] ---
Trạng thái hiện tại: Chờ xử lý
1. Chuyển sang trạng thái tiếp theo
2. Quay lại trạng thái trước đó
0. Thoát Bài 18
Chọn: 1
Đã cập nhật trạng thái!

--- QUẢN LÝ ĐƠN HÀNG [DH02 - Na ] ---
Trạng thái hiện tại: Đang giao
1. Chuyển sang trạng thái tiếp theo
2. Quay lại trạng thái trước đó
0. Thoát Bài 18
```

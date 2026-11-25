# Buổi 03 – NGĂN XẾP VÀ HÀNG ĐỢI 

Họ tên: Nguyễn Thị Lan Phương · MSV: 12425048

## Bài đã làm
**Bài tập chương 4**:  Bài 1, Bài 2, Bài 3, Bài 4, Bài 5, Bài 6<br>
**Bài tập tự thực hành cuối sách**: Bài 4, Bài 5, Bài 6, Bài 7, Bài 8, Bài 9, Bài 10, Bài 11
## Cách Làm
dotnet run --project Buoi03_Stack_Queue
## Kết quả chạy
**MENU**
```text
================ MENU NGĂN XẾP VÀ HÀNG ĐỢI ================
1.   Bài 1: Kiểm tra tính đúng đắn biểu thức ");
2.   Bài 2: Mô phỏng lịch sử trình duyệt web "
3.   Bài 3: Mô phỏng gọi hàm - Function Call Stack");
4.   Bài 4: Mô phỏng hệ thống in ấn ");
5.   Bài 5: Mô phỏng đường truyền dữ liệu ");
6.   Bài 6: Mô phỏng quản lý hàng đợi tại TTDVKH hoặc KH ");
4.1. Bài 4.1:   Mô phỏng lịch sử trình duyệt ")
5.1. Bài 5.1:   Kiểm tra chuỗi ngoặc () đúng");
6.1. Bài 6.1:   Mô phỏng hệ thống in");
7.   Bài 7: Mô phỏng đường truyền dữ liệu");
8.   Bài 8: Mô phỏng Dịch vụ Khách hàng ");
9.   Bài 9: Tính giá trị biểu thức hậu tố ");
10.  Bài 10: Kiểm tra tính hợp lệ biểu thức trung tố");
11.  Bài 11: Tính giá trị biểu thức trung tố ");
0. Thoát chương trình
Nhập bài muốn chạy:
```
**Bài 1**
```text
Nhập biểu thức toán học: (12 + 12)*12)
=> KẾT QUẢ: Biểu thức KHÔNG HỢP LỆ.
```
**Bài 2**
```text
Trang hiện tại: [Trang chủ (google.com)]
1. Truy cập trang mới
2. Nhấn Back (Quay lại)
3. Nhấn Forward (Chuyển tiếp)
0. Quay lại Menu chính
Chọn thao tác: 1
Nhập địa chỉ web mới: tiktok.com

--- BÀI 2: TRÌNH DUYỆT WEB ---
Trang hiện tại: [tiktok.com]
1. Truy cập trang mới
2. Nhấn Back (Quay lại)
3. Nhấn Forward (Chuyển tiếp)
0. Quay lại Menu chính
Chọn thao tác: 2

--- BÀI 2: TRÌNH DUYỆT WEB ---
Trang hiện tại: [Trang chủ (google.com)]
1. Truy cập trang mới
2. Nhấn Back (Quay lại)
3. Nhấn Forward (Chuyển tiếp)
0. Quay lại Menu chính
Chọn thao tác: 3

--- BÀI 2: TRÌNH DUYỆT WEB ---
Trang hiện tại: [tiktok.com]
1. Truy cập trang mới
2. Nhấn Back (Quay lại)
3. Nhấn Forward (Chuyển tiếp)
0. Quay lại Menu chính
Chọn thao tác: 0
```
**Bài 3**
```text
--- BÀI 3: FUNCTION CALL STACK ---
Trạng thái Call Stack hiện tại (Đỉnh -> Đáy):
   [Trống - Không có hàm nào đang chạy]

1. Gọi hàm mới (Push Frame)
2. Kết thúc hàm hiện tại (Pop Frame)
0. Quay lại Menu chính
Chọn thao tác: 1
Tên hàm (VD: TinhTong): TinhTong
Tham số truyền vào (VD: a=5, b=10): a=5, b= 10
=> Đã gọi hàm [TinhTong].

--- BÀI 3: FUNCTION CALL STACK ---
Trạng thái Call Stack hiện tại (Đỉnh -> Đáy):
   -> Hàm: TinhTong | Tham số: a=5, b= 10  | Địa chỉ trả về: 0x6344

1. Gọi hàm mới (Push Frame)
2. Kết thúc hàm hiện tại (Pop Frame)
0. Quay lại Menu chính
Chọn thao tác: 2
=> Hàm [TinhTong] đã thực thi xong và trả về địa chỉ 0x6344.

--- BÀI 3: FUNCTION CALL STACK ---
Trạng thái Call Stack hiện tại (Đỉnh -> Đáy):
   [Trống - Không có hàm nào đang chạy]

1. Gọi hàm mới (Push Frame)
2. Kết thúc hàm hiện tại (Pop Frame)
0. Quay lại Menu chính
Chọn thao tác: 0
```
**Bài 4**
```text
--- BÀI 4: HỆ THỐNG IN ẤN ---
Số tài liệu đang chờ in: 0
1. Thêm yêu cầu in mới (Enqueue)
2. Thực hiện in tài liệu tiếp theo
3. Xem danh sách đang chờ
0. Quay lại Menu chính
Chọn thao tác: 1
Nhập tên tài liệu cần in: TIẾNG ANH
=> Đã thêm 'TIẾNG ANH' vào hàng đợi in.

--- BÀI 4: HỆ THỐNG IN ẤN ---
Số tài liệu đang chờ in: 1
1. Thêm yêu cầu in mới (Enqueue)
2. Thực hiện in tài liệu tiếp theo
3. Xem danh sách đang chờ
0. Quay lại Menu chính
Chọn thao tác: 2
=> ĐANG IN TÀI LIỆU: 'TIẾNG ANH' ... Hoàn tất!

--- BÀI 4: HỆ THỐNG IN ẤN ---
Số tài liệu đang chờ in: 0
1. Thêm yêu cầu in mới (Enqueue)
2. Thực hiện in tài liệu tiếp theo
3. Xem danh sách đang chờ
0. Quay lại Menu chính
Chọn thao tác: 3
Hàng đợi trống.

--- BÀI 4: HỆ THỐNG IN ẤN ---
Số tài liệu đang chờ in: 0
1. Thêm yêu cầu in mới (Enqueue)
2. Thực hiện in tài liệu tiếp theo
3. Xem danh sách đang chờ
0. Quay lại Menu chính
Chọn thao tác: 0
```
**Bài 5**
```text
--- BÀI 5: ĐƯỜNG TRUYỀN DỮ LIỆU MẠNG ---
Gói tin trên đường truyền: 0
1. Gửi gói tin mới
2. Xử lý gói tin ở đầu hàng đợi
0. Quay lại Menu chính
Chọn thao tác: 1
Nhập nội dung gói tin: Hello
=> Đã đưa gói tin [Hello] lên đường truyền.

--- BÀI 5: ĐƯỜNG TRUYỀN DỮ LIỆU MẠNG ---
Gói tin trên đường truyền: 1
1. Gửi gói tin mới
2. Xử lý gói tin ở đầu hàng đợi
0. Quay lại Menu chính
Chọn thao tác: 1
Nhập nội dung gói tin: Hi
=> Đã đưa gói tin [Hi] lên đường truyền.

--- BÀI 5: ĐƯỜNG TRUYỀN DỮ LIỆU MẠNG ---
Gói tin trên đường truyền: 2
1. Gửi gói tin mới
2. Xử lý gói tin ở đầu hàng đợi
0. Quay lại Menu chính
Chọn thao tác: 2
Đang truyền tải...
[THÀNH CÔNG] Đã nhận gói tin: [Hello]

--- BÀI 5: ĐƯỜNG TRUYỀN DỮ LIỆU MẠNG ---
Gói tin trên đường truyền: 1
1. Gửi gói tin mới
2. Xử lý gói tin ở đầu hàng đợi
0. Quay lại Menu chính
Chọn thao tác: 2
Đang truyền tải...
[THÀNH CÔNG] Đã nhận gói tin: [Hi]

--- BÀI 5: ĐƯỜNG TRUYỀN DỮ LIỆU MẠNG ---
Gói tin trên đường truyền: 0
1. Gửi gói tin mới
2. Xử lý gói tin ở đầu hàng đợi
0. Quay lại Menu chính
Chọn thao tác: 0
```
**Bài 6**
```text
--- BÀI 6: Mô phỏng quản lý hàng đợi tại TTDVKH hoặc KH---
Số khách đang chờ: 0
1. Khách hàng mới lấy số
2. Nhân viên gọi khách tiếp theo
3. Hiển thị hàng đợi
0. Quay lại Menu chính
Chọn: 1
Tên khách hàng: Mai
Dịch vụ: Gửi tiền
Khách hàng Mai đã vào hàng đợi.

--- BÀI 6: Mô phỏng quản lý hàng đợi tại TTDVKH hoặc KH---
Số khách đang chờ: 1
1. Khách hàng mới lấy số
2. Nhân viên gọi khách tiếp theo
3. Hiển thị hàng đợi
0. Quay lại Menu chính
Chọn: 1
Tên khách hàng: Khang
Dịch vụ: Chăm sóc sức khỏa
Khách hàng Khang đã vào hàng đợi.

--- BÀI 6: Mô phỏng quản lý hàng đợi tại TTDVKH hoặc KH---
Số khách đang chờ: 2
1. Khách hàng mới lấy số
2. Nhân viên gọi khách tiếp theo
3. Hiển thị hàng đợi
0. Quay lại Menu chính
Chọn: 2
Mời khách hàng: Mai (Gửi tiền)

--- BÀI 6: Mô phỏng quản lý hàng đợi tại TTDVKH hoặc KH---
Số khách đang chờ: 1
1. Khách hàng mới lấy số
2. Nhân viên gọi khách tiếp theo
3. Hiển thị hàng đợi
0. Quay lại Menu chính
Chọn: 3
   1. [21:31:03] Khang - Chăm sóc sức khỏa

--- BÀI 6: Mô phỏng quản lý hàng đợi tại TTDVKH hoặc KH---
Số khách đang chờ: 1
1. Khách hàng mới lấy số
2. Nhân viên gọi khách tiếp theo
3. Hiển thị hàng đợi
0. Quay lại Menu chính
Chọn: 0
```
**Bài 4.1**
```text
=== BÀI 4.1: MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 1
Nhập URL: https://github.com
Đang truy cập: https://github.com
Chọn: 2
Không thể quay lại!
Chọn: 3
Không thể tiến lên!
Chọn: 4
Trang hiện tại: https://github.com
Chọn: 0
```
**Bài 5.1**
```text
--- BÀI 5.1: KIỂM TRA CHUỖI NGOẶC () ĐÚNG ---
Nhập chuỗi chỉ chứa ký tự '(' và ')': ()()()()()
=> Xâu đúng
```
**Bài 6.1**
```text
--- BÀI 6: Mô phỏng quản lý hàng đợi tại TTDVKH hoặc KH---
Số khách đang chờ: 1
1. Khách hàng mới lấy số
2. Nhân viên gọi khách tiếp theo
3. Hiển thị hàng đợi
0. Quay lại Menu chính
Chọn: 1
Tên khách hàng: Khang
Dịch vụ: Chăm sóc sức khỏa

--- BÀI 6.1: MÔ PHỎNG HỆ THỐNG IN ---
1. Thêm một yêu cầu in mới
2. Xử lý (in) một yêu cầu trong hàng đợi
3. Hiển thị danh sách các yêu cầu còn lại
0. Quay lại Menu chính
Chọn: 1
Nhập tên tài liệu in: Toán
Đã thêm tài liệu 'Toán' vào hàng đợi.

--- BÀI 6.1: MÔ PHỎNG HỆ THỐNG IN ---
1. Thêm một yêu cầu in mới
2. Xử lý (in) một yêu cầu trong hàng đợi
3. Hiển thị danh sách các yêu cầu còn lại
0. Quay lại Menu chính
Chọn: 1
Nhập tên tài liệu in: Tin
Đã thêm tài liệu 'Tin' vào hàng đợi.

--- BÀI 6.1: MÔ PHỎNG HỆ THỐNG IN ---
1. Thêm một yêu cầu in mới
2. Xử lý (in) một yêu cầu trong hàng đợi
3. Hiển thị danh sách các yêu cầu còn lại
0. Quay lại Menu chính
Chọn: 2
Đang xử lý in tài liệu: Toán

--- BÀI 6.1: MÔ PHỎNG HỆ THỐNG IN ---
1. Thêm một yêu cầu in mới
2. Xử lý (in) một yêu cầu trong hàng đợi
3. Hiển thị danh sách các yêu cầu còn lại
0. Quay lại Menu chính
Chọn: 3
Danh sách chờ: Tin

--- BÀI 6.1: MÔ PHỎNG HỆ THỐNG IN ---
1. Thêm một yêu cầu in mới
2. Xử lý (in) một yêu cầu trong hàng đợi
3. Hiển thị danh sách các yêu cầu còn lại
0. Quay lại Menu chính
Chọn: 0
```
**Bài 7**
```text
--- BÀI 7: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU ---
1. Gửi dữ liệu (Thêm gói tin)
2. Nhận dữ liệu (Xử lý gói tin đầu)
3. Hiển thị danh sách các gói dữ liệu trong hàng đợi
0. Quay lại Menu chính
Chọn: 1
Nhập gói dữ liệu (chuỗi hoặc số): 1 2 3 4 5 6 7 8 9
Đã gửi gói dữ liệu: 1 2 3 4 5 6 7 8 9

--- BÀI 7: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU ---
1. Gửi dữ liệu (Thêm gói tin)
2. Nhận dữ liệu (Xử lý gói tin đầu)
3. Hiển thị danh sách các gói dữ liệu trong hàng đợi
0. Quay lại Menu chính
Chọn: 3
Danh sách gói dữ liệu: 1 2 3 4 5 6 7 8 9

--- BÀI 7: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU ---
1. Gửi dữ liệu (Thêm gói tin)
2. Nhận dữ liệu (Xử lý gói tin đầu)
3. Hiển thị danh sách các gói dữ liệu trong hàng đợi
0. Quay lại Menu chính
Chọn: 2
Đã nhận và xử lý dữ liệu: 1 2 3 4 5 6 7 8 9

--- BÀI 7: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU ---
1. Gửi dữ liệu (Thêm gói tin)
2. Nhận dữ liệu (Xử lý gói tin đầu)
3. Hiển thị danh sách các gói dữ liệu trong hàng đợi
0. Quay lại Menu chính
Chọn: 0
```
**Bài 8**
```text
--- BÀI 8: MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG ---
1. Thêm khách hàng mới vào hàng đợi
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Quay lại Menu chính
Chọn: 1
Nhập tên hoặc số thứ tự khách hàng: Nana
Khách hàng 'Nana' đã vào hàng đợi.

--- BÀI 8: MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG ---
1. Thêm khách hàng mới vào hàng đợi
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Quay lại Menu chính
Chọn: 1
Nhập tên hoặc số thứ tự khách hàng: My
Khách hàng 'My' đã vào hàng đợi.

--- BÀI 8: MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG ---
1. Thêm khách hàng mới vào hàng đợi
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Quay lại Menu chính
Chọn: 2
Đang phục vụ khách hàng: Nana

--- BÀI 8: MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG ---
1. Thêm khách hàng mới vào hàng đợi
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Quay lại Menu chính
Chọn: 3
Danh sách chờ: My

--- BÀI 8: MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG ---
1. Thêm khách hàng mới vào hàng đợi
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Quay lại Menu chính
Chọn: 0
```
**Bài 9**
```text
--- BÀI 9: TÍNH GIÁ TRỊ BIỂU THỨC HẬU TỐ ---
Nhập biểu thức hậu tố : 3 2 4 * +
=> Kết quả biểu thức hậu tố = 11
```
**Bài 10**
```text
--- BÀI 10: KIỂM TRA TÍNH HỢP LỆ CỦA BIỂU THỨC TRUNG TỐ ---
Nhập công thức toán học trung tố: 12 + 12 *
=> Biểu thức không hợp lệ
```
**Bài 11**
```text
--- BÀI 11: TÍNH GIÁ TRỊ BIỂU THỨC TRUNG TỐ ---
Nhập biểu thức trung tố : 3 + 5 * ( 2 - 4 )
=> Biểu thức hậu tố (Postfix): 3 5 2 4 - * +
=> Kết quả cuối cùng = -7
```

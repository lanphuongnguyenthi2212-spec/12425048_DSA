using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi02_DanhSach
{
    // --- Khai báo kiểu dữ liệu cho Bài 2 ---
    struct NhanVien
    {
        public string MaNV;
        public string Hoten;
        public int Namsinh;
        public string Phongban;
        public int LuongCB;
        public int Thuong;
    }

    // --- Khai báo Node cho Danh sách liên kết đơn (Bài 4, 5, 13, 14, 15) ---
    class Node
    {
        public int data;
        public Node next;

        public Node(int x)
        {
            data = x;
            next = null;
        }
    }

    // --- Khai báo Node cho Danh sách liên kết kép (Bài 16 - Lịch sử web) ---
    class WebNode
    {
        public string url;
        public WebNode prev;
        public WebNode next;

        public WebNode(string u)
        {
            url = u;
            prev = null;
            next = null;
        }
    }

    // --- Khai báo Node cho Danh sách liên kết kép (Bài 17 - Playlist nhạc) ---
    class BaiHatNode
    {
        public string tenBaiHat;
        public BaiHatNode prev;
        public BaiHatNode next;

        public BaiHatNode(string ten)
        {
            tenBaiHat = ten;
            prev = null;
            next = null;
        }
    }

    // --- Khai báo Node cho Danh sách liên kết kép (Bài 18 - Trạng thái đơn hàng) ---
    class TrangThaiNode
    {
        public string tenTrangThai;
        public TrangThaiNode prev;
        public TrangThaiNode next;

        public TrangThaiNode(string tt)
        {
            tenTrangThai = tt;
            prev = null;
            next = null;
        }
    }

    class Program
    {
        // Biến toàn cục cho Bài 2
        static NhanVien[] DS;

        // Biến toàn cục cho Bài 4 và Bài 5
        static Node pHead = null;
        static Node l = null;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int chon;
            do
            {
                Console.WriteLine("\n================ MENU MẢNG VÀ DANH SÁCH LIÊN KẾT ================");
                Console.WriteLine("1.  Mảng 1 chiều ");
                Console.WriteLine("2.  Quản lý danh sách nhân viên ");
                Console.WriteLine("3.  Ma trận vuông ");
                Console.WriteLine("4.  Danh sách liên kết đơn pHead ");
                Console.WriteLine("5.  Danh sách liên kết đơn l ");
                Console.WriteLine("7.  Quản lý nhiệt độ n ngày");
                Console.WriteLine("8.  Thống kê tần suất từ trong chuỗi");
                Console.WriteLine("9.  Xử lý dãy số nguyên ");
                Console.WriteLine("10. In ma trận theo thứ tự xoắn ốc");
                Console.WriteLine("11. Kiểm tra ma trận đơn vị, ma trận đối xứng");
                Console.WriteLine("12. Game Minesweeper (Đếm mìn xung quanh)");
                Console.WriteLine("13. Đảo ngược danh sách liên kết đơn");
                Console.WriteLine("14. Gộp hai danh sách liên kết đã sắp xếp");
                Console.WriteLine("15. Phát hiện chu trình ");
                Console.WriteLine("16. Lịch sử duyệt web ");
                Console.WriteLine("17. Playlist nhạc ");
                Console.WriteLine("18. Hệ thống đặt hàng");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("Nhập bài muốn chạy: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1: Bai1(); break;
                    case 2: Bai2(); break;
                    case 3: Bai3(); break;
                    case 4: Bai4(); break;
                    case 5: Bai5(); break;
                    case 7: Bai7(); break;
                    case 8: Bai8(); break;
                    case 9: Bai9(); break;
                    case 10: Bai10(); break;
                    case 11: Bai11(); break;
                    case 12: Bai12(); break;
                    case 13: Bai13(); break;
                    case 14: Bai14(); break;
                    case 15: Bai15(); break;
                    case 16: Bai16(); break;
                    case 17: Bai17(); break;
                    case 18: Bai18(); break;
                    case 0: Console.WriteLine("Đã thoát!"); break;
                    default: Console.WriteLine("Chọn sai, vui lòng nhập lại!"); break;
                }
            } while (chon != 0);
        }

        // =====================================================================
        // BÀI TẬP 1: Mảng 1 chiều
        // =====================================================================
        static void Bai1()
        {
            Console.Write("Nhập số lượng phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            // a. Nhập từ bàn phím
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            // b. Hiển thị danh sách
            Console.Write("Dãy số vừa nhập: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            // c. Chèn phần tử x vào vị trí k
            Console.Write("Nhập giá trị x cần chèn: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập vị trí k cần chèn (0 -> {0}): ", a.Length);
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k > a.Length)
            {
                Console.WriteLine("Vị trí k không hợp lệ!");
                return;
            }

            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i < k; i++)
            {
                tmp[i] = a[i];
            }
            tmp[k] = x;
            for (int i = k; i < a.Length; i++)
            {
                tmp[i + 1] = a[i];
            }
            a = tmp;

            Console.Write("Dãy số sau khi chèn: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        // =====================================================================
        // BÀI TẬP 2: Quản lý nhân viên
        // =====================================================================
        static int ThucLinh(int x)
        {
            return DS[x].LuongCB + DS[x].Thuong;
        }

        static void InMotNV(NhanVien nv)
        {
            Console.WriteLine("Mã: {0} | Tên: {1} | Năm sinh: {2} | Phòng: {3} | Lương CB: {4} | Thưởng: {5}",
                nv.MaNV, nv.Hoten, nv.Namsinh, nv.Phongban, nv.LuongCB, nv.Thuong);
        }

        static void Bai2()
        {
            Console.Write("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            DS = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--- Nhập nhân viên thứ {0} ---", i + 1);
                Console.Write("Mã nhân viên: ");
                DS[i].MaNV = Console.ReadLine();
                Console.Write("Họ và tên: ");
                DS[i].Hoten = Console.ReadLine();
                Console.Write("Năm sinh: ");
                DS[i].Namsinh = int.Parse(Console.ReadLine());
                Console.Write("Phòng ban: ");
                DS[i].Phongban = Console.ReadLine();
                Console.Write("Lương cơ bản: ");
                DS[i].LuongCB = int.Parse(Console.ReadLine());
                Console.Write("Thưởng: ");
                DS[i].Thuong = int.Parse(Console.ReadLine());
            }

            // a. Tính tổng thực lĩnh tháng
            int tongThucLinh = 0;
            for (int i = 0; i < n; i++)
            {
                tongThucLinh += ThucLinh(i);
            }
            Console.WriteLine("\na. Tổng thực lĩnh của tất cả nhân viên: " + tongThucLinh);

            // b. In danh sách nhân viên có mức lương cơ bản thấp nhất
            int minLuong = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (minLuong > DS[i].LuongCB)
                {
                    minLuong = DS[i].LuongCB;
                }
            }
            Console.WriteLine("\nb. Danh sách nhân viên có lương cơ bản thấp nhất ({0}):", minLuong);
            for (int i = 0; i < n; i++)
            {
                if (DS[i].LuongCB == minLuong)
                {
                    InMotNV(DS[i]);
                }
            }

            // c. Đếm số lượng nhân viên có mức thưởng >= 1200000
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (DS[i].Thuong >= 1200000)
                {
                    dem++;
                }
            }
            Console.WriteLine("\nc. Số nhân viên có thưởng >= 1.200.000: " + dem);

            // d. Sắp xếp tăng dần theo phòng ban, trùng thì giảm dần theo mã nhân viên
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int ssPhong = string.Compare(DS[i].Phongban, DS[j].Phongban);
                    if (ssPhong > 0 || (ssPhong == 0 && string.Compare(DS[i].MaNV, DS[j].MaNV) < 0))
                    {
                        NhanVien tam = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tam;
                    }
                }
            }
            Console.WriteLine("\nd. Danh sách sau khi sắp xếp theo phòng ban và mã NV:");
            for (int i = 0; i < n; i++)
            {
                InMotNV(DS[i]);
            }

            // e. Cập nhật tăng lương cơ bản lên 5% và in ra
            Console.WriteLine("\ne. Danh sách sau khi tăng lương cơ bản lên 5%:");
            for (int i = 0; i < n; i++)
            {
                DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
                InMotNV(DS[i]);
            }
        }

        // =====================================================================
        // BÀI TẬP 3: Ma trận vuông cấp n
        // =====================================================================
        static int TongMaTran(int[,] a, int n)
        {
            int t = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    t += a[i, j];
            return t;
        }

        static int MinDuongMaTran(int[,] a, int n)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < min && a[i, j] > 0)
                        min = a[i, j];
                }
            }
            return min;
        }

        static int TongCheoPhu(int[,] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == (n - 1) - i)
                        tong += a[i, j];
                }
            }
            return tong;
        }

        static bool KiemTraCheoChinhTang(int[,] a, int n)
        {
            int[] tg = new int[n];
            for (int i = 0; i < n; i++)
            {
                tg[i] = a[i, i];
            }

            for (int i = 0; i <= n - 2; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (tg[i] >= tg[j])
                        return false;
                }
            }
            return true;
        }

        static void Bai3()
        {
            Console.Write("Nhập cấp ma trận vuông n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("a. Tổng tất cả phần tử ma trận: " + TongMaTran(a, n));
            int minD = MinDuongMaTran(a, n);
            if (minD == int.MaxValue)
                Console.WriteLine("b. Ma trận không có số dương.");
            else
                Console.WriteLine("b. Giá trị dương nhỏ nhất: " + minD);

            Console.WriteLine("c. Tổng các phần tử trên đường chéo phụ: " + TongCheoPhu(a, n));
            if (KiemTraCheoChinhTang(a, n))
                Console.WriteLine("d. Đường chéo chính tăng dần.");
            else
                Console.WriteLine("d. Đường chéo chính KHÔNG tăng dần.");
        }

        // =====================================================================
        // BÀI TẬP 4: Danh sách liên kết đơn pHead
        // =====================================================================
        static void ThemCuoiPHead(int x)
        {
            Node moi = new Node(x);
            if (pHead == null)
            {
                pHead = moi;
                return;
            }
            Node p = pHead;
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = moi;
        }

        static void InDanhSach(Node head)
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.data + " -> ");
                p = p.next;
            }
            Console.WriteLine("null");
        }

        static void XoaDauTienX(int x)
        {
            Node p = pHead;
            Node t = null;

            while (p != null && p.data != x)
            {
                t = p;
                p = p.next;
            }

            if (p == null)
            {
                Console.WriteLine("Không tìm thấy giá trị {0} để xóa.", x);
                return;
            }

            if (p == pHead)
            {
                pHead = pHead.next;
            }
            else
            {
                t.next = p.next;
            }
            Console.WriteLine("Đã xóa phần tử {0} đầu tiên!", x);
        }

        static void Bai4()
        {
            pHead = null;
            Console.Write("Nhập số lượng phần tử cho DSLK: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                int val = int.Parse(Console.ReadLine());
                ThemCuoiPHead(val);
            }

            Console.Write("Danh sách hiện tại: ");
            InDanhSach(pHead);

            Console.Write("Nhập x cần đếm: ");
            int x = int.Parse(Console.ReadLine());
            int d = 0;
            Node p = pHead;
            while (p != null)
            {
                if (p.data == x) d++;
                p = p.next;
            }
            Console.WriteLine("a. Có {0} phần tử bằng {1}", d, x);

            int minduong = int.MaxValue;
            p = pHead;
            while (p != null)
            {
                if (p.data > 0 && p.data < minduong)
                    minduong = p.data;
                p = p.next;
            }
            if (minduong == int.MaxValue)
                Console.WriteLine("b. Không có số dương trong danh sách.");
            else
                Console.WriteLine("b. Phần tử dương nhỏ nhất là: " + minduong);

            Console.Write("Nhập giá trị cần xóa đầu tiên: ");
            int xoa = int.Parse(Console.ReadLine());
            XoaDauTienX(xoa);
            Console.Write("Danh sách sau khi xóa: ");
            InDanhSach(pHead);
        }

        // =====================================================================
        // BÀI TẬP 5: Danh sách liên kết đơn l
        // =====================================================================
        static bool KTNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        static void ThemCuoiL(int x)
        {
            Node moi = new Node(x);
            if (l == null)
            {
                l = moi;
                return;
            }
            Node p = l;
            while (p.next != null) p = p.next;
            p.next = moi;
        }

        static void Bai5()
        {
            l = null;
            Console.Write("Nhập số phần tử cho danh sách l: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử thứ {0}: ", i + 1);
                ThemCuoiL(int.Parse(Console.ReadLine()));
            }

            int max = int.MinValue;
            Node p = l;
            while (p != null)
            {
                if (p.data > max) max = p.data;
                p = p.next;
            }
            Console.WriteLine("a. Phần tử lớn nhất: " + max);

            int t = 0;
            p = l;
            while (p != null)
            {
                t += p.data;
                p = p.next;
            }
            Console.WriteLine("b. Tổng các phần tử: " + t);

            int demNT = 0;
            p = l;
            while (p != null)
            {
                if (KTNT(p.data)) demNT++;
                p = p.next;
            }
            Console.WriteLine("c. Số lượng số nguyên tố: " + demNT);

            int demAm = 0, dem0 = 0, demDuong = 0;
            p = l;
            while (p != null)
            {
                if (p.data < 0) demAm++;
                else if (p.data > 0) demDuong++;
                else dem0++;
                p = p.next;
            }
            Console.WriteLine("d. Số âm: {0}, Số 0: {1}, Số dương: {2}", demAm, dem0, demDuong);

            Console.Write("Nhập x cần đếm: ");
            int x = int.Parse(Console.ReadLine());
            int demX = 0;
            p = l;
            while (p != null)
            {
                if (p.data == x) demX++;
                p = p.next;
            }
            Console.WriteLine("e. Số lượng phần tử bằng {0}: {1}", x, demX);

            int minduong = int.MaxValue;
            p = l;
            while (p != null)
            {
                if (p.data > 0 && p.data < minduong) minduong = p.data;
                p = p.next;
            }
            if (minduong == int.MaxValue)
                Console.WriteLine("f. Không có số dương.");
            else
                Console.WriteLine("f. Phần tử dương nhỏ nhất: " + minduong);
        }

        // =====================================================================
        // BÀI TẬP 7: Quản lý nhiệt độ
        // =====================================================================
        static void Bai7()
        {
            Console.Write("Nhập số ngày n: ");
            int n = int.Parse(Console.ReadLine());
            double[] nhietDo = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập nhiệt độ ngày {0}: ", i + 1);
                nhietDo[i] = double.Parse(Console.ReadLine());
            }

            double max = nhietDo[0], min = nhietDo[0], tong = 0;
            int ngayMax = 1, ngayMin = 1;

            for (int i = 0; i < n; i++)
            {
                tong += nhietDo[i];
                if (nhietDo[i] > max)
                {
                    max = nhietDo[i];
                    ngayMax = i + 1;
                }
                if (nhietDo[i] < min)
                {
                    min = nhietDo[i];
                    ngayMin = i + 1;
                }
            }

            double tb = tong / n;
            Console.WriteLine("Ngày có nhiệt độ cao nhất: Ngày {0} ({1} độ)", ngayMax, max);
            Console.WriteLine("Ngày có nhiệt độ thấp nhất: Ngày {0} ({1} độ)", ngayMin, min);
            Console.WriteLine("Nhiệt độ trung bình: " + Math.Round(tb, 2));
        }

        // =====================================================================
        // BÀI TẬP 8: Thống kê từ
        // =====================================================================
        static void Bai8()
        {
            Console.Write("Nhập một chuỗi văn bản: ");
            string s = Console.ReadLine().ToLower();

            char[] kyTuBo = { '.', ',', '!', '?', ';', ':', '-', '(', ')', '"' };
            foreach (char c in kyTuBo)
            {
                s = s.Replace(c.ToString(), "");
            }

            string[] mangTu = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> demTu = new Dictionary<string, int>();

            foreach (string tu in mangTu)
            {
                if (demTu.ContainsKey(tu))
                    demTu[tu]++;
                else
                    demTu[tu] = 1;
            }

            List<string> dsTu = new List<string>(demTu.Keys);
            dsTu.Sort();

            Console.WriteLine("Tần suất xuất hiện các từ:");
            foreach (string tu in dsTu)
            {
                Console.WriteLine("{0}: {1} lần", tu, demTu[tu]);
            }
        }

        // =====================================================================
        // BÀI TẬP 9: Xử lý số nguyên (SNT, số chẵn, số hoàn hảo)
        // =====================================================================
        static bool LaSoHoanHao(int n)
        {
            if (n <= 1) return false;
            int tongUoc = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0) tongUoc += i;
            }
            return tongUoc == n;
        }

        static void Bai9()
        {
            Console.Write("Nhập số lượng phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Các số nguyên tố: ");
            for (int i = 0; i < n; i++)
                if (KTNT(a[i])) Console.Write(a[i] + " ");

            Console.Write("\nCác số chẵn: ");
            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 0) Console.Write(a[i] + " ");

            Console.Write("\nCác số hoàn hảo: ");
            for (int i = 0; i < n; i++)
                if (LaSoHoanHao(a[i])) Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        // =====================================================================
        // BÀI TẬP 10: Ma trận xoắn ốc
        // =====================================================================
        static void Bai10()
        {
            Console.Write("Nhập số dòng m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            int top = 0, bottom = m - 1, left = 0, right = n - 1;
            Console.Write("In theo thứ tự xoắn ốc: ");

            while (top <= bottom && left <= right)
            {
                // Trái -> phải
                for (int i = left; i <= right; i++)
                    Console.Write(a[top, i] + " ");
                top++;

                // Trên -> dưới
                for (int i = top; i <= bottom; i++)
                    Console.Write(a[i, right] + " ");
                right--;

                // Phải -> trái
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                        Console.Write(a[bottom, i] + " ");
                    bottom--;
                }

                // Dưới -> trên
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                        Console.Write(a[i, left] + " ");
                    left++;
                }
            }
            Console.WriteLine();
        }

        // =====================================================================
        // BÀI TẬP 11: Ma trận đặc biệt (Đơn vị, đối xứng)
        // =====================================================================
        static void Bai11()
        {
            Console.Write("Nhập cấp ma trận vuông n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[{0},{1}] = ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }

            bool laDonVi = true;
            bool laDoiXung = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && matrix[i, j] != 1) laDonVi = false;
                    if (i != j && matrix[i, j] != 0) laDonVi = false;
                    if (matrix[i, j] != matrix[j, i]) laDoiXung = false;
                }
            }

            Console.WriteLine("Ma trận đơn vị: " + (laDonVi ? "Có" : "Không"));
            Console.WriteLine("Ma trận đối xứng: " + (laDoiXung ? "Có" : "Không"));
        }

        // =====================================================================
        // BÀI TẬP 12: Game Minesweeper
        // =====================================================================
        static void Bai12()
        {
            Console.Write("Nhập số dòng m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng mìn: ");
            int soMin = int.Parse(Console.ReadLine());

            int[,] banCo = new int[m, n]; // -1 là có mìn
            Random rd = new Random();
            int daDat = 0;

            while (daDat < soMin && daDat < m * n)
            {
                int r = rd.Next(0, m);
                int c = rd.Next(0, n);
                if (banCo[r, c] != -1)
                {
                    banCo[r, c] = -1;
                    daDat++;
                }
            }

            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (banCo[i, j] == -1) continue;
                    int dem = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int ni = i + dx[k];
                        int nj = j + dy[k];
                        if (ni >= 0 && ni < m && nj >= 0 && nj < n && banCo[ni, nj] == -1)
                            dem++;
                    }
                    banCo[i, j] = dem;
                }
            }

            Console.WriteLine("Bảng Minesweeper (* là mìn):");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (banCo[i, j] == -1)
                        Console.Write("* ");
                    else
                        Console.Write(banCo[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // =====================================================================
        // BÀI TẬP 13: Đảo ngược danh sách liên kết đơn (không đệ quy)
        // =====================================================================
        static void Bai13()
        {
            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            Node head = null, tail = null;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử thứ {0}: ", i + 1);
                Node moi = new Node(int.Parse(Console.ReadLine()));
                if (head == null) head = tail = moi;
                else { tail.next = moi; tail = moi; }
            }

            Console.Write("Danh sách ban đầu: ");
            InDanhSach(head);

            Node prev = null;
            Node current = head;
            Node next = null;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;

            Console.Write("Danh sách sau khi đảo ngược: ");
            InDanhSach(head);
        }

        // =====================================================================
        // BÀI TẬP 14: Gộp hai danh sách liên kết đã sắp xếp
        // =====================================================================
        static Node NhapDSCoThuTu(string tenDS)
        {
            Console.Write("Nhập số phần tử cho {0} (nhập tăng dần): ", tenDS);
            int n = int.Parse(Console.ReadLine());
            Node head = null, tail = null;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử {0}: ", i + 1);
                Node moi = new Node(int.Parse(Console.ReadLine()));
                if (head == null) head = tail = moi;
                else { tail.next = moi; tail = moi; }
            }
            return head;
        }

        static void Bai14()
        {
            Node ds1 = NhapDSCoThuTu("DS 1");
            Node ds2 = NhapDSCoThuTu("DS 2");

            Node gia = new Node(0); 
            Node cuoi = gia;

            while (ds1 != null && ds2 != null)
            {
                if (ds1.data <= ds2.data)
                {
                    cuoi.next = ds1;
                    ds1 = ds1.next;
                }
                else
                {
                    cuoi.next = ds2;
                    ds2 = ds2.next;
                }
                cuoi = cuoi.next;
            }

            if (ds1 != null) cuoi.next = ds1;
            if (ds2 != null) cuoi.next = ds2;

            Console.Write("Danh sách sau khi gộp: ");
            InDanhSach(gia.next);
        }

        // =====================================================================
        // BÀI TẬP 15: Phát hiện chu trình (Thuật toán Floyd Rùa và Thỏ)
        // =====================================================================
        static bool CoChuTrinh(Node head)
        {
            Node rua = head;
            Node tho = head;

            while (tho != null && tho.next != null)
            {
                rua = rua.next;
                tho = tho.next.next;

                if (rua == tho)
                    return true;
            }
            return false;
        }

        static void Bai15()
        {
            Node n1 = new Node(2);
            Node n2 = new Node(3);
            Node n3 = new Node(4);
            Node n4 = new Node(5);
            Node n5 = new Node(6);
            n1.next = n2; n2.next = n3; n3.next = n4; n4.next = n5;

            Console.WriteLine("Kiểm tra danh sách 2->3->4->5->6 (chưa nối vòng): " +
                (CoChuTrinh(n1) ? "Có chu trình" : "Không có chu trình"));

            // Nối 6 quay lại 2 tạo chu trình
            n5.next = n1;
            Console.WriteLine("Kiểm tra danh sách 2->3->4->5->6->2 (đã nối vòng): " +
                (CoChuTrinh(n1) ? "Có chu trình" : "Không có chu trình"));
        }

        // =====================================================================
        // BÀI TẬP 16: Hệ thống lịch sử duyệt web (Danh sách kép)
        // =====================================================================
        static void Bai16()
        {
            WebNode web1 = new WebNode("google.com");
            WebNode web2 = new WebNode("github.com");
            web1.next = web2;
            web2.prev = web1;

            WebNode current = web1;
            int chon;
            do
            {
                Console.WriteLine("\n--- TRÌNH DUYỆT WEB ---");
                Console.WriteLine("Trang hiện tại: " + (current == null ? "Trống" : current.url));
                Console.WriteLine("1. Truy cập trang mới");
                Console.WriteLine("2. Quay lại (Back)");
                Console.WriteLine("3. Tiến tới (Forward)");
                Console.WriteLine("0. Thoát Bài 16");
                Console.Write("Chọn: ");
                chon = int.Parse(Console.ReadLine());

                if (chon == 1)
                {
                    Console.Write("Nhập địa chỉ web : ");
                    string url = Console.ReadLine();
                    WebNode moi = new WebNode(url);
                    if (current != null)
                    {
                        current.next = moi;
                        moi.prev = current;
                    }
                    current = moi;
                }
                else if (chon == 2)
                {
                    if (current != null && current.prev != null)
                        current = current.prev;
                    else
                        Console.WriteLine("Không thể Back thêm nữa!");
                }
                else if (chon == 3)
                {
                    if (current != null && current.next != null)
                        current = current.next;
                    else
                        Console.WriteLine("Không thể Forward thêm nữa!");
                }
            } while (chon != 0);
        }

        // =====================================================================
        // BÀI TẬP 17: Playlist nhạc (Danh sách liên kết kép)
        // =====================================================================
        static void Bai17()
        {
            BaiHatNode head = null;
            BaiHatNode tail = null;
            BaiHatNode current = null;
            int chon;

            do
            {
                Console.WriteLine("\n--- PLAYLIST NHẠC ---");
                Console.WriteLine("Bài hát đang phát: " + (current == null ? "Chưa có bài nào" : current.tenBaiHat));
                Console.WriteLine("1. Thêm bài hát vào cuối playlist");
                Console.WriteLine("2. Xóa bài hát theo tên");
                Console.WriteLine("3. Bài tiếp theo (Next)");
                Console.WriteLine("4. Bài trước đó (Previous)");
                Console.WriteLine("5. Xem tất cả bài hát trong playlist");
                Console.WriteLine("0. Thoát Bài 17");
                Console.Write("Chọn: ");
                chon = int.Parse(Console.ReadLine());

                if (chon == 1)
                {
                    Console.Write("Nhập tên bài hát: ");
                    string ten = Console.ReadLine();
                    BaiHatNode moi = new BaiHatNode(ten);
                    if (head == null)
                    {
                        head = tail = current = moi;
                    }
                    else
                    {
                        tail.next = moi;
                        moi.prev = tail;
                        tail = moi;
                    }
                    Console.WriteLine("Đã thêm bài hát!");
                }
                else if (chon == 2)
                {
                    Console.Write("Nhập tên bài hát cần xóa: ");
                    string tenXoa = Console.ReadLine();
                    BaiHatNode p = head;
                    while (p != null && p.tenBaiHat != tenXoa)
                    {
                        p = p.next;
                    }

                    if (p == null)
                    {
                        Console.WriteLine("Không tìm thấy bài hát cần xóa!");
                    }
                    else
                    {
                        if (current == p)
                        {
                            if (p.next != null) current = p.next;
                            else current = p.prev;
                        }

                        if (p == head && p == tail)
                        {
                            head = tail = null;
                        }
                        else if (p == head)
                        {
                            head = head.next;
                            head.prev = null;
                        }
                        else if (p == tail)
                        {
                            tail = tail.prev;
                            tail.next = null;
                        }
                        else
                        {
                            p.prev.next = p.next;
                            p.next.prev = p.prev;
                        }
                        Console.WriteLine("Đã xóa bài hát: " + tenXoa);
                    }
                }
                else if (chon == 3)
                {
                    if (current != null && current.next != null)
                        current = current.next;
                    else
                        Console.WriteLine("Đã ở cuối playlist, không thể Next!");
                }
                else if (chon == 4)
                {
                    if (current != null && current.prev != null)
                        current = current.prev;
                    else
                        Console.WriteLine("Đã ở đầu playlist, không thể Previous!");
                }
                else if (chon == 5)
                {
                    Console.Write("Danh sách nhạc: ");
                    BaiHatNode p = head;
                    while (p != null)
                    {
                        Console.Write(p.tenBaiHat + " <-> ");
                        p = p.next;
                    }
                    Console.WriteLine("null");
                }
            } while (chon != 0);
        }

        // =====================================================================
        // BÀI TẬP 18: Hệ thống đặt hàng (Danh sách liên kết kép chuyển trạng thái)
        // =====================================================================
        static void Bai18()
        {
            Console.Write("Nhập mã đơn hàng (VD: DH01): ");
            string maDon = Console.ReadLine();
            Console.Write("Nhập tên khách hàng: ");
            string tenKhach = Console.ReadLine();

            TrangThaiNode tt1 = new TrangThaiNode("Chờ xử lý");
            TrangThaiNode tt2 = new TrangThaiNode("Đang giao");
            TrangThaiNode tt3 = new TrangThaiNode("Hoàn thành");

            tt1.next = tt2;
            tt2.prev = tt1;
            tt2.next = tt3;
            tt3.prev = tt2;

            TrangThaiNode trangThaiHienTai = tt1;
            int chon;

            do
            {
                Console.WriteLine("\n--- QUẢN LÝ ĐƠN HÀNG [{0} - {1}] ---", maDon, tenKhach);
                Console.WriteLine("Trạng thái hiện tại: " + trangThaiHienTai.tenTrangThai);
                Console.WriteLine("1. Chuyển sang trạng thái tiếp theo");
                Console.WriteLine("2. Quay lại trạng thái trước đó");
                Console.WriteLine("0. Thoát Bài 18");
                Console.Write("Chọn: ");
                chon = int.Parse(Console.ReadLine());

                if (chon == 1)
                {
                    if (trangThaiHienTai.next != null)
                    {
                        trangThaiHienTai = trangThaiHienTai.next;
                        Console.WriteLine("Đã cập nhật trạng thái!");
                    }
                    else
                    {
                        Console.WriteLine("Đơn hàng đã Hoàn thành, không thể chuyển tiếp!");
                    }
                }
                else if (chon == 2)
                {
                    if (trangThaiHienTai.prev != null)
                    {
                        trangThaiHienTai = trangThaiHienTai.prev;
                        Console.WriteLine("Đã quay lại trạng thái trước!");
                    }
                    else
                    {
                        Console.WriteLine("Đơn hàng đang ở trạng thái đầu tiên (Chờ xử lý), không thể quay lại!");
                    }
                }
            } while (chon != 0);
        }
    }
}
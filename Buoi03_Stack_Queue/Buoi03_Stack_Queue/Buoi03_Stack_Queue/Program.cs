using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Buoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hỗ trợ hiển thị tiếng Việt có dấu trên Console
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================================");
                Console.WriteLine("        CHƯƠNG TRÌNH THỰC HÀNH STACK & QUEUE           ");
                Console.WriteLine("=======================================================");
                Console.WriteLine("1.   Bài 1: Kiểm tra tính đúng đắn biểu thức ");
                Console.WriteLine("2.   Bài 2: Mô phỏng lịch sử trình duyệt web ");
                Console.WriteLine("3.   Bài 3: Mô phỏng gọi hàm - Function Call Stack");
                Console.WriteLine("4.   Bài 4: Mô phỏng hệ thống in ấn ");
                Console.WriteLine("5.   Bài 5: Mô phỏng đường truyền dữ liệu ");
                Console.WriteLine("6.   Bài 6: Mô phỏng quản lý hàng đợi tại TTDVKH hoặc KH ");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("4.1. Bài 4.1:   Mô phỏng lịch sử trình duyệt ");
                Console.WriteLine("5.1. Bài 5.1:   Kiểm tra chuỗi ngoặc () đúng");
                Console.WriteLine("6.1. Bài 6.1:   Mô phỏng hệ thống in");
                Console.WriteLine("7.   Bài 7: Mô phỏng đường truyền dữ liệu");
                Console.WriteLine("8.   Bài 8: Mô phỏng Dịch vụ Khách hàng ");
                Console.WriteLine("9.   Bài 9: Tính giá trị biểu thức hậu tố ");
                Console.WriteLine("10.  Bài 10: Kiểm tra tính hợp lệ biểu thức trung tố");
                Console.WriteLine("11.  Bài 11: Tính giá trị biểu thức trung tố ");
                Console.WriteLine("0.   Thoát chương trình");
                Console.WriteLine("=======================================================");
                Console.Write("Chọn bài muốn chạy: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1": Bai1(); break;
                    case "2": Bai2(); break;
                    case "3": Bai3(); break;
                    case "4": Bai4(); break;
                    case "5": Bai5(); break;
                    case "6": Bai6(); break;
                    case "4.1": Bai4_1(); break;
                    case "5.1": Bai5_1(); break;
                    case "6.1": Bai6_1(); break;
                    case "7": Bai7(); break;
                    case "8": Bai8(); break;
                    case "9": Bai9(); break;
                    case "10": Bai10(); break;
                    case "11": Bai11(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để quay lại Menu chính...");
                Console.ReadKey();
            }
        }

        // ====================================================
        // 1. BÀI TẬP 1: KIỂM TRA TÍNH ĐÚNG ĐẮN CỦA BIỂU THỨC 
        // ====================================================
        static void Bai1()
        {
            Console.WriteLine("--- BÀI 1: KIỂM TRA DẤU NGOẶC BIỂU THỨC ---");
            Console.Write("Nhập biểu thức toán học: ");
            string expr = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            bool isValid = true;

            foreach (char c in expr)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (isValid && stack.Count == 0)
                Console.WriteLine("=> KẾT QUẢ: Biểu thức HỢP LỆ.");
            else
                Console.WriteLine("=> KẾT QUẢ: Biểu thức KHÔNG HỢP LỆ.");
        }

        // ================================================
        // 2. BÀI TẬP 2: MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT WEB
        // ================================================
        static void Bai2()
        {
            Stack<string> backStack = new Stack<string>();
            Stack<string> forwardStack = new Stack<string>();
            string currentPage = "Trang chủ (google.com)";

            while (true)
            {
                Console.WriteLine("\n--- BÀI 2: TRÌNH DUYỆT WEB ---");
                Console.WriteLine($"Trang hiện tại: [{currentPage}]");
                Console.WriteLine("1. Truy cập trang mới");
                Console.WriteLine("2. Nhấn Back (Quay lại)");
                Console.WriteLine("3. Nhấn Forward (Chuyển tiếp)");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Chọn thao tác: ");
                string cmd = Console.ReadLine();

                if (cmd == "1")
                {
                    Console.Write("Nhập địa chỉ web mới: ");
                    string newPage = Console.ReadLine();
                    backStack.Push(currentPage);
                    forwardStack.Clear();
                    currentPage = newPage;
                }
                else if (cmd == "2")
                {
                    if (backStack.Count > 0)
                    {
                        forwardStack.Push(currentPage);
                        currentPage = backStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("(!) Không có trang nào để quay lại.");
                    }
                }
                else if (cmd == "3")
                {
                    if (forwardStack.Count > 0)
                    {
                        backStack.Push(currentPage);
                        currentPage = forwardStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("(!) Không có trang nào để chuyển tiếp.");
                    }
                }
                else if (cmd == "0") break;
            }
        }

        // ================================================================
        // 3. BÀI TẬP 3: MÔ PHỎNG QUÁ TRÌNH THỰC THI CHƯƠNG TRÌNH 
        // ================================================================
        class StackFrame
        {
            public string FunctionName { get; set; }
            public string Parameters { get; set; }
            public string ReturnAddress { get; set; }

            public override string ToString()
            {
                return $"Hàm: {FunctionName} | Tham số: {Parameters} | Địa chỉ trả về: {ReturnAddress}";
            }
        }

        static void Bai3()
        {
            Stack<StackFrame> callStack = new Stack<StackFrame>();

            while (true)
            {
                Console.WriteLine("\n--- BÀI 3: FUNCTION CALL STACK ---");
                Console.WriteLine("Trạng thái Call Stack hiện tại (Đỉnh -> Đáy):");
                if (callStack.Count == 0)
                    Console.WriteLine("   [Trống - Không có hàm nào đang chạy]");
                else
                    foreach (var frame in callStack)
                        Console.WriteLine("   -> " + frame);

                Console.WriteLine("\n1. Gọi hàm mới (Push Frame)");
                Console.WriteLine("2. Kết thúc hàm hiện tại (Pop Frame)");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Chọn thao tác: ");
                string cmd = Console.ReadLine();

                if (cmd == "1")
                {
                    Console.Write("Tên hàm (VD: TinhTong): ");
                    string name = Console.ReadLine();
                    Console.Write("Tham số truyền vào (VD: a=5, b=10): ");
                    string param = Console.ReadLine();
                    string retAddr = "0x" + new Random().Next(1000, 9999);

                    callStack.Push(new StackFrame
                    {
                        FunctionName = name,
                        Parameters = param,
                        ReturnAddress = retAddr
                    });
                    Console.WriteLine($"=> Đã gọi hàm [{name}].");
                }
                else if (cmd == "2")
                {
                    if (callStack.Count > 0)
                    {
                        StackFrame finished = callStack.Pop();
                        Console.WriteLine($"=> Hàm [{finished.FunctionName}] đã thực thi xong và trả về địa chỉ {finished.ReturnAddress}.");
                    }
                    else
                    {
                        Console.WriteLine("(!) Call Stack đang trống.");
                    }
                }
                else if (cmd == "0") break;
            }
        }

        // =========================================
        // 4. BÀI TẬP 4: MÔ PHỎNG HỆ THỐNG IN ẤN 
        // =========================================
        static void Bai4()
        {
            Queue<string> printQueue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n--- BÀI 4: HỆ THỐNG IN ẤN ---");
                Console.WriteLine($"Số tài liệu đang chờ in: {printQueue.Count}");
                Console.WriteLine("1. Thêm yêu cầu in mới (Enqueue)");
                Console.WriteLine("2. Thực hiện in tài liệu tiếp theo ");
                Console.WriteLine("3. Xem danh sách đang chờ");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Chọn thao tác: ");
                string cmd = Console.ReadLine();

                if (cmd == "1")
                {
                    Console.Write("Nhập tên tài liệu cần in: ");
                    string doc = Console.ReadLine();
                    printQueue.Enqueue(doc);
                    Console.WriteLine($"=> Đã thêm '{doc}' vào hàng đợi in.");
                }
                else if (cmd == "2")
                {
                    if (printQueue.Count > 0)
                    {
                        string doc = printQueue.Dequeue();
                        Console.WriteLine($"=> ĐANG IN TÀI LIỆU: '{doc}' ... Hoàn tất!");
                    }
                    else
                    {
                        Console.WriteLine("(!) Hàng đợi in đang trống.");
                    }
                }
                else if (cmd == "3")
                {
                    if (printQueue.Count == 0) Console.WriteLine("Hàng đợi trống.");
                    else Console.WriteLine("Danh sách chờ: " + string.Join(" -> ", printQueue));
                }
                else if (cmd == "0") break;
            }
        }

        // =======================================================
        // 5. BÀI TẬP 5: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU (QUEUE)
        // =======================================================
        static void Bai5()
        {
            Queue<string> packetQueue = new Queue<string>();
            Random rand = new Random();

            while (true)
            {
                Console.WriteLine("\n--- BÀI 5: ĐƯỜNG TRUYỀN DỮ LIỆU MẠNG ---");
                Console.WriteLine($"Gói tin trên đường truyền: {packetQueue.Count}");
                Console.WriteLine("1. Gửi gói tin mới ");
                Console.WriteLine("2. Xử lý gói tin ở đầu hàng đợi");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Chọn thao tác: ");
                string cmd = Console.ReadLine();

                if (cmd == "1")
                {
                    Console.Write("Nhập nội dung gói tin: ");
                    string data = Console.ReadLine();
                    packetQueue.Enqueue(data);
                    Console.WriteLine($"=> Đã đưa gói tin [{data}] lên đường truyền.");
                }
                else if (cmd == "2")
                {
                    if (packetQueue.Count > 0)
                    {
                        string packet = packetQueue.Dequeue();
                        Console.Write("Đang truyền tải...");
                        Thread.Sleep(800);
                        if (rand.Next(1, 101) <= 20)
                            Console.WriteLine($"\n[LỖI] Gói tin [{packet}] bị mất!");
                        else
                            Console.WriteLine($"\n[THÀNH CÔNG] Đã nhận gói tin: [{packet}]");
                    }
                    else
                    {
                        Console.WriteLine("(!) Hàng đợi trống.");
                    }
                }
                else if (cmd == "0") break;
            }
        }

        // ====================================================
        // 6. BÀI TẬP 6: MÔ PHỎNG HÀNG ĐỢI NGÂN HÀNG / CSKH
        // ====================================================
        class Customer
        {
            public string Name { get; set; }
            public string ServiceType { get; set; }
            public string ArrivalTime { get; set; }

            public override string ToString()
            {
                return $"[{ArrivalTime}] {Name} - {ServiceType}";
            }
        }

        static void Bai6()
        {
            Queue<Customer> customerQueue = new Queue<Customer>();

            while (true)
            {
                Console.WriteLine("\n--- BÀI 6: Mô phỏng quản lý hàng đợi tại TTDVKH hoặc KH---");
                Console.WriteLine($"Số khách đang chờ: {customerQueue.Count}");
                Console.WriteLine("1. Khách hàng mới lấy số");
                Console.WriteLine("2. Nhân viên gọi khách tiếp theo");
                Console.WriteLine("3. Hiển thị hàng đợi");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Chọn: ");
                string cmd = Console.ReadLine();

                if (cmd == "1")
                {
                    Console.Write("Tên khách hàng: ");
                    string name = Console.ReadLine();
                    Console.Write("Dịch vụ: ");
                    string service = Console.ReadLine();
                    string time = DateTime.Now.ToString("HH:mm:ss");

                    customerQueue.Enqueue(new Customer { Name = name, ServiceType = service, ArrivalTime = time });
                    Console.WriteLine($"Khách hàng {name} đã vào hàng đợi.");
                }
                else if (cmd == "2")
                {
                    if (customerQueue.Count > 0)
                    {
                        Customer next = customerQueue.Dequeue();
                        Console.WriteLine($"Mời khách hàng: {next.Name} ({next.ServiceType})");
                    }
                    else
                    {
                        Console.WriteLine("Không có khách hàng nào đang chờ.");
                    }
                }
                else if (cmd == "3")
                {
                    if (customerQueue.Count == 0) Console.WriteLine("Hàng đợi trống.");
                    else
                    {
                        int stt = 1;
                        foreach (var c in customerQueue) Console.WriteLine($"   {stt++}. {c}");
                    }
                }
                else if (cmd == "0") break;
            }
        }

        // =====================================================================
        // 4.1. BÀI 4.1: MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT WEB 
        // =====================================================================
        static Stack<string> backStack_4_1 = new Stack<string>();
        static Stack<string> forwardStack_4_1 = new Stack<string>();
        static string currentPage_4_1 = "";

        static void Visit(string url)
        {
            if (!string.IsNullOrEmpty(currentPage_4_1))
            {
                backStack_4_1.Push(currentPage_4_1);
            }
            currentPage_4_1 = url;
            forwardStack_4_1.Clear();
            Console.WriteLine($"Đang truy cập: {currentPage_4_1}");
        }

        static void Back()
        {
            if (backStack_4_1.Count > 0)
            {
                forwardStack_4_1.Push(currentPage_4_1);
                currentPage_4_1 = backStack_4_1.Pop();
                Console.WriteLine($"Quay lại: {currentPage_4_1}");
            }
            else
            {
                Console.WriteLine("Không thể quay lại!");
            }
        }

        static void Forward()
        {
            if (forwardStack_4_1.Count > 0)
            {
                backStack_4_1.Push(currentPage_4_1);
                currentPage_4_1 = forwardStack_4_1.Pop();
                Console.WriteLine($"Tiến lên: {currentPage_4_1}");
            }
            else
            {
                Console.WriteLine("Không thể tiến lên!");
            }
        }

        static void ShowCurrentPage()
        {
            if (string.IsNullOrEmpty(currentPage_4_1))
                Console.WriteLine("Chưa truy cập trang web nào.");
            else
                Console.WriteLine($"Trang hiện tại: {currentPage_4_1}");
        }

        static void Bai4_1()
        {
            backStack_4_1.Clear();
            forwardStack_4_1.Clear();
            currentPage_4_1 = "";

            Console.WriteLine("=== BÀI 4.1: MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===");
            Console.WriteLine("1. Truy cập trang mới");
            Console.WriteLine("2. Quay lại");
            Console.WriteLine("3. Tiến lên");
            Console.WriteLine("4. Hiển thị trang hiện tại");
            Console.WriteLine("0. Thoát");

            while (true)
            {
                Console.Write("Chọn: ");
                string cmd = Console.ReadLine();

                if (cmd == "1")
                {
                    Console.Write("Nhập URL: ");
                    string url = Console.ReadLine();
                    Visit(url);
                }
                else if (cmd == "2") Back();
                else if (cmd == "3") Forward();
                else if (cmd == "4") ShowCurrentPage();
                else if (cmd == "0") break;
                else Console.WriteLine("Lựa chọn không hợp lệ!");
            }
        }

        // =====================================================================
        // 5.1. BÀI 5.1: KIỂM TRA CHUỖI NGOẶC () ĐÚNG
        // =====================================================================
        static void Bai5_1()
        {
            Console.WriteLine("--- BÀI 5.1: KIỂM TRA CHUỖI NGOẶC () ĐÚNG ---");
            Console.Write("Nhập chuỗi chỉ chứa ký tự '(' và ')': ");
            string s = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            bool isValid = true;

            foreach (char c in s)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    stack.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid && stack.Count == 0)
                Console.WriteLine("=> Xâu đúng");
            else
                Console.WriteLine("=> Xâu sai");
        }

        // =====================================================================
        // 6.1. BÀI 6.1: MÔ PHỎNG HỆ THỐNG IN 
        // =====================================================================
        static void Bai6_1()
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n--- BÀI 6.1: MÔ PHỎNG HỆ THỐNG IN ---");
                Console.WriteLine("1. Thêm một yêu cầu in mới");
                Console.WriteLine("2. Xử lý (in) một yêu cầu trong hàng đợi");
                Console.WriteLine("3. Hiển thị danh sách các yêu cầu còn lại");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Chọn: ");
                string cmd = Console.ReadLine();

                if (cmd == "1")
                {
                    Console.Write("Nhập tên tài liệu in: ");
                    string doc = Console.ReadLine();
                    queue.Enqueue(doc);
                    Console.WriteLine($"Đã thêm tài liệu '{doc}' vào hàng đợi.");
                }
                else if (cmd == "2")
                {
                    if (queue.Count > 0)
                    {
                        string doc = queue.Dequeue();
                        Console.WriteLine($"Đang xử lý in tài liệu: {doc}");
                    }
                    else
                    {
                        Console.WriteLine("Không có yêu cầu in nào!");
                    }
                }
                else if (cmd == "3")
                {
                    if (queue.Count == 0) Console.WriteLine("Hàng đợi in trống.");
                    else Console.WriteLine("Danh sách chờ: " + string.Join(" <- ", queue));
                }
                else if (cmd == "0") break;
            }
        }

        // =====================================================================
        // 7. BÀI 7: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU 
        // =====================================================================
        static void Bai7 ()
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n--- BÀI 7: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU ---");
                Console.WriteLine("1. Gửi dữ liệu (Thêm gói tin)");
                Console.WriteLine("2. Nhận dữ liệu (Xử lý gói tin đầu)");
                Console.WriteLine("3. Hiển thị danh sách các gói dữ liệu trong hàng đợi");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Chọn: ");
                string cmd = Console.ReadLine();

                if (cmd == "1")
                {
                    Console.Write("Nhập gói dữ liệu (chuỗi hoặc số): ");
                    string data = Console.ReadLine();
                    queue.Enqueue(data);
                    Console.WriteLine($"Đã gửi gói dữ liệu: {data}");
                }
                else if (cmd == "2")
                {
                    if (queue.Count > 0)
                    {
                        string data = queue.Dequeue();
                        Console.WriteLine($"Đã nhận và xử lý dữ liệu: {data}");
                    }
                    else
                    {
                        Console.WriteLine("Không có dữ liệu để nhận!");
                    }
                }
                else if (cmd == "3")
                {
                    if (queue.Count == 0) Console.WriteLine("Hàng đợi trống.");
                    else Console.WriteLine("Danh sách gói dữ liệu: " + string.Join(" <- ", queue));
                }
                else if (cmd == "0") break;
            }
        }

        // =====================================================================
        // 8. BÀI 8: MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG 
        // =====================================================================
        static void Bai8()
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n--- BÀI 8: MÔ PHỎNG DỊCH VỤ KHÁCH HÀNG ---");
                Console.WriteLine("1. Thêm khách hàng mới vào hàng đợi");
                Console.WriteLine("2. Phục vụ khách hàng");
                Console.WriteLine("3. Hiển thị danh sách khách hàng chờ");
                Console.WriteLine("0. Quay lại Menu chính");
                Console.Write("Chọn: ");
                string cmd = Console.ReadLine();

                if (cmd == "1")
                {
                    Console.Write("Nhập tên hoặc số thứ tự khách hàng: ");
                    string cus = Console.ReadLine();
                    queue.Enqueue(cus);
                    Console.WriteLine($"Khách hàng '{cus}' đã vào hàng đợi.");
                }
                else if (cmd == "2")
                {
                    if (queue.Count > 0)
                    {
                        string cus = queue.Dequeue();
                        Console.WriteLine($"Đang phục vụ khách hàng: {cus}");
                    }
                    else
                    {
                        Console.WriteLine("Không có khách hàng nào trong hàng đợi!");
                    }
                }
                else if (cmd == "3")
                {
                    if (queue.Count == 0) Console.WriteLine("Hàng đợi khách hàng trống.");
                    else Console.WriteLine("Danh sách chờ: " + string.Join(" <- ", queue));
                }
                else if (cmd == "0") break;
            }
        }

        // =====================================================================
        // 9. BÀI 9: TÍNH GIÁ TRỊ CỦA BIỂU THỨC HẬU TỐ (POSTFIX)
        // =====================================================================
        static void Bai9()
        {
            Console.WriteLine("--- BÀI 9: TÍNH GIÁ TRỊ BIỂU THỨC HẬU TỐ ---");
            Console.Write("Nhập biểu thức hậu tố (cách nhau bởi dấu cách, VD: 3 4 2 * +): ");
            string postfix = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(postfix))
            {
                Console.WriteLine("Biểu thức trống!");
                return;
            }

            Stack<float> stack = new Stack<float>();
            string[] tokens = postfix.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                if (float.TryParse(token, out float number))
                {
                    stack.Push(number);
                }
                else if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    if (stack.Count < 2)
                    {
                        Console.WriteLine("Biểu thức không hợp lệ (thiếu toán hạng)!");
                        return;
                    }

                    float x2 = stack.Pop();
                    float x1 = stack.Pop();
                    float result = 0;

                    switch (token)
                    {
                        case "+": result = x1 + x2; break;
                        case "-": result = x1 - x2; break;
                        case "*": result = x1 * x2; break;
                        case "/":
                            if (x2 == 0)
                            {
                                Console.WriteLine("Lỗi: Không thể chia cho 0!");
                                return;
                            }
                            result = x1 / x2;
                            break;
                    }

                    stack.Push(result);
                }
                else
                {
                    Console.WriteLine($"Ký tự không hợp lệ: {token}");
                    return;
                }
            }

            if (stack.Count == 1)
            {
                Console.WriteLine($"=> Kết quả biểu thức hậu tố = {stack.Pop()}");
            }
            else
            {
                Console.WriteLine("Biểu thức hậu tố không hợp lệ!");
            }
        }

        // =====================================================================
        // 10. BÀI 10: KIỂM TRA TÍNH HỢP LỆ CỦA BIỂU THỨC TRUNG TỐ
        // =====================================================================
        static void Bai10()
        {
            Console.WriteLine("--- BÀI 10: KIỂM TRA TÍNH HỢP LỆ CỦA BIỂU THỨC TRUNG TỐ ---");
            Console.Write("Nhập công thức toán học trung tố: ");
            string expr = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(expr))
            {
                Console.WriteLine("Biểu thức không hợp lệ");
                return;
            }

            expr = expr.Replace(" ", "");
            Stack<char> stack = new Stack<char>();
            bool isValid = true;

            char firstChar = expr[0];
            char lastChar = expr[expr.Length - 1];
            if (IsOperator(firstChar) || IsOperator(lastChar))
            {
                isValid = false;
            }

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        isValid = false;
                        break;
                    }
                }
                else if (IsOperator(c))
                {
                    if (i < expr.Length - 1 && IsOperator(expr[i + 1]))
                    {
                        isValid = false;
                        break;
                    }
                }
                else if (!char.IsLetterOrDigit(c) && !IsOperator(c))
                {
                    isValid = false;
                    break;
                }
            }

            if (stack.Count > 0)
            {
                isValid = false;
            }

            if (isValid)
                Console.WriteLine("=> Biểu thức hợp lệ");
            else
                Console.WriteLine("=> Biểu thức không hợp lệ");
        }

        // =====================================================================
        // 11. BÀI 11: TÍNH GIÁ TRỊ BIỂU THỨC TRUNG TỐ (KIỂM TRA + CHUYỂN HẬU TỐ + TÍNH)
        // =====================================================================
        static int Priority(string op)
        {
            if (op == "+" || op == "-") return 1;
            if (op == "*" || op == "/") return 2;
            return 0;
        }

        static bool IsOperand(string s)
        {
            return float.TryParse(s, out _);
        }

        static void Bai11()
        {
            Console.WriteLine("--- BÀI 11: TÍNH GIÁ TRỊ BIỂU THỨC TRUNG TỐ ---");
            Console.Write("Nhập biểu thức trung tố (VD: 3 + 5 * ( 2 - 4 ) - các phần tử cách nhau bởi dấu cách): ");
            string e = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(e))
            {
                Console.WriteLine("Biểu thức trống!");
                return;
            }

            Stack<char> checkStack = new Stack<char>();
            bool isValid = true;
            foreach (char c in e)
            {
                if (c == '(' || c == '[' || c == '{') checkStack.Push(c);
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (checkStack.Count == 0) { isValid = false; break; }
                    checkStack.Pop();
                }
            }
            if (checkStack.Count > 0) isValid = false;

            if (!isValid)
            {
                Console.WriteLine("Thông báo lỗi: Biểu thức trung tố không hợp lệ (lỗi dấu ngoặc)!");
                return;
            }

            Stack<string> st = new Stack<string>();
            StringBuilder E1 = new StringBuilder();
            string[] enumer = e.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in enumer)
            {
                if (s == "(" || s == "[" || s == "{")
                {
                    st.Push(s);
                }
                else if (s == ")" || s == "]" || s == "}")
                {
                    string openBr = (s == ")") ? "(" : (s == "]") ? "[" : "{";
                    while (st.Count > 0 && st.Peek() != openBr)
                    {
                        E1.Append(st.Pop() + " ");
                    }
                    if (st.Count > 0) st.Pop(); 
                }
                else if (IsOperand(s))
                {
                    E1.Append(s + " ");
                }
                else 
                {
                    while (st.Count > 0 && Priority(st.Peek()) >= Priority(s))
                    {
                        E1.Append(st.Pop() + " ");
                    }
                    st.Push(s);
                }
            }

            while (st.Count > 0)
            {
                E1.Append(st.Pop() + " ");
            }

            string postfixResult = E1.ToString().Trim();
            Console.WriteLine($"=> Biểu thức hậu tố (Postfix): {postfixResult}");

            string[] tokens = postfixResult.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Stack<float> evalStack = new Stack<float>();

            foreach (string token in tokens)
            {
                if (float.TryParse(token, out float number))
                {
                    evalStack.Push(number);
                }
                else
                {
                    if (evalStack.Count < 2)
                    {
                        Console.WriteLine("Lỗi tính toán biểu thức!");
                        return;
                    }
                    float x2 = evalStack.Pop();
                    float x1 = evalStack.Pop();
                    float r = 0;

                    switch (token)
                    {
                        case "+": r = x1 + x2; break;
                        case "-": r = x1 - x2; break;
                        case "*": r = x1 * x2; break;
                        case "/":
                            if (x2 == 0)
                            {
                                Console.WriteLine("Lỗi: Không thể chia cho 0!");
                                return;
                            }
                            r = x1 / x2;
                            break;
                    }
                    evalStack.Push(r);
                }
            }

            if (evalStack.Count == 1)
            {
                Console.WriteLine($"=> Kết quả cuối cùng = {evalStack.Pop()}");
            }
            else
            {
                Console.WriteLine("Thông báo lỗi: Không thể tính toán biểu thức!");
            }
        }

        static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
    }
}
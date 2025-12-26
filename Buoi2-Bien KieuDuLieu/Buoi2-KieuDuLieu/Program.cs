namespace Buoi2_KieuDuLieu
{
    internal class Program
    {
        static void Print(object obj)
        {
            Console.WriteLine("Giá trị object = " + obj);
            Console.WriteLine(obj.GetType());
        }

        static void TestGeneric<T>(T obj)
        {
            Console.WriteLine("Giá trị object = " + obj);
            Console.WriteLine(obj.GetType());
        }
        static void Main(string[] args)
        {
            // Kiểu dữ liệu của biến
            // 1. Kiểu dữ liệu giá trị
            // 2. Kiểu dữ liệu tham chiếu
            // 3. Kiểu dự liệu con trỏ


            // 1. Kiểu dự liệu hay dùng
            // int, long, double ,float
            // số nguyên
            int totalInt = -2000000000;
            long totalLong = -30000000000000000;

            // số thực
            float totalFloat = 444.56f;
            double totalDouble = 600.30;
            decimal totalDecimal = 124657987.1324564987m;

            // kiểu ký tự
            char test = '@';

            // kiểu logic
            bool isCheck = false;
            bool isChecked = true;

            // Khai báo kết quả
            char a = 'G';
            int i = 89;
            short s = 56;
            long l = 4564;
            uint ui = 95;
            ushort us = 76;
            ulong ul = 3624573;
            double d = 8.358674532;
            float f = 3.7330645f;
            decimal dec = 389.5m;

            // In kết quả
            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsigned integer: " + ui);
            Console.WriteLine("Unsigned short: " + us);
            Console.WriteLine("Unsigned long: " + ul);

            //Console.Write("Ky tu nhap : ");
            //string? chuoi = Console.ReadLine();
            //Console.WriteLine("Ky tu da nhap : " + chuoi);

            //Console.Write("Nhap so Nguyen : ");
            //int soNguyen = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("So Nguyen da nhap : " + soNguyen);

            //Console.Write("Nhap so Thuc : ");
            //double soThuc = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("So Nguyen da nhap : " + soThuc);

            //Console.Write("Nhap so Decimal");
            //decimal soDecimal = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("So Decimal da nhap : " + soDecimal);

            object className;
            className = "PC11";
            className = 20;

            Console.WriteLine("Gia tri Obj: " + className);

            //boxing
            int intA = 10; // value type : kiểu giá trị
            object obj = intA; // boxing

            object objV2 = 10.0;
            double intB = (double)objV2; // unboxing

            Console.WriteLine("intB : " + intB);

            // tại sao phải boxing và unboxing
            // Vì C# vừa có kiểu dự liệu là kiểu gia trị (value type) và kiểu tham chiếu (reference type)
            // mà nhiều lúc code chỉ làm việc với object
            // thì boxing và unboxing nó là cái cầu nối
            int testA = 10;
            double testB = 20.5;
            Print(testA);
            Print(testB);

            Console.WriteLine("------------------");
            TestGeneric(testA);
            TestGeneric(testB);

            Console.WriteLine("------------------");
            // 4. Kiểu con trỏ
            unsafe
            {
                // Khai báo biến
                int n = 10;
                // Lưu địa chỉ của biến n vào biến con trỏ p
                int* p = &n;
                *p = 20;
                n = 30;

                Console.WriteLine("Value: {0}", n);
                Console.WriteLine("Value *p: " + *p);
                Console.WriteLine("Address: {0}", (int)p);
            }


            // Kiểu dữ liệu:
            // 1. Kiểu giá trị (value type) : int, double, float, long
            // Lưu trực tiếp giá trị
            // gán biến -> copy giá trị
            // hiệu suất cao và tiết kiệm
            

            // 2. Kiểu tham chiều (reference type) : string, array, class, object, interface, delegate
            // là kiểu dữ liệu mà biến khai báo không chứa dữ liệu, chỉ chứa địa chỉ ô nhớ, rồi nó trỏ đến giá trị
            // nhiều biến có thể trỏ chung 1 object
            // mở rộng và linh hoạt


            // Vùng nhớ Stack là vùng nhớ tạm thời lưu trữ giá trị của biến cục bộ hoặc địa chỉ biến(tham chiếu).
            // Vung nhớ Heap là vùng nhớ lâu dài vẫn ở trên RAM, lưu trữ giá trị boxing, có hiệu suất thấp hơn Stack. 

        }
    }
}

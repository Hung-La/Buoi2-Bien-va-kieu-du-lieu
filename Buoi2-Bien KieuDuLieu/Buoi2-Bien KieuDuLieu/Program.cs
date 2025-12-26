
namespace Buoi2_Bien_KieuDuLieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null;
            int ageV2 = 20;
            Console.WriteLine("Hello, World! 2");

            float test = 2f;
            Console.WriteLine(test);

            // Quy tắc đặt tên biến:
            // 1. Biến cục bộ -> camelCase
            // 2. Biến có ý nghĩa -> Đặt tên rõ ràng

            string fullName = "Hưng Lã";

            // Đặt tên biến theo từng loại
            // 1. Biến số
            int count;
            int totalProduct;
            int maxValue;
            int minValue;
            double score;

            // 2. Biến chuỗi (string)
            string emailAddress;

            // 3. Biến mảng/ danh sách
            int[] scores;
            List<string> scoreList;

            // 4. Biến hằng số (constant) -> Khai báo theo kiểu PascalCase;
            const int TotalScore = 15;

            // Khởi tạo biến - gán lại giá trị cho biến

            // Khai báo lúc biên dịch
            int x = 0;
            x = 10;
            Console.WriteLine("Giá trị x = " + x);

            // Khai báo lúc chạy
            Console.Write("Nhap dia chi nha : ");
            string? address = Console.ReadLine();
            Console.WriteLine("Dia chi Nha : " + address);

            // 1 vài câu lệnh nhanh trong C#
            // Ctrl + D : Duplicate
            // Ctrl + X : Cut
            // Giữ Alt + Kéo chuột : sửa nhiều dòng
            // Giữ Alt + lên/xuống 
            // Ctrl + R, Ctrl + R : Rename biến

            Console.WriteLine("Hiển thị");
            Console.WriteLine("Hiển thị");
            Console.WriteLine("Hiển thị");
            Console.WriteLine("Hiển thị");
            Console.WriteLine("Hiển thị");
            Console.WriteLine("Dia chi Nha : " + address);
        }
    }
}
namespace BaiTap_Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            Exercise2();
            Exercise3();
            Exercise4("Hung", 1, 2, "PCControl11",3,5,8,10,9.5,50.8,"Machine Vision");
        }

        private static void Exercise1()
        {
            Console.Write("Nhap ten : ");
            string? chuoi = Console.ReadLine();
            Console.WriteLine("Ten da nhap : " + chuoi);

            Console.Write("nhap so nguyen : ");
            int songuyen = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("so nguyen da nhap : " + songuyen);

            Console.WriteLine("nhap so thuc : ");
            double sothuc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("so nguyen da nhap : " + sothuc);

            Console.WriteLine("nhap so decimal");
            decimal sodecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("so decimal da nhap : " + sodecimal);
        }

        private static void Exercise2()
        {
            byte i = 255;
            Console.WriteLine(++i);

            sbyte j = 127;
            Console.WriteLine(++j);
        }

        private static void Exercise3()
        {
            decimal a = 30.000000004444444m;
            decimal b = 50.0000000000099999999m;

            decimal sum = a + b;
            Console.WriteLine(sum);
        }

        private static void Exercise4(params object[] objs)
        {
            if (objs != null)
            {
                int i = 0;
                foreach (object obj in objs)
                {
                    i++;
                    if (obj is string || obj is char)
                    {
                        Console.WriteLine($"Chuỗi và ký tự có thứ tự {i} là :" + obj);
                    }
                    else if (obj is byte or short or int or long or float or double or decimal)
                    {
                        Console.WriteLine($"Số có thứ tự {i} là :" + obj);
                    }
                }
            }
        }
    }
}

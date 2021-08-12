using System;
using System.Collections;
using System.Text;

namespace TinhToanPhanSo
{
    class Program
    {
        public static void Programming(ArrayList arrPS)
        {
            Console.Clear();
            Console.WriteLine("Tính Toán Phân Số");
            Console.WriteLine("1. Nhập Phân Số");
            Console.WriteLine("2. Hiện Tất Cả");
            Console.WriteLine("3. Phép Tính");
            Console.WriteLine("4. So Sánh");
            Console.WriteLine("0. Thoát Chương Trình");
            Console.WriteLine("Nhập Chức Năng");
            int iChucNang = 0;
            try { iChucNang = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Nhập sai"); }
            do
            {
                Console.Title = "Tính Toán Phân Số";
                switch (iChucNang)
                {
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case 1: // Tạo
                        {
                            ChucNang.TaoPhanSo(arrPS);
                            break;
                        }
                    case 2: // Hiện Hết
                        {
                            ChucNang.HienPhanSo(arrPS);
                            break;
                        }
                    case 3: //Phép Tính
                        {
                            ChucNang.PhepTinh(arrPS);
                            break;
                        }
                    case 4: //So Sánh
                        {
                            ChucNang.SoSanh(arrPS);
                            break;
                        }
                }
            } while (true);
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            ArrayList arrPS = new ArrayList();
            Programming(arrPS);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhToanPhanSo
{
    public class ChucNang
    {
        public static void TaoPhanSo(ArrayList arrPS)
        {
            Console.Clear();
            Console.WriteLine("1. Nhập Phân Số 1");
            Console.WriteLine("2. Nhập Phân Số 2");
            Console.WriteLine("0. Màn Hình Chính");
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch (iChucNang)
                {
                    case 0: // Về Menu Chính
                        {
                            Program.Programming(arrPS);
                            break;
                        }
                    case 1: // Nhập Phân SỐ 1
                        {
                            PhanSo phanso1 = new PhanSo();
                            arrPS.Add(phanso1);
                            phanso1.NhapPhanSo();
                            TaoPhanSo(arrPS);
                            break;
                        }
                    case 2: //Nhập Phần Số 2
                        {
                            PhanSo phanso2 = new PhanSo();
                            arrPS.Add(phanso2);
                            phanso2.NhapPhanSo();
                            TaoPhanSo(arrPS);
                            break;
                        }
                }
            }while(true);
        }
        public static void UpdatePS(ArrayList arrPS)
        {
            Console.Clear();
            Console.WriteLine("1. Cập Nhật Phân Số 1");
            Console.WriteLine("2. Cập Nhật Phân Số 2");
            Console.WriteLine("0. Màn Hình Chính");
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch (iChucNang)
                {
                    case 0: // Về Menu Chính
                        {
                            Program.Programming(arrPS);
                            break;
                        }
                    case 1: // Nhập Phân SỐ 1
                        {
                            PhanSo phanso = new PhanSo();
                            phanso = (PhanSo)arrPS[0];
                            phanso.XuatPhanSo();
                            PhanSo phanso1 = new PhanSo();
                            arrPS.Insert(0, phanso1);
                            phanso1.NhapPhanSo();
                            UpdatePS(arrPS);
                            break;
                        }
                    case 2: //Nhập Phần Số 2
                        {
                            PhanSo phanso = new PhanSo();
                            phanso = (PhanSo)arrPS[1];
                            phanso.XuatPhanSo();
                            PhanSo phanso2 = new PhanSo();
                            arrPS.Insert(1, phanso2);
                            phanso2.NhapPhanSo();
                            UpdatePS(arrPS);
                            break;
                        }
                }
            } while (true);
        }
        public static void HienPhanSo(ArrayList arrPS)
        {
            Console.Clear();
            PhanSo phanso1 = new PhanSo();
            PhanSo phanso2 = new PhanSo();
            phanso1 = (PhanSo)arrPS[0];
            phanso2 = (PhanSo)arrPS[1];
            phanso1.XuatPhanSo();
            Console.WriteLine("=================");
            phanso2.XuatPhanSo();
            Console.ReadLine();
            Program.Programming(arrPS);
        }
        public static void PhepTinh(ArrayList arrPS)
        {
            Console.Clear();
            Console.WriteLine("1. Phép Cộng");
            Console.WriteLine("2. Phép Trừ");
            Console.WriteLine("3. Phép Nhân");
            Console.WriteLine("4. Phép Chia");
            Console.WriteLine("0. Màn Hình Chính");
            Console.WriteLine("----------------------");
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch (iChucNang)
                {
                    case 0:
                        {
                            Program.Programming(arrPS);
                            break;
                        }
                    case 1: // CỘng
                        {
                            PhanSo phansoTong = new PhanSo();
                            PhanSo sohang1 = (PhanSo)arrPS[0];
                            PhanSo sohang2 = (PhanSo)arrPS[1];
                            phansoTong = sohang1 + sohang2;
                            phansoTong.XuatPhanSo();
                            Console.ReadLine();
                            ChucNang.PhepTinh(arrPS);
                            break;
                        }
                    case 2: //Trừ
                        {
                            PhanSo phansoTong = new PhanSo();
                            PhanSo sohang1 = (PhanSo)arrPS[0];
                            PhanSo sohang2 = (PhanSo)arrPS[1];
                            phansoTong = sohang1 - sohang2;
                            phansoTong.XuatPhanSo();
                            Console.ReadLine();
                            ChucNang.PhepTinh(arrPS);
                            break;
                        }
                    case 3: //Nhân
                        {
                            PhanSo phansoTong = new PhanSo();
                            PhanSo sohang1 = (PhanSo)arrPS[0];
                            PhanSo sohang2 = (PhanSo)arrPS[1];
                            phansoTong = sohang1 * sohang2;
                            Console.ReadLine();
                            ChucNang.PhepTinh(arrPS);
                            break;
                        }
                    case 4:
                        {
                            PhanSo phansoTong = new PhanSo();
                            PhanSo sohang1 = (PhanSo)arrPS[0];
                            PhanSo sohang2 = (PhanSo)arrPS[1];
                            phansoTong = sohang1 / sohang2;
                            phansoTong.XuatPhanSo();
                            Console.ReadLine();
                            ChucNang.PhepTinh(arrPS);
                            break;
                        }
                }
            } while (true);
        }
        public static void SoSanh(ArrayList arrPS)
        {
            Console.Clear();
            Console.WriteLine("1. Bằng ==");
            Console.WriteLine("2. Lớn Hơn >");
            Console.WriteLine("3. Nhỏ Hơn <");
            Console.WriteLine("4. Lớn Hơn or Bằng >=");
            Console.WriteLine("5. Nhỏ Hơn or Bằng <=");
            Console.WriteLine("0. Màn Hình Chính");
            Console.WriteLine("----------------------");
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch (iChucNang)
                {
                    case 0:
                        {
                            Program.Programming(arrPS);
                            break;
                        }
                    case 1://Bằng ==
                        {
                            PhanSo ps1 = (PhanSo)arrPS[0];
                            PhanSo ps2 = (PhanSo)arrPS[1];
                            if (ps1 == ps2)
                            {
                                Console.WriteLine("Phân số 1 = Phân số 2");
                                Console.ReadLine();
                                ChucNang.SoSanh(arrPS);
                            }
                            else
                                Console.WriteLine("Phân số 1 không = Phân số 2");
                            break;
                        }
                    case 2: //2. Lớn Hơn >
                        {
                            PhanSo ps1 = (PhanSo)arrPS[0];
                            PhanSo ps2 = (PhanSo)arrPS[1];
                            if (ps1 > ps2)
                            {
                                Console.WriteLine("Phân số 1 > Phân số 2");
                                Console.ReadLine();
                                ChucNang.SoSanh(arrPS);
                            }
                            else
                                Console.WriteLine("Phân số 1 không > Phân số 2");
                                Console.ReadLine();
                                ChucNang.SoSanh(arrPS);
                            break;
                        }
                    case 3: // Nhỏ Hơn <
                        {
                            PhanSo ps1 = (PhanSo)arrPS[0];
                            PhanSo ps2 = (PhanSo)arrPS[1];
                            if (ps1 < ps2)
                            {
                                Console.WriteLine("Phân số 1 < Phân số 2");
                                Console.ReadLine();
                                ChucNang.SoSanh(arrPS);
                            }
                            else
                                Console.WriteLine("Phân số 1 không < Phân số 2");
                                Console.ReadLine();
                                ChucNang.SoSanh(arrPS);
                            break;
                        }
                    case 4:// Lớn Hơn or Bằng >=
                        {
                            PhanSo ps1 = (PhanSo)arrPS[0];
                            PhanSo ps2 = (PhanSo)arrPS[1];
                            if (ps1 >= ps2)
                            {
                                Console.WriteLine("Phân số 1 >= Phân số 2");
                                Console.ReadLine();
                                ChucNang.SoSanh(arrPS);
                            }
                            else
                                Console.WriteLine("Phân số 1 không >= Phân số 2");
                            Console.ReadLine();
                            ChucNang.SoSanh(arrPS);
                            break;
                        }
                    case 5:// Nhỏ Hơn or Bằng <=
                        {
                            PhanSo ps1 = (PhanSo)arrPS[0];
                            PhanSo ps2 = (PhanSo)arrPS[1];
                            if (ps1 <= ps2)
                            {
                                Console.WriteLine("Phân số 1 <= Phân số 2");
                                Console.ReadLine();
                                ChucNang.SoSanh(arrPS);
                            }
                            else
                                Console.WriteLine("Phân số 1 không <= Phân số 2");
                                Console.ReadLine();
                                ChucNang.SoSanh(arrPS);
                            break;
                        }
                }
            } while (true);
        }
    }
}

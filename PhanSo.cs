using System;

namespace TinhToanPhanSo
{
    class PhanSo
    {
        int TuSo;
        public void setTuSo(int TuSo) {this.TuSo = TuSo;}
        public int getTuSo() {return TuSo;}

        int MauSo;
        public void setMauSo(int MauSo) {
            if(MauSo != 0)
                this.MauSo = MauSo;
        }
        public int getMauSo() {return MauSo;}

        public PhanSo(int TuSo, int MauSo)
        {
            this.TuSo = TuSo;
            this.MauSo = MauSo;
        }
        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }

        public static int UocChungLonNhat(int a, int b) // Tìm ra ước chung sai rồi
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return UocChungLonNhat(b, a % b);
            }
        }
        public void NhapPhanSo()
        {
            Console.WriteLine("Nhập Tử Số");
            TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Mẫu Số");
            MauSo = int.Parse(Console.ReadLine());
        }
        public void XuatPhanSo()
        {
            Console.WriteLine(getTuSo());
            Console.WriteLine("---");
            Console.WriteLine(getMauSo());
        }
        public void XuatPhanSo(int TuSo, int MauSo)
        {
            Console.WriteLine(TuSo);
            Console.WriteLine("---");
            Console.WriteLine(MauSo);
        }

        public void NghichDao()
        {
            int TuSoDao = MauSo;
            int MauSoDao = TuSo;
            Console.WriteLine("Phân số nghịch đảo là: ");
            Console.WriteLine(TuSoDao);
            Console.WriteLine("--");
            Console.WriteLine(MauSoDao);
        }

        void RutGon()
        {
            int UocChungLaGi;
            if (TuSo > MauSo)
            {
                UocChungLaGi = UocChungLonNhat(TuSo, MauSo);
            }
            else
            {
                UocChungLaGi = UocChungLonNhat(MauSo, TuSo);
            }
            int TuSoSauRutGon = TuSo / UocChungLaGi;

            int MauSoSauRutGon = MauSo / UocChungLaGi;

            this.XuatPhanSo(TuSoSauRutGon, MauSoSauRutGon);
        }
        public int mMauSoChung(PhanSo ps) // Mẫu Số Chung của this và ps
        {
            return this.getMauSo() * ps.getMauSo();
        }
        static void QuyDongMau(PhanSo a, PhanSo b)
        {
            int MauSoChung = a.mMauSoChung(b);

            PhanSo ps1m = new PhanSo();
            PhanSo ps2m = new PhanSo();
            ps2m.setMauSo(MauSoChung);
            ps1m.setMauSo(MauSoChung);
            ps1m.setTuSo(a.getTuSo() * b.getMauSo());
            ps2m.setTuSo(b.getTuSo() * a.getMauSo());
            a.setTuSo(ps1m.getTuSo());
            a.setMauSo(ps1m.getMauSo());
            b.setTuSo(ps2m.getTuSo());
            b.setMauSo(ps2m.getMauSo());
        }

        // Cộng
        public static PhanSo operator+ (PhanSo a, PhanSo b)
        {
            PhanSo phanso = new PhanSo();
            QuyDongMau(a, b);
            phanso.setTuSo(a.getTuSo() + b.getTuSo());
            phanso.setMauSo(a.getMauSo());
            return phanso;
        }

        //Trừ
        public static PhanSo operator- (PhanSo a, PhanSo b)
        {
            PhanSo phanso = new PhanSo();
            QuyDongMau(a, b);
            phanso.setTuSo(a.getTuSo() - b.getTuSo());
            phanso.setMauSo(a.getMauSo());
            return phanso;
        }

        //Nhân
        public static PhanSo operator* (PhanSo a, PhanSo b)
        {
            PhanSo phanso = new PhanSo();
            phanso.setTuSo(a.getTuSo() * b.getTuSo());
            phanso.setMauSo(a.getMauSo() * b.getMauSo());
            phanso.RutGon();
            return phanso;
        }

        //Chia
        public static PhanSo operator/ (PhanSo a, PhanSo b)
        {
            PhanSo phanso = new PhanSo();
            phanso.setTuSo(a.getTuSo() * b.getMauSo());
            phanso.setMauSo(a.getMauSo() * b.getMauSo());
            phanso.RutGon();
            return phanso;
        }

        //So sánh
        //Lớn Hơn Nhỏ Hơn
        public static bool operator> (PhanSo a, PhanSo b)
        {
            bool status = false;
            QuyDongMau(a, b);
            if(a.getTuSo() > b.getTuSo())
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            else
                Console.WriteLine("{0} không > {1}", a, b);
            return status;
        }
        public static bool operator< (PhanSo a, PhanSo b)
        {
            bool status = false;
            return status;
        }

        //Bằng
        public static bool operator== (PhanSo a, PhanSo b)
        {
            bool status = false;
            if(a.TuSo * b.MauSo == a.MauSo * b.TuSo) //định lý
            {
                status = true;
            }
            return status;
        }
        public static bool operator != (PhanSo a, PhanSo b)
        {
            bool status = false;
            if (a.TuSo * b.MauSo != a.MauSo * b.TuSo)
            {
                status = true;
            }
            return status;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
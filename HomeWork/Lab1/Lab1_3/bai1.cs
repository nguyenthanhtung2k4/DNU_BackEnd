using System;
using Lab1;
using System.Collections.Generic;

// public class bai1
// {
     public class CanBo{
        public string HoTen{get; set;}
        public int NamSinh{get; set;}
        public string GioiTinh{get; set;}
        public string DiaChi{get; set;}
        public CanBo(string hoTen, int namSinh, string gioiTinh, string diaChi){
            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }
        public virtual void LayThongTin(){
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Nam sinh: {NamSinh}");
            Console.WriteLine($"Gioi tinh: {GioiTinh}");
            Console.WriteLine($"Dia chi: {DiaChi}");
        }
        public virtual void NhapThongTin(){
            Console.WriteLine("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? "None";
            Console.WriteLine("Nhap nam sinh: ");
            try
            {
                NamSinh = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (FormatException)
            {
                Console.WriteLine("Nam sinh phai la mot so nguyen!");
            }
            catch (Check_so){
                Console.WriteLine("Nam sinh phai la mot so nguyen duong!");
            }
            catch (Exception)
            {
                Console.WriteLine("Da xay ra loi.");    
            }
            Console.WriteLine("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine() ?? "Chua co gioi tinh";
            Console.WriteLine("Nhap dia chi: ");
            DiaChi = Console.ReadLine() ?? "Chua co dia chi";
        }
    }
    class NhanVien:CanBo{
        public string CongViec{get; set;}
        public NhanVien(string hoTen, int namSinh, string gioiTinh, string diaChi, string congViec):base(hoTen, namSinh, gioiTinh, diaChi){
            CongViec = congViec;
        }
        public override void LayThongTin(){
            base.LayThongTin();
            Console.WriteLine($"Cong viec: {CongViec}");
        }
        public override void NhapThongTin(){
            base.NhapThongTin();
            Console.WriteLine("Nhap cong viec: ");
            CongViec = Console.ReadLine() ?? "Chua co cong viec";
        }
    }
    class CongNhan:CanBo{
        public string Bac{get; set;}
        public CongNhan(string hoTen, int namSinh, string gioiTinh, string diaChi, string bac):base(hoTen, namSinh, gioiTinh, diaChi){
            Bac = bac;
        }
        public override void LayThongTin(){
            base.LayThongTin();
            Console.WriteLine($"Bac: {Bac}");
        }
        public override void NhapThongTin(){
            base.NhapThongTin();
            Console.WriteLine("Nhap bac: ");
            Bac = Console.ReadLine() ?? "Chua co bac";
        }
    }
    class KySu:CanBo{
        public string NganhDaoTao{get; set;}
        public KySu(string hoTen, int namSinh, string gioiTinh, string diaChi, string nganhDaoTao):base(hoTen, namSinh, gioiTinh, diaChi){
            NganhDaoTao = nganhDaoTao;
        }
        public override void LayThongTin(){
            base.LayThongTin();
            Console.WriteLine($"Nganh dao tao: {NganhDaoTao}");
        }
        public override void NhapThongTin(){
            base.NhapThongTin();
            Console.WriteLine("Nhap nganh dao tao: ");
            NganhDaoTao = Console.ReadLine() ?? "Chua co nganh dao tao";
        }
    }
    public class QLCB{
        private List<CanBo> danhSachCanBo = new List<CanBo>();

        public void NhapThongTinMoi(){
            int  loai;
                Console.WriteLine("Nhap loai can bo (1: Cong nhan, 2: Ky su, 3: Nhan vien) ==> ");
                CanBo canBo;
                loai = int.Parse(Console.ReadLine() ?? "0");
                switch(loai){
                    case 1:
                        canBo = new CongNhan("", 0, "", "", "");
                        break;
                    case 2:
                        canBo = new KySu("", 0, "", "", "");
                        break;
                    case 3:
                        canBo = new NhanVien("", 0, "", "", "");
                        break;
                default:
                    Console.WriteLine("Loai can bo khong hop le!");
                    return;
                }
                canBo.NhapThongTin();
                danhSachCanBo.Add(canBo);
            
        }

        public void TimKiemTheoHoTen(){
            Console.WriteLine("Nhap ho ten can tim: ");
            string hoTen = Console.ReadLine() ?? "";
            foreach(var canBo in danhSachCanBo){
                if(canBo.HoTen.Contains(hoTen)){
                    canBo.LayThongTin();
                }
            }
        }

        public void HienThiDanhSach(){
            foreach(var canBo in danhSachCanBo){
                canBo.LayThongTin();
                Console.WriteLine("-------------------");
            }
        }

        public void Thoat(){
            Console.WriteLine("Thoat chuong trinh.");
            Environment.Exit(0);
        }
    }
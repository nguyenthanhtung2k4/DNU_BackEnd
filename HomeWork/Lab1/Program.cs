using System.Drawing;
using System.Globalization;
using Lab1;

class Program
{

    static void  useLab1_1(){
        Console.Write("Nhập số bài (1 - 10): ");
        int soBai=int.Parse(Console.ReadLine() ?? "");
        
        Lab1_1  BT= new  Lab1_1 (soBai);
    }

    static void  useLab1_2(){
        Console.Write("Nhập số bài (1 - 6): ");
        int soBai=int.Parse(Console.ReadLine() ?? "");
        Lab1_2  BT= new  Lab1_2(soBai);

    }

    static void  L3bai1(){

        QLCB quanLy=  new QLCB();
        int nhap;
        do
        {
            Console.WriteLine("[1]Nhap thong tin\n[2]Tim kiem thong tin\n[3]Hien thi danh sach[4]Thoat");
            Console.Write("Lua chon Option: ");
            int.TryParse(Console.ReadLine(),out  nhap);

            switch (nhap)
            {
                case 1:
                    quanLy.NhapThongTinMoi();
                    break;
                case 2:
                    quanLy.TimKiemTheoHoTen();
                    break;
                case 3:
                    quanLy.HienThiDanhSach();
                    break;
                case 4:
                    quanLy.Thoat();
                    break;

                default:
                    Console.WriteLine("Co ve chuc nang khong ton tai");
                    return;
            }

        } while (nhap!=4);
        
        
    }

    static void useLab1_3(){
        // L3bai1();

        // QuanLyTailieu ql=  new  QuanLyTailieu();
        // ql.Run();

        



    }
    static void Main(string[] args)
    {
        // useLab1_1();
        // useLab1_2();
        // useLab1_3();
        
        
    }


}

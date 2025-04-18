namespace Lab1;

// Lớp PhanSo biểu diễn một phân số
public class PhanSo
{
   private int tuSo, mauSo;

   // Constructor mặc định
   public PhanSo()
   {
       tuSo = 0;
       mauSo = 1;
   }

   // Constructor có tham số
   public PhanSo(int tuSo, int mauSo)
   {
       this.tuSo = tuSo;
       this.mauSo = mauSo != 0 ? mauSo : 1; // Đảm bảo mẫu số không bằng 0
   }

   // Phương thức nhập phân số
   public void Nhap()
   {
       Console.Write("Nhap tu so: ");
       tuSo = int.Parse(Console.ReadLine());
       do
       {
           Console.Write("Nhap mau so (khac 0): ");
           mauSo = int.Parse(Console.ReadLine());
       } while (mauSo == 0);
   }

   // Phương thức in phân số
   public void In()
   {
       Console.WriteLine($"{tuSo}/{mauSo}");
   }

   // Tìm ước chung lớn nhất (GCD) để rút gọn phân số
   private int GCD(int a, int b)
   {
       a = Math.Abs(a);
       b = Math.Abs(b);
       while (b != 0)
       {
           int temp = b;
           b = a % b;
           a = temp;
       }
       return a;
   }

   // Rút gọn phân số
   private void RutGon()
   {
       int gcd = GCD(tuSo, mauSo);
       tuSo /= gcd;
       mauSo /= gcd;
       if (mauSo < 0) // Đảm bảo mẫu số dương
       {
           tuSo = -tuSo;
           mauSo = -mauSo;
       }
   }

   // Cộng hai phân số
   public PhanSo Cong(PhanSo other)
   {
       int tu = this.tuSo * other.mauSo + other.tuSo * this.mauSo;
       int mau = this.mauSo * other.mauSo;
       PhanSo ketQua = new PhanSo(tu, mau);
       ketQua.RutGon();
       return ketQua;
   }
}









// // Chương trình chính
// class Program
// {
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so luong phan so:");
//        int n = int.Parse(Console.ReadLine());
//        List<PhanSo> danhSachPhanSo = new List<PhanSo>();

//        // Nhập danh sách phân số
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"Nhap phan so thu {i + 1}:");
//            PhanSo ps = new PhanSo();
//            ps.Nhap();
//            danhSachPhanSo.Add(ps);
//        }

//        // Tính tổng các phân số
//        PhanSo tong = new PhanSo(0, 1);
//        foreach (PhanSo ps in danhSachPhanSo)
//        {
//            tong = tong.Cong(ps);
//        }

//        // In kết quả
//        Console.WriteLine("Tong cac phan so la:");
//        tong.In();
//    }
// }
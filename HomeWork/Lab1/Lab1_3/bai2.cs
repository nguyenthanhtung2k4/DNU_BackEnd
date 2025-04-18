using System;
using System.Collections.Generic;

namespace Lab1;

/*
Bài 2: Một thư viện cần quản lý các tài liệu bao gồm, Sách, Tạp chí, Báo
+ Mỗi tài liệu có các thuộc tính: Mã tài liệu, Tên nhà xuất bản, Số bản phát hành.
+ Các loại sách cần quản lý: Tên tác giả, số trang
+ Các tạp chí cần quản lý: Số phát hành, tháng phát hành
+ Các báo cần quản lý: ngày phát hành.
1. Xây dựng các lớp để quản lý các loại tài liệu trên sao cho việc sử dụng lại được nhiều nhất.
2. Xây dựng lớp QuanLyTailieu cài đặt các phương thức thực hiện các công việc sau:
- Nhập thông tin về các tài liệu (Hỏi người dùng muốn nhập thông tin cho loại tài liệu
nào: Sách, Tạp chí hay Báo và nhập đúng thông tin cho loại tài liệu đó).
- Hiển thị thông tin về các tài liệu
- Tìm kiếm tài liệu theo loại
- Thoát khỏi chương trình
*/

public class TaiLieu
{
    public string MTL { get; set; }
    public string TenNSX { get; set; }
    public int SoPhatHanh { get; set; }

    public TaiLieu(string matailieu, string nsx, int phathanh)
    {
        MTL = matailieu;
        TenNSX = nsx;
        SoPhatHanh = phathanh;
    }

    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Mã tài liệu: {MTL}");
        Console.WriteLine($"Tên nhà xuất bản: {TenNSX}");
        Console.WriteLine($"Số bản phát hành: {SoPhatHanh}");
    }

    public virtual void NhapThongTin()
    {
        Console.Write("Nhập mã tài liệu: ");
        MTL = Console.ReadLine() ?? "";
        Console.Write("Nhập tên nhà xuất bản: ");
        TenNSX = Console.ReadLine() ?? "";
        Console.Write("Nhập số bản phát hành: ");
        if (int.TryParse(Console.ReadLine(), out int soPhatHanh))
        {
            SoPhatHanh = soPhatHanh;
        }
        else
        {
            Console.WriteLine("Số bản phát hành không hợp lệ. Đã đặt giá trị mặc định là 0.");
            SoPhatHanh = 0;
        }
    }
}

class Sach : TaiLieu
{
    public string Tentacgia { get; set; }
    public int Trang { get; set; }

    public Sach(string matailieu, string nsx, int phathanh, string tentacgia, int trang) : base(matailieu, nsx, phathanh)
    {
        Trang = trang;
        Tentacgia = tentacgia;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Tên tác giả: {Tentacgia}");
        Console.WriteLine($"Số trang: {Trang}");
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhập tên tác giả: ");
        Tentacgia = Console.ReadLine() ?? "";
        Console.Write("Nhập số trang: ");
        if (int.TryParse(Console.ReadLine(), out int trang))
        {
            Trang = trang;
        }
        else
        {
            Console.WriteLine("Số trang không hợp lệ. Đã đặt giá trị mặc định là 0.");
            Trang = 0;
        }
    }
}

class TapChi : TaiLieu
{
    public int SoPhatHanhTapChi { get; set; }
    public int ThangPhatHanh { get; set; }

    public TapChi(string matailieu, string nsx, int sobanphathanh, int sophathhanhtapchi, int thangphathhanh) : base(matailieu, nsx, sobanphathanh)
    {
        SoPhatHanhTapChi = sophathhanhtapchi;
        ThangPhatHanh = thangphathhanh;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Số phát hành tạp chí: {SoPhatHanhTapChi}");
        Console.WriteLine($"Tháng phát hành: {ThangPhatHanh}");
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhập số phát hành tạp chí: ");
        if (int.TryParse(Console.ReadLine(), out int soPhatHanhTapChi))
        {
            SoPhatHanhTapChi = soPhatHanhTapChi;
        }
        else
        {
            Console.WriteLine("Số phát hành tạp chí không hợp lệ. Đã đặt giá trị mặc định là 0.");
            SoPhatHanhTapChi = 0;
        }
        Console.Write("Nhập tháng phát hành: ");
        if (int.TryParse(Console.ReadLine(), out int thangPhatHanh))
        {
            ThangPhatHanh = thangPhatHanh;
        }
        else
        {
            Console.WriteLine("Tháng phát hành không hợp lệ. Đã đặt giá trị mặc định là 0.");
            ThangPhatHanh = 0;
        }
    }
}

class Bao : TaiLieu
{
    public DateTime NgayPhatHanh { get; set; }

    public Bao(string matailieu, string nsx, int sobanphathanh, DateTime ngayphathhanh) : base(matailieu, nsx, sobanphathanh)
    {
        NgayPhatHanh = ngayphathhanh;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Ngày phát hành: {NgayPhatHanh.ToShortDateString()}");
    }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhập ngày phát hành (dd/mm/yyyy): ");
        if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngayPhatHanh))
        {
            NgayPhatHanh = ngayPhatHanh;
        }
        else
        {
            Console.WriteLine("Ngày phát hành không hợp lệ. Đã đặt ngày mặc định là ngày hiện tại.");
            NgayPhatHanh = DateTime.Now;
        }
    }
}

class QuanLyTailieu
{
    private List<TaiLieu> danhSachTaiLieu = new List<TaiLieu>();

    public void NhapTaiLieu()
    {
        Console.WriteLine("Chọn loại tài liệu muốn nhập:");
        Console.WriteLine("1. Sách");
        Console.WriteLine("2. Tạp chí");
        Console.WriteLine("3. Báo");
        Console.Write("Nhập lựa chọn: ");
        string choice = Console.ReadLine()?? "";

        switch (choice)
        {
            case "1":
                Sach sach = new Sach("", "", 0, "", 0);
                Console.WriteLine("Nhập thông tin Sách:");
                sach.NhapThongTin();
                danhSachTaiLieu.Add(sach);
                break;
            case "2":
                TapChi tapChi = new TapChi("", "", 0, 0, 0);
                Console.WriteLine("Nhập thông tin Tạp chí:");
                tapChi.NhapThongTin();
                danhSachTaiLieu.Add(tapChi);
                break;
            case "3":
                Bao bao = new Bao("", "", 0, DateTime.Now);
                Console.WriteLine("Nhập thông tin Báo:");
                bao.NhapThongTin();
                danhSachTaiLieu.Add(bao);
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }

    public void HienThiDanhSachTaiLieu()
    {
        Console.WriteLine("\n--- Danh sách tài liệu ---");
        if (danhSachTaiLieu.Count == 0)
        {
            Console.WriteLine("Thư viện chưa có tài liệu nào.");
            return;
        }
        foreach (var taiLieu in danhSachTaiLieu)
        {
            taiLieu.HienThiThongTin();
            Console.WriteLine("-----------------------");
        }
    }

    public void TimKiemTheoLoai()
    {
        Console.WriteLine("Chọn loại tài liệu muốn tìm kiếm:");
        Console.WriteLine("1. Sách");
        Console.WriteLine("2. Tạp chí");
        Console.WriteLine("3. Báo");
        Console.Write("Nhập lựa chọn: ");
        string choice = Console.ReadLine() ?? "";

        List<TaiLieu> ketQuaTimKiem = new List<TaiLieu>();

        switch (choice)
        {
            case "1":
                Console.WriteLine("\n--- Kết quả tìm kiếm Sách ---");
                foreach (var taiLieu in danhSachTaiLieu)
                {
                    if (taiLieu is Sach)
                    {
                        taiLieu.HienThiThongTin();
                        Console.WriteLine("-----------------------");
                        ketQuaTimKiem.Add(taiLieu);
                    }
                }
                break;
            case "2":
                Console.WriteLine("\n--- Kết quả tìm kiếm Tạp chí ---");
                foreach (var taiLieu in danhSachTaiLieu)
                {
                    if (taiLieu is TapChi)
                    {
                        taiLieu.HienThiThongTin();
                        Console.WriteLine("-----------------------");
                        ketQuaTimKiem.Add(taiLieu);
                    }
                }
                break;
            case "3":
                Console.WriteLine("\n--- Kết quả tìm kiếm Báo ---");
                foreach (var taiLieu in danhSachTaiLieu)
                {
                    if (taiLieu is Bao)
                    {
                        taiLieu.HienThiThongTin();
                        Console.WriteLine("-----------------------");
                        ketQuaTimKiem.Add(taiLieu);
                    }
                }
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }

        if (ketQuaTimKiem.Count == 0)
        {
            Console.WriteLine("Không tìm thấy tài liệu nào thuộc loại này.");
        }
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\n--- Quản lý thư viện ---");
            Console.WriteLine("1. Nhập thông tin tài liệu");
            Console.WriteLine("2. Hiển thị thông tin tài liệu");
            Console.WriteLine("3. Tìm kiếm tài liệu theo loại");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn: ");
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    NhapTaiLieu();
                    break;
                case "2":
                    HienThiDanhSachTaiLieu();
                    break;
                case "3":
                    TimKiemTheoLoai();
                    break;
                case "4":
                    Console.WriteLine("Thoát khỏi chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }
}

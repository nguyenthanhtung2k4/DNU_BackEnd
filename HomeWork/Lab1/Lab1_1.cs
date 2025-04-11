namespace Lab1;
using System.IO.Compression;
using System.Reflection.Metadata;
using System.Threading.Tasks;

public class Lab1_1
{
    public Lab1_1(int bai)
    {
        Console.WriteLine($"\t\tDang vao bai {bai}\n\n");
        switch (bai)
        {
            case 1: Bai1(); break;
            case 2: Bai2(); break;
            case 3: Bai3(); break;
            case 4: Bai4(); break;
            case 5: Bai5(); break;
            case 6: Bai6(); break;
            case 7: Bai7(); break;
            case 8: Bai8(); break;
            case 9: Bai9(); break;
            case 10: Bai10(); break;
            default:
                Console.WriteLine("Chua co bai hoac chua xu ly!");
                break;
        }
    }

    public void Bai1()
    {
        Console.Write("Nhap ten: ");
        string? ten = Console.ReadLine();

        Console.Write("Nhap tuoi: ");
        int tuoi = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");
    }

    public void Bai2()
    {
        Console.Write("Nhap dai: ");
        double dai = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap rong: ");
        double rong = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Dien tich la: {dai * rong} m^2");
    }

    public void Bai3()
    {
        Console.Write("Nhap do C: ");
        double c = double.Parse(Console.ReadLine() ?? "0");
        double f = (c * 9 / 5) + 32;
        Console.WriteLine($"Do F la: {f}");
    }

    public void Bai4()
    {
        
        Console.Write("Nhap so nguyen: ");
        int a = int.Parse(Console.ReadLine() ?? "0");

        if (a % 2 == 0)
        {
            Console.WriteLine("So chan");
        }
        else
        {
            Console.WriteLine("So le");
        }
    }

    public void Bai5()
    {
        Console.Write("Nhap so a: ");
        double a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap so b: ");
        double b = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Tong: {a + b}");
        Console.WriteLine($"Tich: {a * b}");
    }
     
    /*

        Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
        Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số
        không.
        Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
        (Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho
        400).
        Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.
        Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
        Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không
        */

    public void Bai6() {
        Console.Write("Nhap bat ki: ");
        double.TryParse(Console.ReadLine(), out double  a);
        if (a>0){
            Console.WriteLine("So Duong");

        }else{
            Console.WriteLine("So am");

        }
    }
    public void Bai7() {
        Console.WriteLine("Nhap Nam: ");
        int.TryParse(Console.ReadLine(), out  int  nam);
        if ( nam %400==0 ||  nam %4 ==0 && nam %100  !=0){

            Console.WriteLine($"Nam {nam}  ==> Nhuan");
        }else{
            Console.WriteLine($"Nam {nam}  ==> Khong phai Nhuan");

        }
        
    }

    // Viết chương trình in ra bảng cửu chương từ 1 đến 10.
    public void Bai8() {
        Console.WriteLine("bang cu chuong 1>10");
        for ( int i=1 ; i<= 10;i++){
            Console.WriteLine($"\nBang Cu Chuong {i}\n");
            for( int j=1;j<= 10; j++){
                Console.WriteLine($" {i} x {j} = {i*j}");

            }
        }
    }
    int Giaithua(int so){
        if  (so ==0){
            return 1;
        }
        return  so*Giaithua(so-1);

    }
    public void  Bai9() { 
        Console.Write("So nguyen: ");
        int.TryParse(Console.ReadLine(),  out   int  a);
        Console.WriteLine($"Gia thua  la: {Giaithua(a)}");
    
    }
    bool  nguyento(int nguyen){
        if (nguyen<2){
            return false;
        }else{
            for( int i=2;i<= nguyen; i++){
                if ( nguyen%2 ==0){
                    return false;
                }
            }
            return true;
        }
    }
    public void Bai10() {
        Console.Write("Nhap so nguyen: ");
        int.TryParse(Console.ReadLine(), out  int nguyen);
        if(nguyento(nguyen)){
            Console.WriteLine("So nguyen");
        }else{
            Console.WriteLine("Khong phai so nguyen");
        }
    }
}
    
 

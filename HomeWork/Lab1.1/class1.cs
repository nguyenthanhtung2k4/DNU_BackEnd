using System.Security.Cryptography.X509Certificates;

namespace Lab1._1;

public class Class1
{
    public  Class1(int bai){
        Console.WriteLine($"\t\tDang vao  bai {bai}\n\n");
        switch(bai){
            
            case 1: Bai1();break;
            case 2: Bai2();break;
            case 3: Bai3();break;
            case 4: Bai4();break;
            case 5: Bai5();break;
            case 6: Bai6();break;
            case 7: Bai7();break;
            case 8: Bai8();break;
            case 9: Bai9();break;
            case 10: Bai10();break;
        default:
            Console.WriteLine("Chua co bai hoac chua co bai xu ly!");
            break;
        }
        
    }
    /*Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
[tên], bạn [tuổi] tuổi!".*/

    public void Bai1()
    {
       
        string ?  ten;  int  tuoi; Console.Write(" Nhap ten: ");
        ten =  Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        tuoi = int.Parse(Console.ReadLine()?? " ");
        Console.WriteLine($"Xin chao {ten} toi  nam nay {tuoi}");
    }

/* Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
chiều rộng.
*/
    public  void Bai2(){
        double  dai, rong;
        Console.Write("Nhap  dai: ");
        dai = double.Parse(Console.ReadLine()?? " ");
        Console.Write("Nhap  rong: ");
        rong = double.Parse(Console.ReadLine()?? " ");
        Console.WriteLine($"Dien tich la: {dai*rong} m^2");

    }

/*
Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
Công thức: F = (C * 9/5) + 32
*/
    public void Bai3(){
        Console.WriteLine("Cong thuc  chuyen C ->F");
        Console.Write("Nhap C: ");
        double c = double.Parse(Console.ReadLine() ?? " ");
        double  f= ( c * 9/5 ) +32;
        Console.WriteLine($"F la: {f}");



    }



/*
Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn
hay không.
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

    public  void  Bai4(){
        
    }

    public  void  Bai5(){

    }
    public  void  Bai6(){

    }
    public  void  Bai7(){

    }
    public  void  Bai8(){

    }
    public  void  Bai9(){

    }
    public  void  Bai10(){

    }



}




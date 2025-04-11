using System;
using System.ComponentModel;
using Lab1;
public class Lab1_2
{

    public  Lab1_2(int bai){
        Console.WriteLine($"\t\tDang vao bai {bai}\n\n");
        switch (bai)
        {
            case 1: bai1(); break;
            case 2: bai2(); break;
            case 3: bai3(); break;
            case 4: bai4(); break;
            case 5: bai5(); break;
            case 6: bai6(); break;
          
            default:
                Console.WriteLine("Chua co bai hoac chua xu ly!");
                break;
        }
        
    }
    public static bool snt(int n)
    {
        if (n < 2)
        {
            return false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    public static void sort(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
    //Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
    public static void bai1()
    {

        int[] arr =  { 1,2,3,4,5,6};
        System.Console.WriteLine("Bai1: Tinh tong cac so chan trong mang.");
        int tong = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                tong += arr[i];
            }
        }
        Console.WriteLine($"Tong cac so chan trong mang la: {tong}.");
    }
    //Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử là số nguyên tố trong mảng.
    public static void bai2()
    {
        try
        {
            System.Console.WriteLine("Bai2: Kiem tra so nguyen to trong mang.");
            System.Console.WriteLine("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
                if (snt(arr[i]))
                {
                    System.Console.WriteLine($"Phan tu thu {i} voi gia tri la {arr[i]} la so nguy to\n");
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Sai dinh dang!");
        }
        catch (Check_so)
        {
            Console.WriteLine("So phai la mot so nguyen duong!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
    //Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập từ bàn phím.
    public static void bai3()
    {
        try
        {
            System.Console.WriteLine("Bai3: Dem so luong so am va so duong trong mang.");
            System.Console.WriteLine("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int[] arr = new int[n];
            int deml = 0, demc = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
                if (arr[i] > 0)
                {
                    demc++;
                }
                else
                {
                    deml++;
                }
            }
            System.Console.WriteLine($"So luong so duong la: {demc} va so luong so am la: {deml}");
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Nhap so sai dinh dang!");
        }
        catch (Exception)
        {
            System.Console.WriteLine("Da xay ra loi!");
        }
    }
    //Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
    public static void bai4()
    {
        try
        {
            System.Console.WriteLine("Bai4: Tim so lon thu hai trong mang.");
            System.Console.WriteLine("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            sort(arr, n);
            System.Console.WriteLine($"Phan tu lon thu 2 trong mang la: {arr[1]};");
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Nhap so sai dinh dang!");
        }
        catch (Exception)
        {
            System.Console.WriteLine("Da xay ra loi!");
        }
    }
    //Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
    public static void bai5()
    {
        try
        {
            System.Console.WriteLine("Bai5: Hoan vi hai so a va b.");
            System.Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine() ?? "0");
            System.Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine() ?? "0");
            int temp = a;
            a = b;
            b = temp;
            System.Console.WriteLine($"So a sau khi hoan vi la: {a} va so b la: {b}.");
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Nhap so sai dinh dang!");
        }
        catch (Exception)
        {
            System.Console.WriteLine("Da xay ra loi!");
        }
    }
    //Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
    public static void bai6()
    {
        try
        {
            System.Console.WriteLine("Bai6: Sap xep mang so thuc theo chieu tang dan.");
            System.Console.WriteLine("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine() ?? "0");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        double temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            System.Console.WriteLine("Mang sau khi sap xep la: ");
            for (int i = 0; i < n; i++)
            {
                System.Console.Write(arr[i] + " ");
            }
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Nhap so sai dinh dang!");
        }
        catch (Exception)
        {
            System.Console.WriteLine("Da xay ra loi!");
        }
    }
}
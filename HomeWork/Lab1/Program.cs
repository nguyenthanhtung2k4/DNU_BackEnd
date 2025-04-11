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

    static void  useLab1_3(){
        Lab1_3 BT =  new Lab1_3();
    }
    static void Main(string[] args)
    {
        useLab1_1();
        useLab1_2();
        useLab1_3();

        
    }


}

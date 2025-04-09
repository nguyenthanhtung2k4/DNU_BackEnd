using System;
using Lab1._1;

class Program {
    static void Main() {
        Console.WriteLine("Nhap  1 -10");
        Console.Write(" Nhap bai: "); 
        int  bai= int.Parse(Console.ReadLine()?? "");
        Class1 Lab=  new Class1(bai );
    }
}

// Vd1:  viet 1 chuong trinh nhap tu  ban phim  so  nguyen  n   tinh gia tri 1/n 


using System;

int n , fx;
Console.Write(" Nhap x = ");
try
{
    n = int.Parse(Console.ReadLine() ?? "");
    fx = 1 / fx;


    Console.WriteLine($"fx= {fx}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Loi Nhe zai!");
}

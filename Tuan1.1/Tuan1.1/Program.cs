//VD1: Viet chuong trinh nhap tu ban phim so nguyen x
//Tinh gia tri 1/x
int x, fx;
Console.Write("Nhap x = ");
try
{
    x = int.Parse(Console.ReadLine() ?? "");
    fx = 1 / x;
    Console.WriteLine($"fx = {fx}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Loi chia 0: {ex.Message}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Loi nhap lieu: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Loi: {ex.Message}");
}
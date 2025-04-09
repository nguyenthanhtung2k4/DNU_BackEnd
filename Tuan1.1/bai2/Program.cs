//  viet chuong trinh nhap  1 so  nguye n duong tu  ban  phim  xuat  ra man hi h  
//  xuat ra man honh  so  nguyen vua nhap

using System.Reflection.Metadata;
using bai2;


void Nhap()
{
    Console.Write("Nhap so  nguyen duong: ");
    try
    {
        int x = int.Parse(Console.ReadLine() ?? "");
        if ( x <= 0)
        {
                throw new Expcetioncs($"{x} la nguyen duong");//  tung ngoai  le
        }

        Console.WriteLine($"So nguyen duong la: {x}");
        
    }
    catch(  FormatException ex )
    {
        Console.WriteLine($" Loi  nhap lieu: {ex}");
        return;
    }
    catch (  Expcetioncs  ex)
    {
        Console.WriteLine(" loi nhe  zai !");
        return;
    }
    finally
    {
        Console.WriteLine(" KET THUC CHUONG TRINH! ");

    }
}

Nhap();

using Lab1_2;

class Program
{
    static  void Main(){
        Console.Write("Lua chon Bai: ");
        int.TryParse(Console.ReadLine(),out int bai );
        class2 BT=  new  class2(bai);
    }    
}
using Lab1_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập số bài (1 - 10): ");
        int soBai=int.Parse(Console.ReadLine() ?? "");
        class1 BT= new  class1(soBai);
    }
}

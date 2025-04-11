
using  System;
using System.Security.AccessControl;
using System.Threading.Tasks;
internal class Program
{
     private static async Task Main(string[] args)
    {
        // Asynchronous Programning ( lapp trinh bat dong bo)
        Console.WriteLine("Main  Method  end! ");
        await SomeMethod();

        //    lam  viec cung 1  luc 
        Task  NhantinTung =  SomeMethod();
        Task  NhantinNam=  SomeMethod();
        await Task.WhenAll(NhantinNam, NhantinTung);

        Console.WriteLine("Main end!");
        Console.ReadKey();
    }
    //  async  :  bat dong bo  ( Task) 
    //  
    public static async Task SomeMethod(){
            Console.WriteLine("SomeMethod Start: ");
            // Thread.Sleep(5000);//  gia su  5 giauy  thuc hien
            
            await Task.Delay(5000);// Delay 5 giay
            Console.WriteLine("Some Method  end! ");
        }

}
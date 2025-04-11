using System.Collections;
using Tuan1;

internal class Program
{
    private static void showItem( ArrayList list){
        // 1.1.4 Duyt ArrayList
        // Cach 1  dung for.
            /*
            for (int i  =0; i< list.Count; i++ ){
                Console.WriteLine(list[i]);

            }
            */
        // Cach2
        /*
            IEnumerator enumerator = list.GetEnumerator();
            while(enumerator.MoveNext()){
                Console.WriteLine(enumerator.Current);
            }
        */

        //  Cach 3
            foreach (var item in  list){
                Console.WriteLine(item);
            }
    }

    private static  void Swap<T>(ref T var1, ref T  var2){
        var temp=  var1;
        var1 =var2;
        var2= temp; 
        
    }



    private static void Main(string[] args)
    {
        // 1. Collection
        // 1.1. ArrayList
        // 1.1.1. Khai bao va khoi tao ArrayList
        ArrayList TenList = new ArrayList();// method 1 
        ArrayList NameList = new ArrayList()
        {
            1, "CNTT 17_15", 3.14, true
        };
        // 1.1.2. Truy xuat
        Console.WriteLine("\t\tTruy Xuat ");

        // Truy xuat cac phan tu theo index bat dau tu 0
        Console.WriteLine($"NameList[0]) = {NameList[0]}");
        Console.WriteLine($"NameList[1]) = {NameList[1]}");
        Console.WriteLine($"NameList[2]) = {NameList[2]}");

        // 1.1.3. Them phan tu
            //Add (object? value) Them value vao cuoi danh sach
            //Insert(int index, object? value): Chen value vao vtri index
            //AddRange(ICollection collection): Them collection vao cuoi danh sach
            //InsertRange(in index, ICollection collection): Chen collection vao vitri index
        Console.WriteLine("\t\t Them Phan tu");
        
        NameList.Add("New Value");
        Console.WriteLine("- Affter add ");
        showItem(NameList);
//  Chen  them  dua lieu 
        NameList.Insert(0, "Insert Value");
        Console.WriteLine("- Affter add ");
        showItem(NameList);
        

// Them   vao  list

        TenList.Add(1);
        TenList.Add(2);
        TenList.Add(3);
        //TenList = [1, 2, 3]
        NameList.AddRange(TenList);
        NameList.Insert(0, "Insert Value");
        Console.WriteLine("- Affter add ");
        showItem(NameList);
        
// insert vao truoc 
        NameList.InsertRange(0, TenList);
        NameList.Insert(0, "Insert Value");
        Console.WriteLine("- Affter add ");
        showItem(NameList);


    // 1.1.5  Xoa phan tu 
    Console.WriteLine("\t\t Xoa Phan tu");
        //  Remove(Value) :Tìm đến phần tử có giá trị =  value xóa khỏi list
        //  RemoveAT(int index) : Xóa phân tử tại vị trí index 
        // RemoveRange(int index,  int  count): Xóa Count Phần tử bắt đầu từ vị trí index
        // Clear() :  Xóa hết 
        NameList.Remove(3.14);
        Console.WriteLine(" - After Remove");
        showItem(NameList);


        NameList.RemoveAt(1);
        Console.WriteLine(" - After RemoveAt");
        showItem(NameList);


        NameList.RemoveRange(0,2);
        Console.WriteLine(" - After RemoveRange");
        showItem(NameList);


        NameList.Clear();
        Console.WriteLine(" - After Clear()");
        showItem(NameList);
    // 1.2 HashTable:  giống như json() ==> python 
        // - Lưu trữ  các phần tử dới dnagj key-Value 
        // -Key là duy nhất
        Hashtable  json= new Hashtable();
        json.Add("MSV1",1771020729);
        json.Add("MSV2",1771020728);
        json.Add("MSV3",1771020720);

        foreach(object  j in  json){
            Console.WriteLine(j); 

        }
        //Remove(key)  Xóa phần tử:
        json.Remove("MSV1");

        // name_Json["Key"] : Truy xuất đến giá  của phần tử  thôngqua key
        Console.WriteLine($"[MSV1] = {json["MSV1"]}");
        
        // Lay  keys ( Lay  value )
        foreach(object  j in  json.Keys){
            Console.WriteLine(j); 

        }

    //  1.3  SortedList
        //  Giônhs nhue  Hastable  nhngw được tự  động sắp xếp các phần tử theo  key
        // Truy vấn đến các phần tử có thể thông qua cả key và index

    // 2 Genrics 
        // Genrics là một kiểu dữ liệu  đại diện,  khi  nào code được thực thi thì mới cần xác định dữ liệu  cụ thể
        // 2.1 Class Grenrics 
            // Khai  bao va khoi  tao
            ClassGenrics<int> classInt= new ClassGenrics<int>(1,2);
            ClassGenrics<double> classDouble= new ClassGenrics<double>(1.2,2.11);
            ClassGenrics<string> classstring= new ClassGenrics<string>("a","b");

            Console.WriteLine($"Gia tri: {classInt.Property1}");
            classInt.Property1=20;
            Console.WriteLine($"Gia tri new: {classInt.Property1}");

       

        // 2.2 Method Genrics
        


    }
    
}
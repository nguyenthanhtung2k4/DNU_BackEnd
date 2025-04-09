// 1.Khai  báo  biến  
int? x  =  null ; //  x  có thể chứa null
Console.WriteLine("x: "+x1);


//2.  Toán tử hợp nhất  null : ?? 
int? a=  5 ;
int b =  a ??  10;
Console.WriteLine(" b = "+ b );

// 3. Chuỗi nội suy 

string ten = "tung";
int tuoi=  20;
	//  Cach1
string s= " Hello "+ ten + " tuoi  toi là "+ tuoi;
	// Cach2 
string s =$"Xin chao {ten} tuoi toi la {tuoi}";




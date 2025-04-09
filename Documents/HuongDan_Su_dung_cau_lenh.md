Ok, mình sẽ hướng dẫn bạn cách chạy C# trên Visual Studio Code (VS Code) một cách đơn giản và chi tiết nhất cho người mới bắt đầu nhé! 🧠✨
# Câu lệnh  tạo  projcet +  chạy  project
✅ Bước 1: Cài đặt .NET SDK
Visual Studio Code không có sẵn compiler cho C#, nên bạn phải cài .NET SDK trước.

👉 Truy cập: https://dotnet.microsoft.com/download

Chọn bản .NET SDK mới nhất (không phải "Runtime")

Cài xong, mở terminal (CMD hoặc PowerShell), gõ:

```bash
dotnet --version
```
Nếu thấy ra số phiên bản là OK ✅

✅ Bước 2: Cài đặt Visual Studio Code
Tải và cài tại: https://code.visualstudio.com/

✅ Bước 3: Cài Extension cho C#
Mở Visual Studio Code → vào Extensions (Ctrl + Shift + X)
Tìm và cài:

C# (tên chính xác là C# for Visual Studio Code (powered by OmniSharp))

(Tùy chọn) .NET Install Tool (nếu chưa có)

✅ Bước 4: Tạo project C# đầu tiên
Mở terminal trong VS Code (Ctrl + `), chạy:

```bash
dotnet new console -n MyFirstApp
```
Giải thích:

dotnet new console: tạo project console (có file Program.cs)

-n MyFirstApp: đặt tên thư mục/project là "MyFirstApp"

Sau đó:

```bash
cd MyFirstApp
```
✅ Bước 5: Mở folder trong VS Code
```bash
code .
```

(Câu lệnh code . sẽ mở VS Code trong thư mục hiện tại. Nếu không chạy được, bạn cần bật code command trong VS Code.)
✅ Bước 6: Chạy chương trình
Chạy bằng terminal:

```bash
dotnet run
```
Bạn sẽ thấy dòng:
```
==> Hello, World!
```
(Vì mặc định trong Program.cs có sẵn câu Console.WriteLine("Hello, World!");)

# Tạo project  bằng  Tay ( trên visual code)

Trước tiên phải làm thêm  về 
- Nhấn ctr+p nhập:

Bước1:
```
>.NET Creat project
``` 
Bước2:
nhập tiếp
```
ConSole.App
```
vậy là xong. 

```bash
dotnet new sln -n MySolution             # Tạo file solution .sln
dotnet new console -n App                # Tạo project console
dotnet new classlib -n MyLib             # Tạo thư viện/class lib
dotnet new class -n MyLib             # Tạo thư viện/class
# ////////C1
    dotnet sln MySolution.sln add App/App.csproj MyLib/MyLib.csproj   # Thêm vào solution
# ////////C2
    dotnet sln add  App/App.csproj MyLib/MyLib.csproj   # Thêm vào solution
# xoa  1 project
dotnet sln MySolution.sln remove MyLib/MyLib.csproj
# xoa  1 file
    del MyClass.cs       # Windows
    rm MyClass.cs        # Linux/macOS


```
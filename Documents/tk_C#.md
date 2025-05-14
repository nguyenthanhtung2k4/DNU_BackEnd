




#MVC: 
- Là một mẫu thiêgs kế  đuiocw sủ du gj tỏng kũ thuật phần mềm.
## Kiến  trúc : 
* ``Coltroller``: 
    - Controller : Nhận yêu cầu từ use.
    - Xử lý và xây dựng models phù hợp
    - Chuyển models sang View để hiện thị. 
*  ``View``: Hiện thị giao diện
* ``Models`` : Chứa thư viện. 


##  Dependency  infection
- Contrucstor  injection: 
- propheerty 
- mether

         Suwr dungj  DI CONTERNER
         Middleare  : Chung gia n sử lý các yêu cầu http  (  câu hỏi tại sao lại cần dùng đến nó )
            ->  Yêu cầu sử dụng nó:  cần đăng lý program.cs 
                Các middleweare  có sẵn :
                    Use
            


            Cau lenh ussing trong csHTML.(  tim  hieu )

# Controller:
## Interface trả về từ Controller: 

Interface | Mô tả |
-----------|------|
IActionResult | Dùng cho ASP.NET Core MVC hoặc Razor Pages
ActionResult<T> | Generic, hỗ trợ vừa trả về T vừa trả về IActionResult
Task<IActionResult> | Dùng cho các Action bất đồng bộ (async)
IResult | Dùng trong Minimal API (ASP.NET Core 6+)
HttpResponseMessage | Dùng trong ASP.NET Web API kiểu cũ (.NET Framework)

VD: Tất cả   về Interface
```cs
// IActionResult
public IActionResult Index()
{
    return View();
}

// ActionResult
public ActionResult<Student> GetStudent(int id)
{
    var student = db.Students.Find(id);
    if (student == null) return NotFound();
    return student; // Auto chuyển thành JsonResult
}

// Task
public async Task<IActionResult> Index()
{
    var students = await db.Students.ToListAsync();
    return View(students);
}

// MapGet
app.MapGet("/student/{id}", (int id) => 
{
    var student = new Student { Id = id, Name = "Tùng" };
    return Results.Json(student); // Đây là IResult
});

```
## Các phương thức trả về thường dùng (  ActionResults )
- `IActionResults()` == >   Kiểu trả về
    - View()
    - RedirectToAction()
    - Content()     Trả  về chuỗi  text ( text,  html)
    - NotFound()	Trả về 404
    - Ok()	Trả về 200 với dữ liệu
    - PartialView()	Trả về partial (1 phần giao diện)
    - StatusCode()	Trả về mã HTTP tùy ý
    
    - > Còn rất nhiều hàm >> Trả về tất cả các hàm bên dưới |  `(return)`


- `FileContentResult` ==> Trả về nội dung file 
    - | `return File()`
- `FilePathResult` ==> Trả về nội dung file 
    - | `return File()`
- `FileStreamResult` ==> Trả về nội dung file 
    - | `return File()`
- `JavaScriptResult` Trả về nội dung JavaScript() JavaScript()
- `JSonResult` Trả về dữ liệu dạng Json 
    - | `return  Json()`
- `RedictToResult` Chuyển sang URL mới 
    - | `return  Redirect()`
- `RedirectToRouteResult` Chuyển sang 1 action hoặc 1 action của controller khác 
    - |`return RedirectToRoute()` or `return RedirectToAction()`
- `ViewResult` Chuyển sang View để hiển thị view
    - | `return View()`
- `PartialViewResult` Chuyển sang View để hiển thị  PartialView()
    - | `return PartialView()`


## ActionSelletor
- `Cho phép` chọn đúng action method nào sẽ được gọi trong controller khi có nhiều action trùng tên hoặc trùng đường dẫn. [HTPPGet] , [HTPPPost] .... 

- `Mục đích`: Cho phép định tuyến thông minh theo nhiều điều kiện như: method HTTP (GET, POST...), route, tên action, hoặc tham số.

| Attribute             | Mô tả                                |
| --------------------- | ------------------------------------ |
| `[HttpGet]`           | Áp dụng cho request GET              |
| `[HttpPost]`          | Áp dụng cho request POST             |
| `[HttpPut]`           | Cho PUT request                      |
| `[HttpDelete]`        | Cho DELETE request                   |
| `[ActionName("...")]` | Đổi tên action hiển thị              |
| `[NonAction]`         | Đánh dấu method không phải là action |

==> ``Action Selector giúp chọn đúng action method khi request được gửi đến.
``
Vd:
```C#
//  Controller 

// Danh sách lưu tạm thời
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Tùng", Adr = "Hà Nội" },
            new Student { Id = 2, Name = "Mai", Adr = "Đà Nẵng" }
        };

        // GET: Student/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View(students);  // Truyền danh sách sang View
        }

        // GET: Student/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("Index");  // Trở về trang danh sách
        }
``` 

## Receive parameters (Tiếp nhận tham số)
- Request : Lấy dữ liệu thủ công từ toàn bộ HTTP request
- IFormCollection : 	Gửi nhiều input form, không dùng model
- Action Arguments : 	Số lượng ít tham số, đơn giản
- Model : 	Nhận dữ liệu phức tạp (form lớn, JSON)

[Tham khảo lấy ví dụ 4 tham số bên trên](../Class/Tuan3Cotrollser/Tuan3Cotrollser/Controllers/StudentController.cs)

vd:  Sử dụng  model
```C#
// C# |  Controller
        public IActionResult ReceiveWithModels(Student student)
        {
            _Student.Add(student);
            return (RedirectToAction("Index"));
        }

// cshtml | View Create

    <form asp-action="ReceiveWithModels">
        <div class="my-2">
            <label>Id</label>
        <input type="text" name="Id" class="form-control" />
        </div>
        <div class="my-2">
            <label>Name</label>
            <input type="text" name="Name" class="form-control" />
        </div>
        <div class="my-2">
            <label>Adr</label>
            <input type="text" name="Adr" class="form-control" />
        </div>
        <button class="btn btn-primary">
            Them moi
        </button>
    </form>
```

# View 
##  Razor_view
- Khi  viet   C# vao trong html  phai  co ``@{}``
vd:
```html

<!-- Cấu trúc Foreach-->
<!-- ////////////////////////////////////////////////////////////////-->
@{
    List<string> flows = new List<string>()
    {
        "lan",
        "hoa",
        "Dao"
    };
}
@foreach (var item in flows)
{
    <p class="alert  alert-danger text-black-50">Flow: @item</p>
}
```
## HTML HELPER
> HTML Helper là các phương thức trong Razor view giúp bạn tạo ra HTML một cách dễ dàng, nhanh chóng và an toàn hơn khi xây dựng form, input, label,... 

| HTML Helper        | Mô tả                                                                      | Ví dụ                                                                   |
| ------------------ | -------------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Html.BeginForm()` | Mở form HTML. Có thể chỉ định action, controller, method (GET/POST)        | `@using (Html.BeginForm("Create", "Student", FormMethod.Post)) { ... }` |
| `Html.EndForm()`   | Đóng form HTML (thường không cần dùng thủ công vì `BeginForm` đã tự xử lý) | 
||||
| `Html.TextBoxFor()`      | Tạo input type="text" liên kết với thuộc tính model | `@Html.TextBoxFor(m => m.Name)`                              |
| `Html.LabelFor()`        | Tạo nhãn label liên kết với model                   | `@Html.LabelFor(m => m.Name)`                                |
| `Html.TextAreaFor()`     | Tạo thẻ `<textarea>`                                | `@Html.TextAreaFor(m => m.Description)`                      |
| `Html.PasswordFor()`     | Input type password                                 | `@Html.PasswordFor(m => m.Password)`                         |
| `Html.HiddenFor()`       | Input ẩn                                            | `@Html.HiddenFor(m => m.Id)`                                 |
| `Html.CheckBoxFor()`     | Tạo checkbox                                        | `@Html.CheckBoxFor(m => m.IsActive)`                         |
| `Html.RadioButtonFor()`  | Tạo nút radio                                       | `@Html.RadioButtonFor(m => m.Gender, "Male")`                |
| `Html.EditorFor()`       | Tự động chọn loại input phù hợp với kiểu dữ liệu    | `@Html.EditorFor(m => m.BirthDate)`                          |
| `Html.DisplayFor()`      | Hiển thị dữ liệu (readonly)                         | `@Html.DisplayFor(m => m.Name)`                              |
| `Html.DropDownListFor()` | Tạo dropdown liên kết với model                     | `@Html.DropDownListFor(m => m.CountryId, Model.CountryList)` |
| `Html.ListBoxFor()`      | Tạo danh sách chọn nhiều                            | `@Html.ListBoxFor(m => m.SelectedRoles, Model.Roles)`        |
||
| `Html.TextBox()`      | Nhập text không liên kết model      | `@Html.TextBox("Name", "Nguyen Van A")`                      |
| `Html.Label()`        | Label thủ công                      | `@Html.Label("Name", "Tên sinh viên")`                       |
| `Html.TextArea()`     | Textarea không ràng buộc model      | `@Html.TextArea("Description", "Ghi chú")`                   |
| `Html.Password()`     | Input password không liên kết model | `@Html.Password("Pass")`                                     |
| `Html.Hidden()`       | Input hidden không liên kết model   | `@Html.Hidden("Id", "5")`                                    |
| `Html.CheckBox()`     | Checkbox thủ công                   | `@Html.CheckBox("RememberMe", true)`                         |
| `Html.RadioButton()`  | Radio thủ công                      | `@Html.RadioButton("Gender", "Male", true)`                  |
| `Html.DropDownList()` | Dropdown thủ công                   | `@Html.DropDownList("City", new SelectList(ViewBag.Cities))` |
||



- Ngoài ra bạn có thể tùy chỉnh  Attribuild
```cshtml
@Html.TextBoxFor(m => m.Name, new { @class = "form-control", placeholder = "Nhập tên" })
@Html.TextAreaFor(m => m.Note, new { rows = 5, cols = 40 })

```


VD:  html helpper
```cshtml
@model MyApp.Models.Student

@using (Html.BeginForm("Create", "Student", FormMethod.Post))
{
    <div class="form-group">
        @Html.LabelFor(m => m.Name)
        @Html.TextBoxFor(m => m.Name, new { @class = "form-control" })
        @Html.ValidationMessageFor(m => m.Name)
    </div>

    <div class="form-group">
        @Html.LabelFor(m => m.Gender)
        @Html.RadioButtonFor(m => m.Gender, "Male") Male
        @Html.RadioButtonFor(m => m.Gender, "Female") Female
    </div>

    <div class="form-group">
        @Html.LabelFor(m => m.CountryId)
        @Html.DropDownListFor(m => m.CountryId, Model.Countries, "Chọn quốc gia", new { @class = "form-control" })
    </div>

    <button type="submit" class="btn btn-primary">Gửi</button>
}
```


## Models_View 

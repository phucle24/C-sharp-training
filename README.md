# C-sharp-training
C-sharp-training - Intern Huong Viet Group

# Unit 1
Yêu cầu

Các kiểu dữ liệu nguyên thủy, kiểu dữ liệu mảng
Các phép toán được sử dụng trên các kiểu dữ liệu
Các cấu trúc rẽ nhánh, vòng lặp

Bài tập

Bài 1. Với tập số {1, 2, 52, 16, 19, 20, 233, 228}, hãy viết chương trình
a) in ra các số chẵn.
b) in ra số lớn nhất, nhỏ nhất.

Bài 2. Viết chương trình nhập vào tên đầy đủ và xuất ra chuỗi đã định dạng: In hoa chữ cái đầu của mỗi từ, bỏ các khoảng trắng không cần thiết.

Bài 3. Viết chương trình đổi năm dương lịch sang năm âm lịch.

Bài 4. Viết chương trình nhập vào một chuỗi và xuất ra số nguyên âm, phụ âm có trong chuỗi đó.

Bài 5. Viết chương trình chuyển một chuỗi thành: UPPERCASE, lowercase, Sentense Case, Captialize Each Word, tOGGLE cASE.

Bài 6. Viết chương trình tính khoảng cách từ điểm M(x;y) đến đường thẳng ax+by+c=0.

Bài 7. Viết chương trình tính tích hai phân số. Viết kết quả dạng phân số rút gọn.

Bài 8. Viết chương trình tính trung bình cộng của các số dương trong mảng đã cho.

Bài 9. Viết chương trình tính giai thừa của một số dương.

Bài 10. Viết chương trình cho biết năm đã cho có bao nhiêu ngày là thứ 6 ngày 13.

# Unit 2
Yêu cầu
Lớp và thể hiện của lớp:

Cách khai báo và khởi tạo lớp
Tổ chức lớp bằng namespace
Các bổ từ truy cập: public, protected, internal, protected internal, private
Lớp thành phần (partial class)
Các thành phần của lớp:

Thuộc tính (properties), phương thức (methods), trường dữ liệu (fields), hằng (constants), toán tử (operators), kiểu dữ liệu con (types), chỉ số (indexes), hàm tạo (constructors)

Thành phần động và thành phần tĩnh (static)

Nạp chồng phương thức (overloading method)

Kiểu dữ liệu con

Bài tập

Bài 11. Hãy xây dựng class Collection để có chương trình như sau:
Collection collection = new Collection(new object[] { "Hello", 3, 6, 73, 2, });
do
{
Console.WriteLine(collection.Current);
} while (collection.Next());
Console.ReadLine();
Kết quả:
Hello
2
6
73
2

Bài 12. Hãy thi hành class Collection để có chương trình như sau:
Collection collection = new Collection(new object[] { "Hello", 3, 6, 73, 2, });
Console.WriteLine(collection[0]);
Console.ReadLine();
Kết quả:
Hello

Bài 13. Hãy tạo một class mới giống Collection nhưng có thể duyệt mảng 2 chiều.

Bài 14. Hãy xây dựng class Fraction để có chương trình như sau:
Fraction f1 = new Fraction(2, 3), f2 = new Fraction(6, 7);
Fraction f3 = f1 + f2;
Fraction f4 = f1 - f2;
Console.WriteLine(f3);
Console.WriteLine(f4);
Console.ReadLine();
Kết quả:
32/21
-4/21

Bài 15. Hãy sửa lại class Fraction để kết quả cuối cùng là phân số tối giản.

Bài 16. Chương trình sau đây cho biết tổng số lần phương thức Service.Alert() được gọi.
Service service1 = new Service(Counter.Instance());
Service service2 = new Service(Counter.Instance());
for (int i = 0; i < 10; i++)
{
service1.Alert();
if (i % 2 == 0) service2.Alert();
}
Counter counter = Counter.Instance();
Console.WriteLine(counter.Current);
Console.ReadLine();
Kết quả:
15
Hãy thi hành các class Service, Counter để có kết quả như trên.

# Unit 3
Yêu cầu

Các đặc điểm của OOP trong C#:

Truy cập dữ liệu của lớp thông qua thuộc tính và phương thức
Lớp trừu tượng (abstract class) và giao tiếp (interface);
Kế thừa, đa hình
Bài tập

https://drive.google.com/file/d/1SWu0vAIQXTuxJq0IzrGi_bIXFwmVaWre/view?usp=sharing

# Unit 4
Yêu cầu

Kiểu tham trị và kiểu tham chiếu; kiểu Nullable; kiểu Generic.
Các kiểu dữ liệu người dùng: class, enum, struct, delegate, interface, sự kiện (events)
Các cách ép kiểu
Các tham số out, ref, params
Biểu thức lambda (lambda expression), sự kiện (event)
Phương thức mở rộng (extension method)
Bất đồng bộ
Xử lý ngoại lệ
Bài tập

Bài 1. Chuyển đổi các class ở Bài 18 - Buổi 3 thành kiểu generic.
Bài 2. Xây dựng một dự án có sử dụng các kiến thức trên.

#Note kiến thức Unit 04 : https://docs.google.com/document/d/1Ig7q1MPuG6TDnZP8bjs-kCaQVx14KjxYV1wa9_wJJ0o/edit?usp=sharing

# Unit 5
Yêu cầu

Đọc và ghi tệp tin: quản lý luồng (stream) gồm mở, đọc, ghi, đóng.

Xử lý chuỗi.
Các dữ liệu dạng tập hợp (array, collection).
Sử dụng Attributes
Bài tập

https://drive.google.com/file/d/14iBW43Cg0ddUyJURH5iHkPLmUaMnnblD/view?usp=sharing

Đính kèm: https://drive.google.com/file/d/1BayXzx9zLcgovur05m1oojyN6EZttzyZ/view?usp=sharing (log.txt)

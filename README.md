
 
 ## CT QUẢN LÝ GIÁO VIÊN ĐƠN GIẢN
 

[1. Các bước để chạy CT Quản lý Giaó Viên ](#Modau)

[2.Cách sử dụng](#sudungct)

[3. Lời Kết ](#h)


<a name="Modau"></a>
### 1.Các bước để chạy CT Quản lý Giaó Viên 

**1.1Tải tập tin QLGV.sql về và sử dụng  SQL SERVER,(KHUYẾN KHÍCH SỬ DỤNG SQL 2012 TRỞ LÊN )**

Mở tập tin vừa tải lên 

Copy dòng lệnh đầu tiên ấn excute (hoặc F5) để tạo database , và bôi đen dòng còn lại và excute (hoặc F5)  tiếp

![image](https://github.com/taochangbang123/bt1/blob/master/CHAY%20SQL.png?raw=true)

 **1.2Qua phần mềm visual studio  ( khuyến khích sử dụng VS từ 2017 )**

 Mở file visual tải lên , mở file visual studio  và chạy chương trình , Người dùng ấn start để chạy CT
 
![image](https://github.com/taochangbang123/bt1/blob/master/BAT%20DAU%20CT.png?raw=true)

CT sẽ được chạy .




<a name="sudungct"></a>
### 2.Sử dụng CT

**2.1 Sau khi start CT hiển thị như sau :**

![image](https://github.com/taochangbang123/bt1/blob/master/screenshot_1595228282.png?raw=true)

(1) Hãy nhập tên máy là sever name của SQL máy của bạn vào

(2) Nhập Tên CSDL vừa chạy

(3)  Nhập tài khoản đăng nhập của máy SQL , lưu  ý tài khoản này cần set quyền đọc , sửa ,  dữ liệu sql của mình


(4)  Nhập pass sql máy của bạn

Nếu muốn thoát CT bạn có thể ấn vào thoát và chọn yes để thoát , no để ở lại CT

![image](https://github.com/taochangbang123/bt1/blob/master/thoat%20ct.png?raw=true)

**2.2 Ấn kết nối sau khi đã kết nối dữ liệu **

+Kết Nối Thành Công CT Sẽ Báo :

![image](https://github.com/taochangbang123/bt1/blob/master/ketnoithanhcong.png?raw=true)


+Kết Nối Thất Bại CT Sẽ Báo:

![image](https://github.com/taochangbang123/bt1/blob/master/thatbai.png?raw=true)
 
 Nếu kết nối thất bại vui lòng kiểm tra lại thông tin nhập tên máy sql , tên dữ liệu , 
 
 user hay password nhập đã đúng chưa và nhập đúng lại thông tin để kết nối thành công

+ CT sau khi kết nối thành công sẽ thì dữ liệu vẫn chưa được hiển thị :

![image](https://github.com/taochangbang123/bt1/blob/master/sauhienthi.png?raw=true)

 + Ở hiện thị danh sách giáo viên**


![image](https://github.com/taochangbang123/bt1/blob/master/%E1%BA%A8N%20MENU.png?raw=true) 
 
 *Lúc không có giáo viên thanh menu hiển thị thông tin và Xóa Gv sẽ bị mờ đi


**2.2.1Cửa sổ hiển thị cơ sở giáo viên và danh sách đào tạo**
![image](https://github.com/taochangbang123/bt1/blob/master/giaovienht.png?raw=true) 

(1)  Nhấp vào để chọn cơ sở

(2) Nhấp chọn đơn vị đào tạo

(3) Sau khi chọn thì danh sách sẽ hiển thị danh sách giáo viên

(4) Để hiển thị thông tin giáo viên Nhấp chuột trái  ở Gv đó và chọn hiển thị

(5) Nhấp chuột trái  ở Gv và chọn xóa để xóa Gv khỏi danh sách

(6) Thoát CT 

![image](https://github.com/taochangbang123/bt1/blob/master/101831265_263438288225349_4441083698317623296_n.png?raw=true)

 *Từ bảng này ta có các thao tác xóa , hiển thị thông tin giáo viên ở dưới như sau :


 
 
 **2.2.2 Xóa giáo viên trong bảng danh sách**
 
 ![image](https://github.com/taochangbang123/bt1/blob/master/X%C3%93A%20GV.png?raw=true)
 
 Ở bảng danh sách giáo viên có nút xóa giáo viên nhấn vào đó
 
 Lúc chọn bạn chọn xóa , sẽ hỏi bạn thêm  1 lần nữa , nếu chắc chắn muốn xóa ấn yes , nếu không ấn no để quay về danh sách
 
 Báo Xóa Thành Công
 
 ![image](https://github.com/taochangbang123/bt1/blob/master/xoatc.png?raw=true)
 
 
 **2.2.3Hiển thị thông tin giáo viên**
 
![image](https://github.com/taochangbang123/bt1/blob/master/hi%E1%BB%83n%20th%E1%BB%8B%20th%C3%B4ng%20tin%20Gv.png?raw=true)

Khi nhấp vào hiển thị thông tin của 1  giáo viên bất kỳ sẽ hiển bảng như trên 

Thông tin ở bảng này bao gồm :  

+Họ và tên giáo viên 

+Số điện thoại

+Đơn vị đào tào

+Ghi chú

+Cơ sở của Giáo viên 

Ấn quay về để quay về danh sách giáo viên .

Kết thúc CT bằng nút thoát và chọn yes ở menu or dấu x ở góc phải màn hình


<a name="h"></a>
### 3 Lời Kết
CHƯƠNG TRÌNH QUẢN LÝ GIÁO VIÊN ĐƠN GIẢN .
Giúp chúng ta quản lý dễ dàng hơn thông tin danh sách các giáo viên ở từng đơn vị , cơ sở ,tiện ích nhưng dễ sử dụng .
Cảm ơn các bạn đã ghé xem CT của tôi.

*1 số code đc tham khảo trong bài* https://alexyangit.wordpress.com/2017/10/02/ket-noi-database-sql-server-su-dung-c/

https://csharpcanban.com/wpf-huong-dan-hien-thong-bao-truoc-khi-thoat-ung-dung.html

...



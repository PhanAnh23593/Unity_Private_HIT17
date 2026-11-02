# Bài tập về nhà buổi 2

Ba bài Console C#, dùng điều kiện, vòng lặp, mảng và hàm; không dùng List, Dictionary hoặc LINQ.

## Cách chạy

Cài .NET SDK 10, mở terminal tại thư mục gốc repository và chạy bài tương ứng:

```sh
dotnet run --project Buoi_2/Bai_1/Bai_1.csproj
dotnet run --project Buoi_2/Bai_2/Bai_2.csproj
dotnet run --project Buoi_2/Bai_3/Bai_3.csproj
```

Nhập mỗi giá trị trên một dòng theo thứ tự trong đề. Dữ liệu được giả sử đúng kiểu và trong phạm vi cho phép.

## Các trường hợp đã tự kiểm tra

- Bài 1: ví dụ mẫu; mọi đòn không vượt giáp; bị hạ ngay đòn đầu với sát thương vượt HP; HP về đúng 0 ở đòn cuối; sống sót sau tất cả các đòn; 100 đòn ở giới hạn đầu vào. Tổng HP mất không vượt HP ban đầu, dừng khi bị hạ và chỉ in đòn kết liễu khi HP bằng 0.
- Bài 2: ví dụ mẫu; một phần tử; tất cả đòn trượt; tất cả đòn trúng; nhiều đòn cùng đạt sát thương lớn nhất; 100 đòn có sát thương 1.000.
- Bài 3: ví dụ mẫu; một người chơi với tên chứa khoảng trắng; mọi người đều 0 điểm; hai người bằng điểm cao nhất; người dẫn đầu nhập cuối; 20 người đạt giới hạn điểm. Khi bằng điểm giữ người nhập trước.

Chỉ nộp mã nguồn, file project và README. Các thư mục `bin/`, `obj/`, `.vs/` và file nén được loại khỏi Git bằng `.gitignore`.

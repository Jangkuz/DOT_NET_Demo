using Repositories.Entities;

namespace Services
{
    //3-layer Architecture
    //UI-Forms ---- Services ----- Repositories ----- DB
    //MainUI ---- BookService ----- BookRepository (Book Entity)    Book Table
    //  request/response    <-----> 
    //  đưa data xuống DB           chơi trực tiếp DB: Lên, xuống
    //  lấy data từ DB show          CRUD table thực sự
    //      RAM                         DB đĩa cứng HDD/SSD

    public class BookService
    {
        public List<Book> GetAllBooks()
        {
            List<Book> arr = new List<Book>();

            arr.Add(new Book() { BookId = 15, BookName = "Đời Ngắn Đừng Ngủ Dài-Short Life Don’t Sleep Long", Description = "Mọi lựa chọn đều giá trị. Mọi bước đi đều quan trọng. Cuộc sống vẫn diễn ra theo cách của nó, không phải theo cách của ta. Hãy kiên nhẫn. Tin tưởng.", PublicationDate = "2023-01-01", Quantity = 20, Price = 5, Author = "Robin Sharma", BookCategoryId = 5 });
            arr.Add(new Book() { BookId = 16, BookName = "Mình Là Nắng, Việc Của Mình Là Chói Chang-I Am the Sun, My Job Is to Shine Bright", Description = "Đừng bỏ lỡ những ngày nắng đẹp. Đừng bỏ qua một trái tim mạnh mẽ và luôn tỏa sáng. Hãy rực rỡ theo cách của riêng mình, cho dù bạn là ai đi chăng nữa.", PublicationDate = "2018-01-01", Quantity = 20, Price = (float)4.5, Author = "Kazuko Watanabe", BookCategoryId = 5 });

            arr.Add(new Book() {BookId= 17, BookName = "Tuổi Trẻ Đáng Giá Bao Nhiêu-How Much Is Youth Worth", Description = "Tuổi trẻ đáng giá bao nhiêu?'' giúp giới trẻ dễ dàng tìm định hướng cho mình. Bởi vì, có những lúc bạn cần chủ động biến công việc thành niềm đam mê và tạo ra một bước ngoặt khác cho bản thân.", PublicationDate = "2018-01-01", Quantity = 20, Price = 6, Author = "Rosie Nguyễn",BookCategoryId= 5 });

            return arr; 
        }
    }
}

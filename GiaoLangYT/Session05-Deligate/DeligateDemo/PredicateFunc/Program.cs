namespace PredicateDelegate
{
    //MS BẢO RẰNG: NẾU HÀM NHẬN VÀO ĐÚNG 1 ĐẦU VÀO, CHỈ CÓ 1 ĐẦU VÀO VÀ HẢM TRẢ VỀ BOOL
    //MỞ RỘNG THÊM: TOÁN LOGIC, TOÁN MỆNH DỀ - CÂU PHÁT BIỂU ĐÚNG SAI
    //CÓ HÀM MỆNH ĐỀ - HÀM NHẬN 1 ĐẦU VÀO SAU ĐÓ TRẢ VỀ 1 CÂU PHÁT BIỂU đÚNG SAI, HÀM NÀY ĐƯỢC GỌI LÀ HÀM TIÊN ĐOÁN, DỰ ĐOÁN, HÀM MỆNH ĐỂ, HÀM ĐÁNH GÁI, HÀM LƯỢNG GIÁ, PREDICATE - LOGIC VỊ TỰ

    //Predicate(???) => true/false
    //hãy đoán xem ??? là đúng hay sai?

    //thay vì khai báo Func<double, bool> thì hãy khai báo là Predicate<double> là đủ


    internal class Program
    {
        static void Main(string[] args)
        {
            //C#18 viết hàm nhận vào 1 con số gpa, trả về nó lớn hơn hay bằng 8 hay ko
            Func<double, bool> f1 = a => a >= 8.0;
            Predicate<double> f2 = gpa => gpa >= 8.0;
            double x = 10.0;
            Console.WriteLine("Final fantasy: {0} >= 8.0? {1}", x, f1(x));
            Console.WriteLine("Final fantasy: {0} >= 8.0? {1}", x, f2(x));

            //LINQ TRONG COLLECTION, LIST TOÀN XÀI LAMDBA!!! FILTER DATA

            //LỆNH CUỐI
            var b = 2004.8234;
            var f = (double t) => t * t;
            Func<double, double> f3 = n => n * n * n;
            //var fLoiToang = (a, b, c) => a + b + c;
        }
    }
}

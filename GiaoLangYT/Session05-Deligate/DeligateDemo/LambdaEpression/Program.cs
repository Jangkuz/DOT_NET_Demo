namespace LambdaEpression
{
    internal class Program
    {
        delegate void PlayNumberDelegate(int x);    //nhom1 ham2 nhan65 vào 1 con , muốn làm gì với x thì làm
        //3 cách chơi hàm:
        //C1: làm 1 hàm tường minh - explicit, nhận x, làm gì đó, in ra kq - CÓ THỂ TRONG QUÁN
        //C2:   làm 1 hàm ẩn danh - anonymous method/function - implicit, éo thèm đặt tên hàm. Éo thèm viết code riêng, tất cả gom the thằng delegate, nick name.
        //C3: từ cách 2 cắt bớt code dư thừa!! => LAMBDA EXPRESION (CODE KHÁ GIỐNG EXPRESSION BODY KHI CÙNG XÀI => NHƯNG COI CHỪNG, KHÁC ĐẤY.
        //CÓ CÂU: HÀM VÔ DANH RÚT GỌN CHỈ CÒN CÁI DÂY NỊT
        //=> BIẾN THÀNH BIỂU THỨC LAMBDA
        //      BIỂU THỨC LAMBDA LÀ HÀM VÔ DANH TRONG DELEGATE
        //      HÀM VÔ DANH KO HẲN LÀ LAMBDA NẾU VIẾT ĐỦ {}
        //      LAMBDA GIỐNG EXPRESSION BODY VỀ KÝ HIỆU '=>' VÀ SỰ LƯỢC BỚT
        //          NHƯNG EXPRESSION BODY PHẢI FULL CẢ TÊN HÀM TỬ TẾ.

        static void Main(string[] args)
        {
            PlayNumberDelegate playNumber = MakeTriple;
            playNumber(3);

            //C2: LÀM BIẾNG ĐẶT CHỖ 1 HÀM TƯỜNG MÌNH, VÀO QUÁN KO NGỒI LẤY CAFE HOY
            //TAKE AWAY, HỢP ĐỒNG LUẬT SƯ - THÂN CHỦ KO ĐỂ TÊN
            //HÀM VÔ DANH - ANONYMOUS FUNCTION/METHOD
            playNumber += delegate (int x) {
                Console.WriteLine($"{x}{x}{x}{x}");
            };
            playNumber(9);

            //C3: CHỈ CÒN CÁI DÂY NỊT
            //LAMBDA EXPRESSION
            //
            playNumber += (int xxx) => Console.WriteLine($"{xxx}{xxx}{xxx}{xxx}{xxx}");
            playNumber(10);

            //C3: CHỈ CÒN CÁI DÂY NỊT MỎNG
            //LAMBDA EXPRESSION
            //
            playNumber = (a) => Console.WriteLine($"{a}{a}{a}{a}{a}");     //vòng lên định nghĩa delegate
            playNumber(68);

            //C3: CHỈ CÒN CÁI DÂY NỊT MỎNG HƠN NỮA !!!
            //LAMBDA EXPRESSION
            //
            playNumber = a => Console.WriteLine($"{a}-{a}-{a}-{a}-{a}");     //vòng lên định nghĩa delegate
            playNumber(6789);

            //HÀM POW MŨ 3 ONLY LAMBDA EPRESSION
            playNumber = ngonTrinh => Console.WriteLine($"{ngonTrinh}^3 = {Math.Pow(ngonTrinh, 3)}");
            playNumber(2);

        }
        //C1: HÀM TƯỜNG MINH:
        static void MakeTriple(int x) => Console.WriteLine($"{x}{x}{x}");
        //expression body: hàm có 1 lệnh duy nhất, ko cần ngoặc hay return
        //
    }
}

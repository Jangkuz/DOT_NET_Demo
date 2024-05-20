namespace AnonymousFunc
{
    //khai báo class Delegate map vào/đại diện cho đám hàm voi F(int), có vào ko ra
    //đại diện cho 2 hàm dưới luôn do phù hợp format style
    delegate void PlayNumberDelegate(int x);    //mapp, đại diện

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Play methods with an input and return nothing-void");
        //    PlayNumberDelegate playNumger = CloneNumbers;
        //    //mu1n goi5 CloneNumbers(5) phai3 đưa vào data
        //    //playNumber biến đại diện = tên hàm gốc, thì biến đại diện cx đưa data vào như bản gốc
        //    playNumger(5);
        //    playNumger.Invoke(3);
        //    playNumger += PowerBy2Number;
        //    playNumger.Invoke(4);
        //    playNumger.Invoke(10);
        //}
        //Hàm mà sẽ đem đi cho thằng khác gọi, đặt nick name, thì hàm để ở đâu c được miễn là nó thuộc về class, nếu là static thì chấm trực tiếp. Nếu là non static thì new rồi mới chấm.
        //OOP căn bản, ôn lại cho chắc

        //SÁNG SỚM NAY VÀ HỖI NÀY MÌNH CHỈ HỌC HÀM VOID F()
        //GIỜ HỌC THÊM HÀM CÓ THAM SỐ

        static void CloneNumbers(int n) => Console.WriteLine($"{n}{n}{n}");

        //hàm nhận vào 1 con số, in ra bình phương của nó
        static void PowerBy2Number(int x) => Console.WriteLine($"The {x}^2 = {x * x}");

        //Use anonymous Function
        //THIẾT KẾ 1 HÀM KO THÈM CÓ TÊN, CHỈ CẦN ĐẦU VÀO TUÂN THEO ĐỊNH DẠNH CỦA DELEGATE ĐÃ KHAI BÁO; VIẾT CODE NGAY TRÊN CÂU LỆNH GÁN HỢP ĐỒNG ỦY QUYỀN
        static void CloneNumberLikeGoldFormat(int x) => Console.WriteLine($"{x}{x}{x}{x}");
        //static void Main(string[] args)
        //{
        //    //      void F(int x)
        //    //PlayNumberDelegate playNum = CloneNumberLikeGoldFormat;
        //    //playNum(9);
        //    PlayNumberDelegate playNum = delegate (int x) 
        //         { Console.WriteLine($"{x}{x}{x}{x}"); 
        //         }; //ĐEM CODE NGAY ĐÂY, LÀM BIẾNG LÀM HÀM RỜI CÓ TRƯỚC | TÊN HÀM KHÔNG QUAN TRỌNG, ĐẶT GÌ CŨNG ĐƯỢC
        //            //CODE LÀ QUAN TRONG VÌ DÍNH ĐẾN XỮ LÝ
        //            //CHỮ DELEGATE Ở LỆNH GÁN CHÍNH LÀ THAY CHO TÊN HÀM LẺ LẼ RA VIẾT RIÊNG Ở CHỖ KHÁC
        //    playNum(9); //HÀM KHÔNG CÓ TÊN THÌ SAO GỌI ĐƯỢC?
        //                //=> ĐƯA TÊN ĐÓ CHO THẰNG NICK DELEGATE GIỮ GIÙM; BẢN CHẤT HÀM VẪN CÓ TÊN, LẤY TÊN NICK NAME RA DÙNG
        //                //HÀM KHÔNG CÓ TÊN, MAY QUÁ CÓ NICK ĐỂ GỌI, GỌI HÀM TOR72 LẠI QUỸ ĐẠO BÌNH THƯỜNG, ÍT NHẤT PHẢI CÓ 1 TÊN, HOẶC 2 TÊN ỦY QUYỀN
        //                //EM SINH RA ÉO CÓ TÊN, ỦY QUYỀN TÊN LUÔN - ANONYMOUS FUNCTION
        //                //HÀM VÔ DNAH, GỌI EM QUA NICK NAME - ON THE GO - TAKE A WAY
        //                //HÀM CƠ ĐỘNG NGAY Ở CHỖ GÁN HỢP ĐỒNG ỦY QUYỀN
        //}

        static void Main(string[] args)
        {
            //TUI MMUỐN CÓ HÀM MŨ 5, 10^5 = 10*10*10*10*10 = 10'0000
            //C1: làm hàm bình thường
            //c2: anonymous, biết code gán luôn cho nick name
            //PlayNumberDelegate playNum = delegate (int x)
            //                {
            //                    Console.WriteLine($"{x}^5 = {x* x * x * x * x}");
            //                };
            PlayNumberDelegate playNum = delegate (int x)
            {
                Console.WriteLine($"{x}^5 = {Math.Pow(x,5)}");
            };
            playNum(10);
        }

    }
}

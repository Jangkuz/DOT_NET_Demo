namespace ActionDelegate
{
    internal class Program
    {
        //Challenge #5: Dùng delegate built in của Microsoft
        //MICROSOFT, .NET SDK CUNG CẤP SẴN CHO TA 1 DELEGATE STYLE VOID F()
        //GỌI LÀ: Action, làm đi, hành động đi, run đi, vậy thôi, ko cần vào, ko cần ra
        //NẾU SAU NÀY BẠN CẦN LÀM VIỆC VỚI HÀM KO-VÀO-KO-RA THÌ TA KO CẦN TẠO DELEGATE
        //MÀ CÀI LUÔN Action và chỉ việc khai báo biến = trỏ đến hàm nào là xong

        //C#5: viết hàm in ra câu thông báo "8/3/2024 chúng ta của sau này"

        public delegate void NoInputNoOutputDelegate();

        static void Main(string[] args)
        {
            NoInputNoOutputDelegate f1 = delegate () { }; //Anonymous func
            NoInputNoOutputDelegate f2 = () => { }; //Expression Body
            Action f3 = () => { };  //Microsoft action

            Action f4 = ShowMessage;    //truyen62 thong61 ham2 co1 san84 ngoai2 kia
            f4.Invoke();
            Action f5 = () => Console.WriteLine("8/3/2024 chúng ta của sau này");
            f5.Invoke();
        }

        static void ShowMessage()
        {
            Console.WriteLine("Ngay2 hom6 nay Nam ra vien");
        }

    }
}

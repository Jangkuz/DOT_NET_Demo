namespace PassByDelegateV2
{
    //ngang cơ nhau: delegate, class, interface, struct
    internal class ShowBiz
    {
        //_fields, properties{get; set;}, methods: ctor, ToString()
        //một constructor default nếu Class/Khuôn ko có phễu được tạo sẵn
        //_fields, properties, methods: PUBLIC, PRIVATE, PROTECTED
        //STATIC (THUỘC VỀ CỘNG ĐỒNG), NON-STATIC (THUỘC VỀ OBJECT)
        public static void PrintJojo()
        {
            Console.WriteLine("JOJO");
            Console.WriteLine("GOLDEN WIND!!");
        }

        public static void PrintWildFire()
        {
            Console.WriteLine("We've made a choice, go fight against your fate!");
        }

        public static void PrintAshley()
        {
            Console.WriteLine("Never gonna give you up!");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#5: Print on deman - Dependency Injection style");

            //PrintOnDeman(Action f = tên-hàm)
            //PrintOnDeman(Action f = anonymous function)
            //PrintOnDeman(Action f = lambda expression)
            //PrintOnDeman(Action f = () => {})
            //PrintOnDeman(Action f = delegate () {})
            //HÀM NGOÀI ĐƯỢC TRUYỀN VÀO HÀM CHÍNH POD()
            //1 LOGIC XỬ LÍ BÊN NGOÀI ĐƯỢC PASS VÀO BÊN TRONG HÀM CHÍNH POD(???)
            //DEPENDENCY INJECTION
            //HÀM TRUYỀN VÀO HÀM CHÍNH QUA NGẢ THAM SỐ => LẬP TRÌNH HÀM - FUNCTIONAL PROGRAMMING
            //HÀM TRUYỀN VÀO HÀM CHÍNH QUA NGẢ THAM SỐ => HÀM CHÍNH LÀM GHÌ THÌ LÀM ĐI, NHỚ GỌI HÀM QUA NGẢ THAM SỐ SAU KHI CHÁN CHÊN
            //=> CALL BACK FUNCTION

            //JAVA: CÓ LAMBDA EX
            //      TRUYỀN HÀM VÀO HÀM PHẢI BAO CÁI HÀM LẠI TRONG 1 INTERFACE CHỈ CÓ DUY NHẤT 1 HÀM - INTERFACE CHỈ CÓ DUY NHẤT 1 HÀM GỌI LÀ @Functional Interface
            //          Dùng kèm kỹ thuật anonymous class

            //ĐỪNG NHẦM LẪN PASS HÀM VÀO HÀM VỚI PASS 1 OBJECT VỚI PASS 1 OBJECT VÀO HÀM
            //void PrintOnDemand(Student s) //truyền tham chiếu, truyền nhiều hảm của object; KO TRUYỀN HÀM ĐƠN NHƯ MÌNH ĐANG HỌC!!! KO LAMBDA VÀ DELEGATE GÌ CẢ
            //KO CALL BACK

            Action Fxxx = ShowBiz.PrintJojo;
            Fxxx += ShowBiz.PrintWildFire;
            Fxxx += ShowBiz.PrintAshley;

            //GỌI HÀM CHÍNH, DEPENDENCY INJECTION - TAO CHÍCH VÀO HÀM CHÍNH 3 CÁI HÀM KHÁC
            PrintOnDeman(Fxxx);

            PrintOnDeman(delegate () { Console.WriteLine("The song Carolina - By Taylor Swift"); });

            PrintOnDeman(() => { Console.WriteLine("Chúng ta của tương lai - By Sơn Tùng MTV vs Hải Tú"); });

            //DELEGATE VÀ EVENT LÀ TRI KỶ~~~~~~~
            //LOOSE COUPLING
        }

        public static void PrintOnDeman()
        {
            Console.WriteLine("This func print whatever func is loaded");
            Console.WriteLine("Call sub-methods to print...");
            ShowBiz.PrintJojo();
            ShowBiz.PrintWildFire();
            ShowBiz.PrintAshley();
            //tight coupling - hard coded.
            //Cách hay hơn: in gì thì đưa vào KO HARD CODE
            //-> LOOSE COUPLING - RẰNG BUỘC LỎNG LẺO, FLEXIBLE, ADAPTIVE
            //ĐƯA TÊN HÀM VÀO, GỌI CHO
            //TƯ DUY NÀY LÀ TƯ DUY STYLE: KIẾN TRÚC SƯ PHẦN MỀM - SOLUTION ARCHITECT - SA
        }

        public static void PrintOnDeman(Action f)
        {
            Console.WriteLine("This func print whatever func is loaded");
            Console.WriteLine("Call sub-methods to print...");
            Console.WriteLine("This is flexible printing");
            f.Invoke();
        }

    }
}

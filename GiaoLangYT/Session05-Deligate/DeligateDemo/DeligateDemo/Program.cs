namespace DeligateDemo
{
    //delegate sẽ khai báo ở bên ngoài class khác, và nằm dưới namespace/pakage
    //Solution có nhiều Project
    //Project có nhiều namespace
    //namespace có nhiều Class

    //tạo - delegate là 1 data type/class cho nhóm object phức tạp là cái đám hàm tao/I trỏ/quản lí, đại diện, tao bình đẳng với với các class/data type khác
    public delegate void X(); //X: tui là class X đại diện cho 1 đám hàm ở duói77 hay đâu đó chung style là void ???()
    //CHÍNH LÀ LỆNH KHAI BÁO CLASS VIẾT NGẮN GỌN - VIẾT NGOÀI CLASS KHÁC (NEWBIE)
    /*
     public class X [void X()] Delegate 
    {
        _fName //tên-hàm-cần-cất-trữ
        list<> danh-sách-các-tên-hàm-cùng-style
        [] mảng-các-tên-hàm-cùng-style
        public X(tên-hàm-cần-cất-trữ){
        //do X đại diện cho 1 đám hàm, đưa hàm đây tao cất trữ cho - delegate
            _fName = tên-hàm-cần-cất-trữ;
        }

        public void Invoke(){       //hàm có sẵn khi tạo class Delegate X
            _fName();   //tên hàm được cất trữ gửi vào sẽ được run = cách thêm dấu () đê run
            List<> các hàm được gọi = cách thêm () trên từng tên hàm để run()
        }
    }
     */
    //X f = value là tên hàm ở dưới, là nick name cho tên hàm ở dưới
    //      f là tên gọi khác cho cái hàm ở dưới cùng style X
    //int  x = value 10

    //KHAI BÁO BIẾN VÀ SỬ DỤNG THÌ PHẢI Ở TRONG HÀM HAY TRONG CLASS NÀO KHÁC ĐÓ!!
    // SẴN SÀNG LÀ DATA TYPE BÌNH ĐẲNG NHƯ PERSON, CAT, DOG, ETC....
    //DÙNG NHƯ DATA TYPE BÌNH THƯỜNG
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Studen s = new Student();
        //    //int       yob = 2003;
        //    //X     f1 = Tên hàm nào đó cùng stype X đã định nghĩa ở trên
        //    //      f1 trỏ đến hàm đó cùng style X
        //    //      f1 là biến OBJECT, biến THAM CHIẾU tới một cái hàm. Gọi tắt là CON TRỎ HÀM.
        //    // BIẾN THAM CHIẾU (OBJECT VARIEBLE) cần KIỂU DỮ LIỆU (DATA TYPE) 
        //    //      f1 là nick name, là đại diện, nhận ủy quyền, ủy nhiệm từ hàm khác
        //    //      f1 là con trỏ hảm, là đại diện, nhận ủy quyền, ủy nhiệm từ hàm khác
        //    //      f1 là con trỏ hàm, là biến trỏ đến 1 hàm cụ thể 
        //    //      f1 và hàm lúc này là 1
        //    //      gọi f1 cũng như gọi hàm
        //    //      dùng f1() và hàm() đều run hàm như nhau
        //    //      run qua biến ủy quyền - run gián tiếp
        //    //  vs  run trực tiếp tên hàm như 100 năm nay
        //    X f1 = new X(TellHer);  //f1 là tên gọi khác, nick name của TellHer
        //                            //f1 và TellHer là như nhau, là 1 lúc này
        //                            //f1 cũng là TellHer
        //                            //giống như sếp là NTT, etc..
        //                            //f1 trỏ TellHer, f1 là con trỏ hàm
        //                            //f1 đại diện cho TellHer, f1 là delegate
        //                            //ủy quyền
        //    X f2 = NhanEm;          //viết tắt, bỏ new cho tự nhiên như style
        //                            //để giống như int yob = 2003;
        //                            //int[] arr = new int[300]
        //                            //int[] arr = {5, 10, 15, 20};
        //                            //Student s = new Student(...);
        //                            //Student s = new (...);
        //                            //HẾT SỰC LƯU Ý, KHI GÁN BIẾN/NICK NAME CHO 1 HÀM CỤ THỂ NÀO ĐÓ
        //                            //TUYỆT ĐỐI KO ĐƯỢC GHI TÊN HÀM KÈM () DẤU NGOẶC
        //                            //VÌ GHI () LÀ RUN HÀM LUÔN RỒI
        //                            //TRONG KHI ĐÓ LỆNH X f2 = NhanEm mang ý nghĩa là đặt nick name cho 1 hàm cụ thể nào đó, gắn giá trị cho biến, giá trị hơi đặc biệt 1 tí: gái trị là 1 cái hàm; đưa tên hàm, chứ ko phải run() hàm
        //                            //NhanEm();
        //                            //TellHer();


        //    //GỌI HÀM HCAO2 NHAU HOY
        //    //GỌI TRỰC TIẾP NHƯ 2 LỆNH ĐÃ CMT - KO THÈM LÀM, TRUYỀN THỐNG R

        //    //TA GỌI QUA CON TRỎ HÀM, BIẾN DELEGATE, BIẾN NICK NAME
        //    //BIẾN F1 ĐẠI DIỆN CHO HÀM NÀO ĐÓ, GỌI HÀM TRỰC TIẾP HOẶC QUA ỦY QUYỀN
        //    f1();   //vì câu lệnh X f1 = TellHer; do đó TellHer() là chạy hàm
        //            //thì f1() cũng là chạy hàm mà là hàm TellHer()
        //            //gọi hàm gián tiếp, hàm đã được YU3 QUYỀN CHO THẰNG KHẮC CHẠY THAY VÌ TỰ CHẠY
        //            //ỦY QUYỀN, ỦY NHIỆM, ỦY THÁC, ĐẠI DIỆN => DELEGATE
        //            //DELEGATE: LÀ KĨ THUẬT ĐẶT TÊN GỌI KHÁC CHO 1 CÁI HÀM CỤ THỂ NÀO ĐÓ!!!
        //            //VÀ KHI ĐÓ HÀM CỤ THỂ ĐÓ SẼ CÓ 2 CÁCH GỌI, GỌI TRỰC TIẾP HÀM NHƯ XƯA NAY, GỌI HÀM QUA NICK NAME ỦY QUYỀN

        //    f2();

        //    //CÁCH GỌI THỨ 3: gọi qua hàm invoke được tạo sẵn. Giống .ToString()
        //    Console.WriteLine("Call message by using Invoke() method inside the X class");
        //    f1.Invoke();    //X là class có chứa nhiều hàm bên trong giống Student
        //    f2.Invoke();        


        //}

        //chơi delegate style nhiều hàm được nhồi vào biến thuộc style X
        //1 LUẬT SƯ ĐẠI DIẸN NHIỀU THÂN CHỦ
        //1 CON TRỎ TRỎ ĐA HÀM, VẨN 1 VÙNG NEW X()
        //X CÒN ĐÓNG VAI THÙNG CHỨA TÊN HÀM, BOX CHỨA TÊN HÀM, CABINET, CONTAINER
        //HƠN LÀ 1 CLASS CHỨA BÊN TRONG 1 INFO ĐƠN LẺ KIỂU PERSON, CAT, DOG
        /// <summary>
        /// /
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    X f = new X(TellHer);   //int x = 10
        //    f += NhanEm;            // x += 5, ghep 10+5
        //    f += SayHelloToSweetHeart;
        //    /*
        //     trong hàm delegate có:
        //    hàm += để ghép thêm tên các hàm vào danh sách đại diện ()
        //    => Kỹ thuật override các operator, định nghĩa lại các dấu + - * / thay vì làm trong toán học
        //    ==> Giờ toán trong object
        //     */
        //    //f là gã luật sư đại diện cho 3 thân chủ thay vì 1 - multicast delegates

        //    // GỌI 3 HÀM CÙNG LÚC
        //    //1. gọi lẻ truyền thống TellHer() NhanEm() SayHelloTo()
        //    //2. Gọi qua f(), duyệt mảng/list các tên hàm đã add() vào và () và run()
        //    //3. gọi qua f.Invoke() duyệt ...
        //    //*f trỏ tới nhiều con trỏ, mỗi con trỏ trỏ tới 1 hàm
        //    f();

        //}

        //static void Main(string[] args)
        //{
        //    X f = TellHer;  //new X(TellHer); chừa vùng memory mới đề phòng add nhiều tên hàm
        //    f += NhanEm;
        //    f += SayHelloToSweetHeart;
        //    f.Invoke();
        //}

        static void Main(string[] args)
        {
            X f = NhanEm;
            f = TellHer;    //đè con trỏ
            f();
            //TẠI 1 THỜI ĐIỂM CHỈ LƯU 1 VALUE, TÊN GỌI ỨNG 1 VALUE!!
            //TỪ BỎ THÂN CHỦ TELLHER, KÝ HỢP ĐỒNG VỚI THÂN CHỦ MỚI
            //HẾT SỨC LƯU Ý VÀ CẨN THẬN VỚI =, KHÁC +=!!!!!!!

        }

        static void TellHer() => Console.WriteLine("Cuộc sống em ổn không? Xa anh em phải hạnh phúc!!");

        static void NhanEm() => Console.WriteLine("Chúc em hạnh phúc bên người!!");

        static void SayHelloToSweetHeart() => Console.WriteLine("Bánh mì không? Hai ta cùng về một nhà");

        //còn nhiều hàm nữa trong tuông lai ở đây, mà có thể ở Project khác, .DLL khác

        static void HelloWorld() => Console.WriteLine("hello delegate");

    }
}

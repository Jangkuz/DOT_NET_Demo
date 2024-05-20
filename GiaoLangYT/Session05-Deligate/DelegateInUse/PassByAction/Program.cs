namespace PassByAction
{
    //CHALLENGE: VIẾT HÀM THẦU CÁC HÀNH ĐỘNG NÀO ĐÓ BÊN NGOÀI ĐƯA VÀO
    //          HÀM THẦU CÁC DỊCH VỤ IN ẤN NÀO ĐÓ: IN BÀI HÁT, IN SỐ, IN DÃY SỐ.....


    internal class Program
    {

        static void Main(string[] args)
        {
            DoOnDeman(() =>
            {
                Console.WriteLine("Đưa tay anh Dương cầm");
                Console.WriteLine("La là lá la~");
            });

            Action<int> f = a => { Console.WriteLine($"{a}"); };

            List<int> arr = new List<int>() { 5,7,3,4,2,345,7,24,534,74,5};
            foreach(var x in arr)
            {
                DoOtherThingsOnDeman(f, x) ;
            }
        }

        public static void DoOnDeman(Action f) //hàm dạng void F()
        {
            Console.WriteLine("Do - While - For like normal");

            //later, call back f
            f(); // or f.Invoke();

        }

        public static void DoOtherThingsOnDeman(Action<int> f, int a)
        {
            f(a);
        }
    }

}

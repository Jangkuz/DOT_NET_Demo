using System.Runtime.InteropServices;

namespace Number
{
    internal class Program
    {
        int a;
        static void Main(string[] args)
        {
            PlayWithInBuiltArrMethodV2();

        }

        public static void PlayWithInBuiltArrMethod()
        {
            List<int> arr = new (){-10, -100, 50, 2,1,5,10,13,-2};

            //dùng hàm inbuild trong list để in số theo yêu cầu
            //1. in all số
            Console.WriteLine("all===========");
            arr.ForEach(i => { Console.WriteLine(i); });
            //2. in số âm
            Console.WriteLine("<0===========");
            arr.ForEach(i => {
                if (i < 0)
                {
                    Console.WriteLine(i);
                }
            });

            //3. in số dương
            Console.WriteLine(">0===========");
            arr.ForEach(i => {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
            });

            //etc...
            //4. in ra số chia hết cho 5
            //HÀM DEMAND TRẢ VỀ LIST ĐỂ TA DUNG2 TRỰC TIẾP TAY VÌ CHỈ IN RA
            Console.WriteLine("%5==0 =============");
            List<int> temp = arr.Where(X => X%5 == 0).ToList();
            temp.ForEach(i => Console.WriteLine(i));
            foreach(var x in temp)
            {
                Console.WriteLine(x);

            }

        }

        public static void PlayWithInBuiltArrMethodV2()
        {
            List<int> arr = new() { -10, -100, 50, 2, 1, 5, 10, 13, -2 };
            Console.WriteLine("Print all");
            var result = from x in arr
                         select x;
            //CÂU QUERY GIỐNG NHƯ SQL DÙNG ĐỂ TRUY VẤN DATA TRONG RAM - LINQ THEO STYLE QUERY SYNTAX
            //RUNTIME CHẠY THÌ CONVERT VỀ LAMBDA NHƯ ĐÃ VIẾT, .WHERE(X => X>0)
            //METHOD SYNTAX 
            foreach(var x in result)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("print even");
            var resultEven = from x in arr
                             where x%2 == 0
                             select x;
            resultEven.ToList().ForEach(i => Console.WriteLine(i));
            Console.WriteLine("print odd");
            var resultOdd = from x in arr
                            where x % 2 != 0
                            select x;
            resultOdd.ToList().ForEach(i => Console.WriteLine(i));
            Console.WriteLine("print prime");
            
        }
    }
}

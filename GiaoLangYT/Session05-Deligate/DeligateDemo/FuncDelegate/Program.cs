namespace FuncDelegate
{

    //C#13: VIẾT HÀM NHẬN VÀO 1 CON SỐ, SAU ĐÓ TRẢ VỀ BÌNH PHƯƠNG CỦA NÓ
    //CÓ RETURN, KO IN RA TRONG HÀM
    delegate double OneInputOneOutputDelegate(int x);
    //                  double F(int x)
    //MS LẠI BÀO RẰNG, NẾU HÀM CÓ TRẢ VỀ GIÁ TRỊ int, long, char, string,  Student, Car, etc...
    //và hàm có thể có đầu vào hay ko, kệ, THÌ HÃY XÀI 1 DELEGATE STYLE GENERIC
    //TÊN LÀ FUNC
    //Func<int> -> hàm ko dầu vào, trả về int
    //Func<char> -> hàm ko dầu vào, trả về char
    //Func<long> -> hàm ko dầu vào, trả về long
    //Func<int, int> -> đầu vào int, trả về int
    //Func<đầu-vào-1, đầu-vào-2, ..., đầu-vào-16, đầu-ra>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#13: Method returns value");
            OneInputOneOutputDelegate f1 = ComputePow;
            int x = 4;
            Console.WriteLine($"{x} * {x} = {f1(x)}");

            //C#14: Tính bình phương của 1 con số rồi trả về kq
            Func<int, double> f2 = x => x * x;
            x = 5;
            Console.WriteLine($"{x} * {x} = {f2(x)}");


        }

        public static double ComputePow(int x)
        {
            return x * x;
        }
    }
}

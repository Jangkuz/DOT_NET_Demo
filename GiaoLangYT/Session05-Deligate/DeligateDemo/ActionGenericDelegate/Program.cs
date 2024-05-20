namespace ActionGenericDelegate
{

    //C#6: VIET61 HAM2 NHAN65 VAO2 MOT65 SO16 NGUYEN6 DUONG7, IN RA BINH2 PHUONG7 CUA3 NO1
    //  VIET61 HAM2 LE3 CO1 SAN84 NGOA82 KIA
    //  ANONYMOUS FUNC, LAMBDA EXPRESSION => XAI2 DELEGATE

    //KE63 TU27 NAY VE62 SAU, MOI64 KHI NO1I VE62 HAM2 VOID, KO DAU62 VAO2 THI2 XAI2 
    //      Action f = ....
    // KE63 TU27 NAY VE62 SAU, MOI64 KHI NOI1 VE62 HAM2 VOID, CO1 DAU62 VAO2, 1, 2, 3, 4, ... 16 DAU926 VAO2 THI2 XAI2, KHAI BAO1 DUNG2 DELEGATE CO1 SAN84, STYLE GENERIC NHU7 SAU
    //      Action<int>             f = ham2 co1 1 dau62 vao2 int
    //      Action<char>            f = ham2 co1 1 dau62 vao2 char
    //      Action<int, int>        f = ...
    //      Action<16-dau62-vao2>   f = ...

    delegate void OneInputNoOutput(int x);

    internal class Program
    {
        static void Main(string[] args)
        {
            OneInputNoOutput f1 = ComputeExponent;
            f1(7);
            //truyen26 thong16, delegate tu57 trong62, tu57 build
            Action<int> f2 = ComputeExponent;
            Console.WriteLine("C#9: Using Action<> generic on the method with up to 16 params");
            f2(1000);   //1 trieu65
            //C#10: dung2 Action<> tinh1 mu4 3 cua3 1 con so61 va2 in ra. Dung2 luon6
            //Anonymous & Lambda Ex
            Action<int> f3 = a => Console.WriteLine($"{a}^3 = {Math.Pow(a, 3)}");
            f3(3);
        }

        public static void ComputeExponent(int x)
        {
            double result = Math.Pow(x,2);
            Console.WriteLine($"{x}*{x} = {result}");
        }
    }

    
}

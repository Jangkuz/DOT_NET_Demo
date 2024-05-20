using System.Threading.Channels;

namespace Numerology
{
    // Func<something---, bool> ==> Predicate<something--->

    internal class Program
    {
        static void Main(string[] args)
        {
            //C#1: In all nội dung trong obj
            //note Internal dùng trong cùng namespace
            NumberServices.PrintOnDeman(x => Console.WriteLine($"{x}"));
            Console.WriteLine("------------------");
            //c#2: In các số âm trong obj
            NumberServices.PrintOnDeman( ngocTrinh => { 
                if(ngocTrinh < 0)
                {
                    Console.WriteLine($"{ngocTrinh}");
                }
            });
            Console.WriteLine("------------------");

            //C#3: tính tổng dựa trên điều kiện
            //check even
            Func<int, bool> e = a =>  a % 2 == 0;
            Predicate<int> e_p = a => a%2 == 0;
            //                  EXPRESSION BODY
            //check odd
            Func<int, bool> o = a => a % 2 != 0;
            Predicate<int> o_p = a => a%2 != 0;
            //check prime
            Func<int, bool> p = a => {
                for(int i = 2; i < Math.Sqrt(a); i++)
                {
                    if(a%i == 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            Predicate<int> p_p = a => {
                for (int i = 2; i < Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            NumberServices.SumOnCondition(e);
            NumberServices.SumOnCondition(e_p);
            NumberServices.SumOnCondition(o);
            NumberServices.SumOnCondition(o_p);
            NumberServices.SumOnCondition(p);
            NumberServices.SumOnCondition(p_p);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerology
{
    internal class NumberServices
    {
        static private List<int> _arr = new List<int>() { -5, -10, -11, -29, 5, 7, 3, 4, 2, 345, 7, 24, 534, 74, 5 };

        public static void PrintOnDeman(Action<int> f)
        {
            foreach (var x in _arr)
            {
                f(x);
            }//dụng cụ in linh hoạt.
            //data trong obj được mở ra cho public xài
            //linh hoạt dựa vào hàm Action<int> f đưa vào
        }

        public static void SumOnCondition(Func<int, bool> f)
        {
            Console.WriteLine("Do something~~");
            int sum = 0;
            foreach (int x in _arr)
            {
                if (f(x))
                {
                    sum += x;
                }
            }
            Console.WriteLine($"The sum is: {sum}");
        }
        public static void SumOnCondition(Predicate<int> f)
        {
            Console.WriteLine("Do something~~");
            int sum = 0;
            foreach (int x in _arr)
            {
                if (f(x))
                {
                    sum += x;
                }
            }
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    public class Cabinet<T>
    {

        private int _list = 4;
        Cabinet() { }
        public void setSomeInt(int i)
        {
            Console.WriteLine(_list);
            _list = i;
        }
    }
}

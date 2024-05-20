using Repositories.Entities;

namespace Cabinate
{
    public class Cabinate<T>   //cái tủ truyển thống chứa hồ sơ của SV và GV
    {
        //private Student[] _student = new Student[300];
        //private int _countStu = 0;

        //private Lecture[] _letures = new Lecture[300];
        //private int _countLect = 0;

        private T[] _list1 = new T[300];
        private int _count = 0;

        //public void

        public void addToCabinate(T item)
        {
            _list1[_count] = item;
            _count++;
        }

        public void printCabinate()
        {
            for(int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list1[i]);
                //gọi thầm tên em - call ToString() implicitly
            }
        }

    }
}

using Repositories.Entities;
using ServicesV2;

namespace MainUIV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Cabinet<Student> suList = new Cabinet<Student>();
            suList.addItem(new Student(1, "Anh", 2004, 8));
            suList.addItem(new Student(2, "Banh", 2005, 9));
            suList.addItem(new Student(3, "Canh", 2006, 10));
            suList.addItem(new Student(4, "Danh", 2007, 11));
            suList.addItem(new Student(5, "Eanh", 2008, 12));
            suList.printAll();
        }

        static void playWithList()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
                
            list.Add(4);
            list.Add(5);
            list.Add(6);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using Cabinate;
using Repositories.Entities;

namespace SchoolManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ranNum;
            Console.WriteLine("Hello, For now this is testing");
            Console.Write("Enter a number: ");
            ranNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("/nThe number you just entered is: {0}", ranNum);
            Cabinate<Student> su = new Cabinate<Student>();
            Cabinate<Lecture> le = new Cabinate<Lecture>();

        }
    }
}

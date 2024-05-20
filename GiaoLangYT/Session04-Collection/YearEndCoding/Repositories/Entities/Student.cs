using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Student

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YoB{ get; set; }
        public float GPA{ get; set; }

        public Student(int id, string name, int yoB, float gPA)
        {
            Id = id;
            Name = name;
            YoB = yoB;
            GPA = gPA;
        }

        public override string ToString() => $"{Id} | {Name} | {YoB} | {GPA} ";
        

    }
}

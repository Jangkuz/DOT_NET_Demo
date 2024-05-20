using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public Lecture(int id, string name, float salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString() => $"{Id} | {Name} | {Salary} ";
    }
}

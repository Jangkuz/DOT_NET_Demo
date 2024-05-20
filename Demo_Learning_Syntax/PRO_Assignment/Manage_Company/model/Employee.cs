using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Company.model
{
    public abstract class Employee
    {
        protected string empID;
        protected string empName;
        protected int baseSal;

        public Employee()
        {
            this.empID = string.Empty; 
            this.empName = string.Empty;
            this.baseSal = 0;
        }

        public Employee(string empID, string empName, int baseSal)
        {
            this.empID = empID;
            this.empName = empName;
            this.baseSal = baseSal;
        }

        public string GetEmpID()
        {
            return this.empID;
        }

        public string GetEmpName()
        {
            return this.empName;
        }

        public int GetBaseSal()
        {
            return this.baseSal;
        }

        public abstract double GetSalary();

        public override string ToString()
        {
            return this.empID + "_" + this.empName + "_" + this.baseSal;
        }

        //public int compareto(employee other)
        //{
        //    int result = -getsalary.compareto(other.getsalary);
        //    if (result == 0)
        //    {
        //        string[] split = getempname.split(' ');
        //        char empfirstname = split.last().firstordefault();
        //        split = other.getempname.split(' ');
        //        char otherempfirstname = split.last().firstordefault();
        //        result = empfirstname.compareto(otherempfirstname);
        //    }
        //    return result;
        //}
    }

}
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Company.model
{
    public class Tester : Employee
    {
        protected double bonusRate;
        protected string type;

        public Tester()
        {
            this.bonusRate = 0;
            this.type = string.Empty;
        }

        public Tester(String empID, 
            String empName, 
            int baseSal, 
            double bonusRate, 
            string type) : base(empID, empName, baseSal)
        {
            this.bonusRate = bonusRate;
            this.type = type;
        }

        public double GetBonusrate()
        {
            return this.bonusRate;
        }
        public String getType()
        {
            return this.type;
        }

        public override double GetSalary()
        {
            return base.GetBaseSal() * (1 + bonusRate);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Company.model
{
    public class TeamLeader : Developer
    {
        protected double bonusRate;

        public TeamLeader():base()
        {
            bonusRate = 0;
        }
        public TeamLeader(string empID, 
            string empName, 
            int baseSal, 
            string teamName, 
            List<string> programmingLanguages, 
            int expYear, 
            double bonusRate):base(empID, empName, baseSal, teamName, programmingLanguages, expYear)
        {
            this.bonusRate = bonusRate;
        }
        
        public double BonusRate { get; set; }
        public override double GetSalary()
        {
            return base.GetSalary() * (1+this.BonusRate);
        }
    }
}

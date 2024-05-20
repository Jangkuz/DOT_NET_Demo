using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Company.model
{
    public class Developer : Employee
    {
        protected string teamName;
        protected List<string> programmingLanguages;
        protected int expYear;

        public Developer() : base()
        {
            this.teamName = string.Empty;
            this.programmingLanguages = new List<string>();
            this.expYear = 0;
        }

        public Developer(string empID,
        string empName,
        int baseSal,
        string teamName,
        List<string> programmingLanguages,
        int expYear)
            : base(empID, empName, baseSal)
        {
            this.teamName = teamName;
            this.programmingLanguages = programmingLanguages;
            this.expYear = expYear;
        }

        public String GetTeamName()
        {
            return this.teamName;
        }

        public List<String> GetProgrammingLanguages()
        {
            return this.programmingLanguages;
        }

        public int GetExpYear()
        {
            return this.expYear;
        }

        public override double GetSalary()
        {
            double salary = this.baseSal;
            if (this.expYear >= 5)
            {
                salary += this.expYear * 2000000;
            }
            if (this.expYear >= 3 && this.expYear < 5)
            {
                salary += this.expYear * 1000000;
            }
            return salary;
        }

        public override String ToString()
        {
            //Need to be updated later
            return base.ToString() + "_" + this.teamName + "_" + string.Join(",", this.programmingLanguages) + "_" + this.expYear;
        }
    }
}
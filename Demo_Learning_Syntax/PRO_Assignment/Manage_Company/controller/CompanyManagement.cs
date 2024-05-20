using Manage_Company.model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable
namespace Manage_Company.controller
{
    public class CompanyManagement
    {
        private List<Employee> empList;

        //Constructor and read file
        public CompanyManagement(string path1, string path2)
        {
            empList = new List<Employee>();
            empList = GetEmployeesFromFile(path1, path2);
        }

        //reads form the file into the empList
        public List<Employee> GetEmployeesFromFile(string empPath, string programLanguagePath)
        {
            List<Employee> empList = new List<Employee>();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            try
            {
                //Read Programming Language (PL) info
                Dictionary<string, List<string>> hashPLInfo = new Dictionary<string, List<string>>();
                //string fullPath = Path.GetFullPath(path2); //get Fullpath of the programming language file
                //string fullPath = Path.Combine(baseDirectory, @"input\PLInfo.txt");
                string fullPath = programLanguagePath; //subsutude
                //System.Console.WriteLine(fullPath);
                System.Console.WriteLine(programLanguagePath);
                //start reading file
                using (FileStream filePLInfo = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader myInputPLInfo = new StreamReader(filePLInfo))
                    {
                        string? thisLinePLInfo;
                        while ((thisLinePLInfo = myInputPLInfo.ReadLine()) != null)
                        {
                            if (!string.IsNullOrEmpty(thisLinePLInfo))
                            {
                                string[] split = thisLinePLInfo.Split(',');
                                List<string> plInfo = new List<string>();
                                string key = split[0].Trim();

                                for (int i = 1; i < split.Length; i++)
                                {
                                    plInfo.Add(split[i].Trim());
                                }
                                if (!hashPLInfo.ContainsKey(key))
                                {
                                    //hashPLInfo[key] = new List<string>();
                                    //hashPLInfo[key] = plInfo;
                                    hashPLInfo.Add(key, plInfo);
                                }
                            }
                        }
                    }
                }
                //done reading Programming Language data

                //Read Employee
                fullPath = empPath; //get full path of the employee data page
                System.Console.WriteLine(fullPath);
                //start reading ifle
                using (FileStream fileEmpInfo = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader myInputEmpInfo = new StreamReader(fileEmpInfo))
                    {
                        string? thisLineEmpInfo;
                        while ((thisLineEmpInfo = myInputEmpInfo.ReadLine()) != null)
                        {
                            if (!string.IsNullOrEmpty(thisLineEmpInfo))
                            {
                                //if (empList == null)
                                //{
                                //    empList = new List<Employee>();
                                //}
                                string[] split = thisLineEmpInfo.Split(",");
                                //split[0] No., split[1] ID, split[2] Name
                                string id = split[1].Trim();
                                string name = split[2].Trim();
                                if (id.StartsWith("D"))
                                {
                                    if (!split[5].Trim().EndsWith("L"))
                                    {
                                        string teamName = split[3].Trim();
                                        int yOfExp = int.Parse(split[4].Trim());
                                        int salary = int.Parse(split[5].Trim());
                                        List<string> proLang = hashPLInfo[id];
                                        Developer dev = new Developer(id, teamName, salary, name, proLang, yOfExp);
                                        empList.Add(dev);
                                    }
                                    else
                                    {
                                        string teamName = split[3].Trim();
                                        int yOfExp = int.Parse(split[4].Trim());
                                        double bonusRate = double.Parse(split[6].Trim());
                                        int salary = int.Parse(split[7].Trim());
                                        List<string> proLang = hashPLInfo[id];
                                        TeamLeader lead = new TeamLeader(id, name, salary, teamName, proLang, yOfExp, bonusRate);
                                        empList.Add(lead);
                                    }
                                }
                                else if (id.StartsWith("T"))
                                {
                                    double bonusRate = double.Parse(split[3].Trim());
                                    string type = split[4].Trim();
                                    int salary = int.Parse(split[5].Trim());
                                    Tester tes = new Tester(id, name, salary, bonusRate, type);
                                    empList.Add(tes);
                                }
                            }

                        }
                    }
                }
                //dong reading file
            }
            catch (FileNotFoundException E)
            {
                System.Console.WriteLine($"File not found{E.Message}");
                System.Console.WriteLine($"{empPath}{programLanguagePath}");
            }
            return empList;
        }

        //contructor for testing
        public CompanyManagement(List<Employee> tempList)
        {
            this.empList = tempList;
        }

        //get list of programmers who are proficient in the input pl programmingLanguage
        public List<Developer> GetDeveloperByProgrammingLanguage(string? pl)
        {
            List<Developer> devList = new List<Developer>();
            for (int i = 0; i < empList.Count; i++)
            {
                //check if is Dev class
                if (empList[i] is Developer)
                {
                    //if (devList.Count == 0)
                    //{
                    //    devList = new List<Developer>();
                    //}
                    //get object dev
                    Developer dev = (Developer)empList[i];

                    //check if contian programming language
                    if (ContainsIgnoreCase(dev.GetProgrammingLanguages(), pl))
                    {
                        devList.Add(dev);
                    }
                    //if (devList == null || devList.Count == 0)
                    //{
                    //    System.Console.WriteLine("There is no such devloper");
                    //}
                    //else
                    //{
                    //    PrintEmpList(devList);
                    //}
                }
            }
            return devList;
        }
        public static bool ContainsIgnoreCase(List<string> arrStr, string? str)
        {
            bool result = false;

            foreach (string element in arrStr)
            {
                if (string.Equals(element, str, StringComparison.OrdinalIgnoreCase))
                {
                    result = true;
                    break; // If found, exit the loop early
                }
            }

            return result;
        }

        public List<Tester>? GetTestersHaveSalaryGreaterThan(double value)
        {
            List<Tester> testerList = new List<Tester>();

            foreach (object emp in empList)
            {
                if (emp is Tester)
                {
                    Tester tes = (Tester)emp;

                    if (tes.GetSalary() > value)
                    {
                        if (testerList == null)
                        {
                            testerList = new List<Tester>();
                        }

                        testerList.Add(tes);
                    }
                }
            }

            //if (testerList == null || testerList.Count == 0)
            //{
            //    Console.WriteLine("There is no such Tester.");
            //}
            //else
            //{
            //    PrintEmpList(testerList);
            //}

            return testerList;
        }

        public Employee? GetEmployeeWithHighestSalary()
        {
            Employee? highestEmp = null;
            double highestSalary = 0;

            foreach (Employee emp in empList)
            {
                if (emp.GetSalary() > highestSalary)
                {
                    highestSalary = emp.GetSalary();
                    highestEmp = emp;
                }
            }

            //if (highestEmp == null)
            //{
            //    Console.WriteLine("There is no such Employee.");
            //}
            //else
            //{
            //    Console.WriteLine(highestEmp.ToString());
            //}

            return highestEmp;
        }

        public List<TeamLeader>? GetLeaderWithMostEmployees()
        {
            List<TeamLeader>? leader = null;
            Dictionary<string, int> teamLeaderCount = new Dictionary<string, int>();

            foreach (object? emp in empList)
            {
                if (emp is Developer developer)
                {
                    if (teamLeaderCount.ContainsKey(developer.GetTeamName()))
                    {
                        teamLeaderCount[developer.GetTeamName()]++;
                    }
                    else
                    {
                        teamLeaderCount[developer.GetTeamName()] = 1;
                    }
                }
            }

            int biggestGroupNumber = teamLeaderCount.Values.Max();
            IEnumerable<string> biggestGroupNames = teamLeaderCount.Where(kv => kv.Value == biggestGroupNumber).Select(kv => kv.Key);

            foreach (string groupName in biggestGroupNames)
            {
                foreach (object emp in empList)
                {
                    if (emp is TeamLeader tempLead && tempLead.GetTeamName().Equals(groupName, StringComparison.OrdinalIgnoreCase))
                    {
                        if (leader == null)
                        {
                            leader = new List<TeamLeader>();
                        }
                        leader.Add(tempLead);
                    }
                }
            }

            return leader;
        }

        public List<Employee> Sorted()
        {
            List<Employee> sortedList = new List<Employee>(empList);

            // Sort the list by salary in descending order
            sortedList.Sort((emp1, emp2) =>
            {
                int result = emp2.GetSalary().CompareTo(emp1.GetSalary());
                if (result == 0)
                {
                    string[] split1 = emp1.GetEmpName().Split(' ');
                    char emp1FirstName = split1[split1.Length - 1][0];

                    string[] split2 = emp2.GetEmpName().Split(' ');
                    char emp2FirstName = split2[split2.Length - 1][0];

                    result = emp1FirstName.CompareTo(emp2FirstName);
                }
                return result;
            });

            return sortedList;
        }

        public void PrintEmpList()
        {
            foreach (var emp in empList)
            {
                Console.WriteLine(emp.ToString());
            }
        }
        public void PrintEmpList(IEnumerable<Employee> o)
        {
            foreach (var emp in o)
            {
                Console.WriteLine(emp.ToString());
            }
        }
        public void PrintEmpListAndSala(IEnumerable<Employee> o)
        {
            foreach (var emp in o)
            {
                Console.Write(emp.ToString());
                Console.WriteLine($": {emp.GetSalary():N0}");
            }
        }

        //write file

        static bool WriteFile<T>(string path, T data) where T : class
        {
            if (data == null)
            {
                return false;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(data.ToString());
                }

                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool WriteFile<T>(string path, List<T>? list) where T : class
        {
            if (list == null)
            {
                return false;
            }

            try
            {
                // Ensure the directory exists
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (T item in list)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
                System.Console.WriteLine(path);
                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


    }
}

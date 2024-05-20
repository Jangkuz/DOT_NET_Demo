using Manage_Company.controller;
using Manage_Company.model;

namespace Manage_Company.viewer
{
    public class Program()
    {
        public static string fileEmp = @"D:\Coding\Dot_NET\Demo\PRO_Assignment\Manage_Company\input\ListOfEmployees.txt";
        public static string filePL = @"D:\Coding\Dot_NET\Demo\PRO_Assignment\Manage_Company\input\PLInfo.txt";
        //D:\Coding\Dot_NET\Demo\PRO_Assignment\Manage_Company\input\PLInfo.txt
        public static string fileWrite1 = @"D:\Coding\Dot_NET\Demo\PRO_Assignment\output\Req2.txt";
        public static string fileWrite2 = @"D:\Coding\Dot_NET\Demo\PRO_Assignment\output\Req3.txt";
        //Directory.SetCurrentDirectory("D:\\Coding\\Dot_NET\\Demo\\PRO_Assignment\\Manage_Company");

        public static void Main(string[] args)
        {
            try
            {
                //Menu options
                String[] options = {"Read all Employees and print to screen",
                    "Show staff proficient in a Programming Language",
                    "Show Tester has higher salary",
                    "Show Employees's highest salary",
                    "Show Leader of the Team has most Employees",
                    "Sort Employees as descending salary",
                    "Write file",
                    "Exit" };

                int choice = 0;
                CompanyManagement cm = new CompanyManagement(fileEmp, filePL);
                System.Console.WriteLine("Note: \n All employee's salary based on the actual salary after muliply width the bonus and casted nto integer!!!");
                do
                {
                    System.Console.WriteLine("Company Employee Management Program");
                    choice = Menu.getChoice(options);
                    switch (choice)
                    {
                        case 1:
                            //Function here
                            cm.PrintEmpList();
                            break;
                        case 2:
                            //Function here
                            string? pl = string.Empty;
                            System.Console.Write("Enter the programming language: ");
                            pl = System.Console.ReadLine();
                            List<Developer> devList = cm.GetDeveloperByProgrammingLanguage(pl);
                            if (devList == null || (devList.Count() == 0))
                            {
                                System.Console.WriteLine("There is no such Developer");
                            }
                            else
                            {
                                cm.PrintEmpList(devList);
                            }
                            break;
                        case 3:
                            //Function here
                            int sala;
                            System.Console.Write("Enter salary: ");
                            sala = System.Convert.ToInt32(System.Console.ReadLine());
                            List<Tester>? testerList = cm.GetTestersHaveSalaryGreaterThan(sala);
                            if (testerList == null || (testerList.Count() == 0))
                            {
                                System.Console.WriteLine("There is no such Tester");
                            }
                            else
                            {
                                //cm.PrintEmpList(testerList);
                                cm.PrintEmpListAndSala(testerList);
                            }
                            break;

                        case 4:
                            //Function here
                            Employee? highestEmp = cm.GetEmployeeWithHighestSalary();
                            if (highestEmp == null)
                            {
                                System.Console.WriteLine("There is no such Employee");
                            }
                            else
                            {
                                System.Console.WriteLine($"{highestEmp.ToString()}: {highestEmp.GetSalary()}");
                            }
                            break;

                        case 5:
                            //Function here
                            List<TeamLeader>? leader = cm.GetLeaderWithMostEmployees();
                            if (leader == null)
                            {
                                System.Console.WriteLine("There is no such Team Leader");
                            }
                            else
                            {
                                cm.PrintEmpList(leader);
                            }
                            break;

                        case 6:
                            //Function here
                            List<Employee> sortedList = cm.Sorted();
                            if (sortedList.Count == 0)
                            {
                                System.Console.WriteLine("There is no such list");
                            }
                            else
                            {
                                cm.PrintEmpListAndSala(sortedList);
                            }
                            break;

                        case 7:
                            //Function here
                            bool writeSuccess1 = CompanyManagement.WriteFile(fileWrite1, cm.GetDeveloperByProgrammingLanguage("C++"));
                            bool writeSuccess2 = CompanyManagement.WriteFile(fileWrite2, cm.GetTestersHaveSalaryGreaterThan(4700000));
                            if (writeSuccess1 & writeSuccess2)
                            {
                                System.Console.WriteLine("Write file success");
                            }
                            else
                            {
                                System.Console.WriteLine("Write file fail");
                            }
                            break;
                        case 8:
                            System.Console.WriteLine("Goodbyes~~");
                            break;
                        default:
                            //Function here
                            System.Console.WriteLine("Please re-enter");
                            break;
                    }

                } while (choice != options.Length);
            }
            catch (FileNotFoundException E)
            {
                System.Console.WriteLine($"File not found: {E.Message}");
            }
            catch (Exception E)
            {
                System.Console.WriteLine(E.Message);
            }
        }
    }

}


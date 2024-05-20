using Manage_Company.controller;
using Manage_Company.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManageCompany.Tests
{
    public class ControllerTests
    {
        public List<Employee> mockData = new List<Employee>()
        {
            new Developer("D02","Pham Le Anh Khoa",6000000,"Fly",new List<string> {"C", "Java"},3),
            new Developer("D03","Tran Tuan Kiet",12000000,"Run",new List<string> {"Java", "Java Script"},7),
            new TeamLeader("D04","To Quoc Bao",10000000,"Walk",new List<string> {"C", "C++"},3,0.3),
            new TeamLeader("D05","Tran Bao Tin",10000000,"Jump",new List<string> {"Java", "C#"},3,0.1)
        };

        [Fact]
        public void GetDevByProLang_ShouldReturnOneDev()
        {
            //Arrange
            string proLang = "Java";
            var expected = new List<Developer>()
            {
                (Developer)mockData[0], (Developer)mockData[2]
            };
            CompanyManagement cm = new CompanyManagement(mockData);
            //Act
            List<Developer> actual = cm.GetDeveloperByProgrammingLanguage(proLang);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

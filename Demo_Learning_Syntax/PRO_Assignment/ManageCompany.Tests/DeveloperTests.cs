using Manage_Company.model;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ManageCompany.Tests
{
    public class DeveloperTests
    {
        //[Fact]
        //public void Constructor_ParamConstructorShouldRun()
        //{
        //    //Arrange
        //    List<string> empList = new List<string>();
        //    Developer expected = new Developer(string.Empty, string.Empty, 0, string.Empty, empList, 0);
        //    //Act
        //    Developer actual = new Developer();
        //    //Assert
        //    Assert.Equal(expected, actual);
        //}

        [Fact]
        public void GetSalary_ShouldRun()
        {
            //Arrange
            List<string> programmingLanguage= new List<string>();
            programmingLanguage.Add("C");
            programmingLanguage.Add("C#");
            programmingLanguage.Add("C++");
            Developer testDev = new Developer("D01", "Nguyen Dinh Minh Khoi", 5000000, "Run", programmingLanguage, 3);
            double expected = 8000000;
            //Act
            double actual = testDev.GetSalary();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using Moq;
using PragimTechDotNetCore_Practice.Controllers;
using PragimTechDotNetCore_Practice.Models;
using PragimTechDotNetCore_Practice.Repositories;


namespace PragimTechDotNetCore.Test
{
    public class UnitTestController
    {
        private readonly Mock<IEmployeeRepository> employeeService;
        
        public UnitTestController()
        {
            employeeService = new Mock<IEmployeeRepository>();
            
        }
        [Fact]
        public void GetEmployeeList_EmployeeList()
        {
            var employeeList = GetEmployees();

            employeeService.Setup(x => x.GetAllEmployee())
                .Returns(employeeList);
            var productController = new EmployeeController(employeeService.Object);
            //act
            var employeeResult = productController.Index();
            //assert
            Assert.NotNull(employeeResult);
            //Assert.Equal(GetEmployees().Count(), employeeResult.);
            Assert.Equal(GetEmployees().ToString(), employeeResult.ToString());
            Assert.True(employeeList.Equals(employeeResult));
        }

        private List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 0001, Name = "Imran", Email = "imran@gmail.com", Department = Dept.It },
                new Employee { Id = 0002, Name = "Asraf", Email = "asraf@gmail.com", Department = Dept.It },
                new Employee { Id = 0003, Name = "Ajaz", Email = "ajaz@gmail.com", Department = Dept.Hr }
            };

            return employees;
        }
    }
}

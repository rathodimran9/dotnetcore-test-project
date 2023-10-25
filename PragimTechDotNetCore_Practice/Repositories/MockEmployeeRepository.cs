using PragimTechDotNetCore_Practice.Models;

namespace PragimTechDotNetCore_Practice.Repositories
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee { Id = 0001, Name = "Imran", Email = "imran@gmail.com", Department = Dept.It },
                new Employee { Id = 0002, Name = "Asraf", Email = "asraf@gmail.com", Department = Dept.It },
                new Employee { Id = 0003, Name = "Ajaz", Email = "ajaz@gmail.com", Department = Dept.Hr }
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(x => x.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmplyees(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}

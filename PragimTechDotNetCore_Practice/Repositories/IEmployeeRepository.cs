using PragimTechDotNetCore_Practice.Models;

namespace PragimTechDotNetCore_Practice.Repositories
{
    public interface IEmployeeRepository
    {
        public Employee GetEmplyees(int Id);

        public IEnumerable<Employee> GetAllEmployee();

        public Employee Add(Employee employee);

        Employee Update(Employee employee);

        Employee Delete(Employee employee);
    }
}

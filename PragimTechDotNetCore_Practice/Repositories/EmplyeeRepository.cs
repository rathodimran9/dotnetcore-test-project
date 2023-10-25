using Microsoft.EntityFrameworkCore;
using PragimTechDotNetCore_Practice.DBContext;
using PragimTechDotNetCore_Practice.Models;

namespace PragimTechDotNetCore_Practice.Repositories
{
    public class EmplyeeRepository : IEmployeeRepository
    {
        private AppDbContext _dbContext;

        public EmplyeeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Employee Add(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }

        public Employee Delete(Employee employee)
        {
            Employee emp = _dbContext.Employees.Find(employee.Id);

            if(emp != null)
            {
                _dbContext.Employees.Remove(emp);
                _dbContext.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _dbContext.Employees;
        }

        public Employee GetEmplyees(int Id)
        {
            return _dbContext.Employees.Find(Id);
        }

        public Employee Update(Employee employee)
        {
            _dbContext.Update(employee);
            _dbContext.SaveChanges();
            return employee;

        }
    }
}

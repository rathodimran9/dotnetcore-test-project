using Microsoft.EntityFrameworkCore;
using PragimTechDotNetCore_Practice.Models;

namespace PragimTechDotNetCore_Practice.DBContext
{
    public static class SeedData
    {
        public static void ModelSeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Imran",
                    Email = "imran@gmail.com",
                    Department = Dept.It,
                    Age= 34,
                    PhotoPath = ""
                },
                new Employee
                {
                    Id = 2,
                    Name = "Asaraf",
                    Email = "asaraf@gmail.com",
                    Department = Dept.It,
                    Age = 36,
                    PhotoPath = ""

                },
                new Employee
                {
                    Id = 3,
                    Name = "Ajaz",
                    Email = "ajaz@gmail.com",
                    Department = Dept.Hr,
                    Age = 35,
                    PhotoPath = ""
                }
            );
        }
    }
}

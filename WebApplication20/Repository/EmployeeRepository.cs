using WebApplication20.Interface;
using WebApplication20.Models;

namespace WebApplication20.Repository
{
    public class EmployeeRepository : IUnits
    {
        private ApplicationDbContext dbContext;
        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Employee Create(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public Employee Delete(Employee employee)
        {
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public Employee Edit(Employee employee)
        {

            dbContext.Employees.Update(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public Employee GetEmp()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = dbContext.Employees.ToList();
            return employees;
        }
    }
}

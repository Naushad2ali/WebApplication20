using WebApplication20.Models;

namespace WebApplication20.Interface
{
    public interface IUnits
    {

        List<Employee> GetEmployees();
        Employee GetEmp();
        Employee Create(Employee employee);
        Employee Edit(Employee employee);
        Employee Delete(Employee employee);
    }
}

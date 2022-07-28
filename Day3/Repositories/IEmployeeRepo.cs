using WebApplication03.Models;
namespace WebApplication03.Repositories
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee obj);
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee obj);
    }
}

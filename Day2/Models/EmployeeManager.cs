namespace WebApplication02.Models
{
    public class EmployeeManager
    {
        public static List<Employee> employees = new List<Employee>();
        public EmployeeManager()
        {
            employees = new List<Employee>()
            {
                new Employee(){EmpNo=101, Ename="A", Job="Trainee", Salary=20000, DeptNo=10},
                new Employee(){EmpNo=102, Ename="B", Job="Engineer", Salary=25000, DeptNo=10},
                new Employee(){EmpNo=103, Ename="C", Job="SDE", Salary=18000, DeptNo=20},
                new Employee(){EmpNo=104, Ename="D", Job="IT", Salary=28000, DeptNo=20},
                new Employee(){EmpNo=105, Ename="E", Job="Manager", Salary=8000, DeptNo=30},
            };
        }
        public List<Employee> GetAllDetails()
        {
            return employees;
        }
        public Employee GetEmployeeByID(int id)
        {
            return employees.Find(item => item.EmpNo == id);
        }
        public void AddEmployee(Employee obj)
        {
            employees.Add(obj);
        }
        public void UpdateDetails(Employee obj)
        {
            Employee obj1 = employees.Find(item => item.EmpNo == obj.EmpNo);
            employees.Remove(obj1);
            employees.Add(obj);
        }
        public void DeleteEmployee(int id)
        {
            Employee obj = employees.Find(item => item.EmpNo == id);
            employees.Remove(obj);
        }
    }
}

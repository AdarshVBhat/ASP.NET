namespace EmployeeCRUD.Models
{
    public class EmpManager
    {
        public static List<Emp> Employees = new List<Emp>();

        public EmpManager()
        {
            Employees = new List<Emp>()
            {
                new Emp(){Empid = 1, Ename = "A", Job = "Trainee", Salary= 6000, Deptno = 10},
                new Emp(){Empid = 2, Ename = "S", Job = "Developer", Salary= 8000, Deptno = 30},
                new Emp(){Empid = 3, Ename = "L", Job = "IT", Salary= 9000, Deptno = 50}
            };
        }

        public List<Emp> GetAllEmp()
        {
            return Employees;
        }
        public Emp GetEmpById(int id)
        {
            return Employees.Find(item => item.Empid == id);
        }
        public void AddEmp(Emp obj)
        {
            Employees.Add(obj);
        }
        public void DeleteEmp(int id)
        {
            Emp obj = Employees.Find(item => item.Empid == id);
            Employees.Remove(obj);
        }
        public void UpdateEmp(Emp updated_Obj)
        {
            Emp obj = Employees.Find(item => item.Empid == updated_Obj.Empid);
            obj.Ename = updated_Obj.Ename;
            obj.Salary = updated_Obj.Salary;
            obj.Job = updated_Obj.Job;
            obj.Deptno = updated_Obj.Deptno;
        }


    }
}
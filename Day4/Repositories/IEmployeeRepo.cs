﻿using WebApplication04.Models;
namespace WebApplication04.Repositories
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee obj);
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee obj);
        IEnumerable<Employee> GetEmployeesByDeptNo(int deptNo);
        IEnumerable<Employee> GetEmployeesByJob(string job);
    }
}
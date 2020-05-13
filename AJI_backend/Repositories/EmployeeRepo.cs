using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJI_backend.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        AJIDatabaseContext aJIDatabaseContext = new AJIDatabaseContext();
        public Employee AddEmployee(Employee employee)
        {
            aJIDatabaseContext.Employees.Add(employee);
            aJIDatabaseContext.SaveChanges();
            return employee;
        }

        public IList<Employee> GetAllEmployees()
        {
            return aJIDatabaseContext.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return aJIDatabaseContext.Employees.FirstOrDefault(e => e.Emp_Id == id);
        }
    }
}
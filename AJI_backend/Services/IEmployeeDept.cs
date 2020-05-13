using AJI_backend.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJI_backend.Services
{
    public interface IEmployeeDept
    {
        IList<Depatment> GetAllDepartments();
        IList<Employee> GetAllEmployees();
        Depatment AddDepartment(Depatment depatment);
        Employee AddEmployee(Employee employee);
        IList<EmployeeDepartment> GetEmployeeByDept(int id);
    }
}

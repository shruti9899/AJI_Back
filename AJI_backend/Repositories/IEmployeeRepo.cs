using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJI_backend.Repositories
{
    public interface IEmployeeRepo
    {
        IList<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee employee);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJI_backend.Repositories
{
    public interface IDepartmentRepo
    {
        IList<Depatment> GetAllDepartments();
        Depatment GetDepartmentById(int id);
        Depatment AddDepartment(Depatment department);
    }
}

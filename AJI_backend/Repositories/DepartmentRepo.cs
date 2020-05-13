
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJI_backend.Repositories
{
    public class DepartmentRepo : IDepartmentRepo
    {
        AJIDatabaseContext aJIDatabaseContext = new AJIDatabaseContext();
        public Depatment AddDepartment(Depatment department)
        {
            aJIDatabaseContext.Depatments.Add(department);
            aJIDatabaseContext.SaveChanges();
            return department;
        }

        public IList<Depatment> GetAllDepartments()
        {
            return aJIDatabaseContext.Depatments.ToList();
        }

        public Depatment GetDepartmentById(int id)
        {
            return aJIDatabaseContext.Depatments.FirstOrDefault(e => e.Dept_Id == id);      
        }
    }
}
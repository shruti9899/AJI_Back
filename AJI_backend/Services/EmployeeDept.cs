
using AJI_backend.DTO;
using AJI_backend.Repositories;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

namespace AJI_backend.Services
{
    public class EmployeeDept : IEmployeeDept
    {
        private readonly IEmployeeRepo _IemployeeRepo;
        private readonly IDepartmentRepo _IdepartmentRepo;
        public EmployeeDept(IEmployeeRepo iEmployeeRepo, IDepartmentRepo iDepartmentRepo)
        {
            _IemployeeRepo = iEmployeeRepo;
            _IdepartmentRepo = iDepartmentRepo;
        }
        public Depatment AddDepartment(Depatment depatment)
        {
            return _IdepartmentRepo.AddDepartment(depatment);
        }

        public Employee AddEmployee(Employee employee)
        {
            return _IemployeeRepo.AddEmployee(employee);
        }

        public IList<Depatment> GetAllDepartments()
        {
            return _IdepartmentRepo.GetAllDepartments();
        }

        public IList<Employee> GetAllEmployees()
        {
            return _IemployeeRepo.GetAllEmployees();
        }

        public IList<EmployeeDepartment> GetEmployeeByDept(int id)
        {
            IList<EmployeeDepartment> employeeDepts = new List<EmployeeDepartment>();
            var dept = _IdepartmentRepo.GetDepartmentById(id);
            IList<Employee> employees = _IemployeeRepo.GetAllEmployees();
            foreach(var employee in employees)
            {
                if(employee.Dept_Id == dept.Dept_Id)
                {
                    EmployeeDepartment employeeDept = new EmployeeDepartment();
                    employeeDept.Dept_Id = employee.Dept_Id;
                    employeeDept.Dept_Name = dept.Dept_Name;
                    employeeDept.Emp_Id = employee.Emp_Id;
                    employeeDept.Name = employee.Name;
                    employeeDepts.Add(employeeDept);
                }
            }
            return employeeDepts;
        }
    }
}
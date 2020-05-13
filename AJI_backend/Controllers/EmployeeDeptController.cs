using AJI_backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web.Http;

namespace AJI_backend.Controllers
{
    public class EmployeeDeptController : ApiController
    {
        private readonly IEmployeeDept _IEmployeeDept;

        public EmployeeDeptController(IEmployeeDept iEmployeeDept)
        {
            _IEmployeeDept = iEmployeeDept;
        }
   
        [HttpGet]
        [Route("employees")]
        public IHttpActionResult GetAllEmployees()
        {
            return Ok(_IEmployeeDept.GetAllEmployees());
        }

        [HttpGet]
        [Route("departments")]
        public IHttpActionResult GetAllDepartments()
        {
            return Ok(_IEmployeeDept.GetAllDepartments());
        }

      
        [HttpPost]
        [Route("employees/add")]
        public IHttpActionResult AddEmployee([FromBody]Employee employee)
        {
            return Ok(_IEmployeeDept.AddEmployee(employee));
        }

        [HttpPost]
        [Route("departments/add")]
        public IHttpActionResult AddDepartment([FromBody]Depatment depatment)
        {
            return Ok(_IEmployeeDept.AddDepartment(depatment));
        }

        [HttpGet]
        [Route("empDept/{id}")]
        public IHttpActionResult GetEmployeesByDeptId(int id)
        {
            return Ok(_IEmployeeDept.GetEmployeeByDept(id));
        }
    }
}

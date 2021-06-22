using EmployeeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public Employee Get()
        {
            // return new string[] { "value1", "value2" };
            return new Employee { EmployeeName = "Abc", EmployeeCode = "001", Salary = "$4500" };
        }

        public IList<Employee> Get(string id)
        {
            IList<Employee> EmpList = new List<Employee>();

            // return new string[] { "value1", "value2" };
            Employee FirstEmployee = new Employee { EmployeeName = "Abc", EmployeeCode = "001", Salary = "$4500" };
            Employee SecondEmployee = new Employee { EmployeeName = "Xyz", EmployeeCode = "002", Salary = "$3500" };
            EmpList.Add(FirstEmployee);
            EmpList.Add(SecondEmployee);
            return EmpList;
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using t_emp.api.Models;
using t_emp.api.Services;
using t_emp.Api.DbContexts;

namespace t_emp.api.Controllers
{
    [Route("api/trans")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly emp_transRepo _repo;

        public TransactionController(emp_transRepo repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public ActionResult<IEnumerable<EmpTran>> GetEmpDta(int empId)
        {
            if (!_repo.EmpExist(empId))
                return NotFound();


            List<EmpTran> result = new List<EmpTran>();
            result.AddRange(_repo.GetTransactions(empId));
            

            var emp = _repo.GetEmployee(empId);
            var dep = _repo.Getdepa(emp.DepartId);

            var res = new
            {
                employeeDta = emp,
                DeprtmentName = dep.DepartName,
                EmployeeTransactions = result
            };
            
            return Ok(res);
        }

       
    }
}

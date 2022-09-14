using dm.api.E_Models;
using t_emp.api.Models;
using t_emp.Api.DbContexts;

namespace t_emp.api.Services
{
    public class emp_transRepo
    {
        private readonly EmpTransContext _context;

        public emp_transRepo(EmpTransContext context)
        {
            _context = context;
        }

        public bool EmpExist(int id)
        {
         
            if (!_context.Employees.Any(e => e.Id == id))
                return false;
            return true;
        }

        public Employee GetEmployee(int id) => (_context.Employees.FirstOrDefault(e => e.Id == id));

        public EmpTran GetEmplTran(int id) => (_context.EmployeeTransaction.FirstOrDefault(e => e.Id == id));

        public Depart Getdepa(int id) => _context.department.FirstOrDefault(e => e.Id == id);

        public IEnumerable<EmpTran> GetTransactions(int id)
        {
            return _context.EmployeeTransaction
                .Where(e => e.EmpId == id)
                .OrderBy(e => e.Name).ToList();
        }

    }
}

using dm.api.E_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using t_emp.api.Models;

namespace t_emp.Api.DbContexts
{
    public class EmpTransContext : DbContext
    {
        public EmpTransContext(DbContextOptions<EmpTransContext> options)
            :base(options) { }
        
        public DbSet<EmpTran> EmployeeTransaction { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Depart> department { get; set; }

    }
}
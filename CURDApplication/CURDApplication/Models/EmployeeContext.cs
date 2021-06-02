using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURDApplication.Models
{
    public class Employeecontext : DbContext
    {
        public Employeecontext()
        { }
        public Employeecontext(DbContextOptions<Employeecontext> options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
    }
}

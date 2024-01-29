using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using exam_asp.Models;

namespace exam_asp.Data
{
    public class exam_aspContext : DbContext
    {
        public exam_aspContext (DbContextOptions<exam_aspContext> options)
            : base(options)
        {
        }

        public DbSet<exam_asp.Models.Department> Department { get; set; } = default!;

        public DbSet<exam_asp.Models.Employee> Employee { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaptItAcademy.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace AdaptItAcademy.DataAccess.Data
{
    public class AcademyDbContext: DbContext
    {
        public AcademyDbContext(DbContextOptions<AcademyDbContext> opts): base(opts)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Training> Trainings { get; set; }
    }
}

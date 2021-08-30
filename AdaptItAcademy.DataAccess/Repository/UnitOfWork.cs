using AdaptItAcademy.DataAccess.Data;
using AdaptItAcademy.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptItAcademy.DataAccess.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AcademyDbContext academyDb;

        public UnitOfWork(AcademyDbContext db)
        {
            academyDb = db;
            Course = new CourseRepository(academyDb);
        }

        public ICourseRepository Course { get; private set; }

        public void Dispose()
        {
            academyDb.Dispose();
        }

        public void Save()
        {
            academyDb.SaveChanges();
        }
    }
}

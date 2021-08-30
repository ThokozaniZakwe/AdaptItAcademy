using AdaptItAcademy.DataAccess.Data;
using AdaptItAcademy.DataAccess.Models;
using AdaptItAcademy.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptItAcademy.DataAccess.Repository
{
    public class CourseRepository: Repository<Course>, ICourseRepository
    {
        private readonly AcademyDbContext academyDb;

        public CourseRepository(AcademyDbContext db): base(db)
        {
            academyDb = db;
        }

        public void Update(Course course)
        {
            var objFromDb = academyDb.Courses.FirstOrDefault(c => c.CourseID == course.CourseID);
            if (objFromDb != null)
            {
                objFromDb.Description = course.Description;
                objFromDb.LastDateOfRegistration = course.LastDateOfRegistration;
                objFromDb.Name = course.Name;
                objFromDb.Price = course.Price;
                objFromDb.SeatsLeft = course.SeatsLeft;
                objFromDb.TrainingVenue = course.TrainingVenue;

                academyDb.SaveChanges();
            }
        }
    }
}

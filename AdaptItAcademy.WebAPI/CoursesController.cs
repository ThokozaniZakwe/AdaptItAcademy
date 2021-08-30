using AdaptItAcademy.DataAccess.Data;
using AdaptItAcademy.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AdaptItAcademy.WebAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController: ControllerBase
    {
        private AcademyDbContext academyDb;
        public CoursesController(AcademyDbContext db)
        {
            academyDb = db;
        }

        [HttpGet]
        public IAsyncEnumerable<Course> GetCourses()
        {
            return academyDb.Courses;
        }

        [HttpGet("{id}")]
        public async Task<Course> GetCourse(int id)
        {
            return await academyDb.Courses.Include(c =>c.TrainingDates).FirstAsync(c => c.CourseID ==  id); //page 474 in case circualr error
        }

        [HttpPost]
        public async Task SaveCourse([FromBody]Course course)
        {
            await academyDb.Courses.AddAsync(course);
            await academyDb.SaveChangesAsync();
        }

        [HttpPut]
        public async Task UpdateCourse([FromBody]Course course)
        {
            academyDb.Courses.Update(course);
            await academyDb.SaveChangesAsync();
        }

        [HttpDelete("{id}")]
        public async Task DeleteCourse([FromBody]int id)
        {
            academyDb.Courses.Remove(new Course() { CourseID = id});
            await academyDb.SaveChangesAsync();
        }
    }
}

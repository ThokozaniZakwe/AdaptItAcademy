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
    public class TrainingsController: ControllerBase
    {
        private AcademyDbContext academyDb;
        public TrainingsController(AcademyDbContext db)
        {
            academyDb = db;
        }

        [HttpGet]
        public IAsyncEnumerable<Training> GetTrainings()
        {
            return academyDb.Trainings;
        }

        [HttpGet("{id}")]
        public async Task<Training> GetCourse(int id)
        {
            return await academyDb.Trainings.FindAsync(id); //page 474 in case circualr error
        }

        [HttpPost]
        public async Task SaveCourse([FromBody]Training training)
        {
            await academyDb.Trainings.AddAsync(training);
            await academyDb.SaveChangesAsync();
        }

        [HttpPut]
        public async Task UpdateCourse([FromBody]Training training)
        {
            academyDb.Trainings.Update(training);
            await academyDb.SaveChangesAsync();
        }

        [HttpDelete("{id}")]
        public async Task DeleteCourse([FromBody]int id)
        {
            academyDb.Trainings.Remove(new Training() { TrainingID = id});
            await academyDb.SaveChangesAsync();
        }
    }
}

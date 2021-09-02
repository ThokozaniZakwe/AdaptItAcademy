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
    public class TrainingRepository: Repository<Training>, ITrainingRepository
    {
        private readonly AcademyDbContext academyDb;

        public TrainingRepository(AcademyDbContext db): base(db)
        {
            academyDb = db;
        }

        public void Update(Training training)
        {
            var objFromDb = academyDb.Trainings.FirstOrDefault(c => c.TrainingID == training.TrainingID);
            if (objFromDb != null)
            {
                objFromDb.PostalAddress = training.PhyAddress;
                objFromDb.PostalAddress = training.PostalAddress;
                objFromDb.FirstName = training.FirstName;
                objFromDb.LastName = training.LastName;
                objFromDb.PhoneNumber = training.PhoneNumber;
                objFromDb.CompanyName = training.CompanyName;
                objFromDb.Email = training.Email;
                objFromDb.Dietary = training.Dietary;

                academyDb.SaveChanges();
            }
        }
    }
}

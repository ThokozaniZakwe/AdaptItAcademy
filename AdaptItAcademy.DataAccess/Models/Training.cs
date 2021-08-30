using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaptItAcademy.DataAccess.Models
{
    public class Training
    {
        public int TrainingID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string PhyAddress { get; set; }
        public string PostalAddress { get; set; }

        public IEnumerable<TrainingDate> TrainingDates { get; set; }
        public IEnumerable<Dietary> Dietaries { get; set; }
    }
}

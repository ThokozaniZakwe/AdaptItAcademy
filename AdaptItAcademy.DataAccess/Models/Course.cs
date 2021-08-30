using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaptItAcademy.DataAccess.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TrainingVenue { get; set; }
        public int SeatsLeft { get; set; }
        public DateTime LastDateOfRegistration { get; set; }
        public string Price { get; set; }

        public IEnumerable<TrainingDate> TrainingDates { get; set; }
    }
}

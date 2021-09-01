using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdaptItAcademy.DataAccess.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Course Code")]
        public int CourseID { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Please enter a valid course name, maximum 50 characters.")]
        public string Name { get; set; }
        [Required]
        [MaxLength(80, ErrorMessage = "Please enter a valid description, maximum 80 characters.")]
        public string Description { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Please enter a valid course venue, maximum 30 characters.")]
        public string TrainingVenue { get; set; }
        [Required]
        public int SeatsLeft { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime LastDateOfRegistration { get; set; }
        public string Price { get; set; }

        public IEnumerable<TrainingDate> TrainingDates { get; set; }
    }
}

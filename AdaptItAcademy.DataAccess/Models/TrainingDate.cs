using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AdaptItAcademy.DataAccess.Models
{
    public class TrainingDate
    {
        public int TrainingDateID { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Training Date(s)")]
        public DateTime Date { get; set; }
    }
}

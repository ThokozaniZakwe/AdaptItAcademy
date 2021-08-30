using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AdaptItAcademy.DataAccess.Models
{
    public class Dietary
    {
        public int DietaryID { get; set; }
        [Display(Name = "Dietary")]
        public string Name { get; set; }
    }
}

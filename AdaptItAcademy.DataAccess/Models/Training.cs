using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AdaptItAcademy.DataAccess.Models
{
    public enum Dietary
    {
        Halaal,
        Vegan,
        Vegetarian,
        RawFood,
        Atkins,
        Ketogenic
    }
    public class Training
    {
        public int TrainingID { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "You have exceed allowed characters, maximum allowed character is 50.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        [MaxLength(50, ErrorMessage = "You have exceed allowed characters, maximum allowed character is 50")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone number cannot be blank")]
        [MaxLength(20, ErrorMessage = "Please enter a valid phone number, maximum characters allowed is 20")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email Address is essential")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Company name is required")]
        [MaxLength(30, ErrorMessage = "Please enter a valid company name, maximum character is 30")]
        public string CompanyName { get; set; }
        [Required]
        public Dietary Dietary { get; set; }
        [Display(Name = "Physical Address")]
        [Required(ErrorMessage = "Physical Address is required")]
        public string PhyAddress { get; set; }
        [Required(ErrorMessage = "Postal Address is required")]
        [Display(Name = "Postal Address")]
        public string PostalAddress { get; set; }
    }
}

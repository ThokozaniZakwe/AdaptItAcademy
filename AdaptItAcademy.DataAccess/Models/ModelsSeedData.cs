using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdaptItAcademy.DataAccess.Data;

namespace AdaptItAcademy.DataAccess.Models
{
    public static class ModelsSeedData
    {
        public static void EnsureSeeded(AcademyDbContext context)
        {
            context.Database.Migrate();
            if (!context.Courses.Any())
            {
                Course[] courses =
                {
                    new Course { Name = "Business Management", Description = "Detailed analysis Of running a business succefully.", TrainingVenue = "Home", SeatsLeft = 10, LastDateOfRegistration = DateTime.Parse("12/10/2021"), Price = "Free" },
                    new Course { Name = "Programming", Description = "Computer programming, from basics to master.", TrainingVenue = "Work", SeatsLeft = 10, LastDateOfRegistration = DateTime.Parse("12/01/2021"), Price = "R100" },
                    new Course { Name = "Administration", Description = "Efficiently administor work processes and staff.", TrainingVenue = "JHB", SeatsLeft = 10, LastDateOfRegistration = DateTime.Parse("01/10/2021"), Price = "R150" },
                    new Course { Name = "Accounting", Description = "Be an expert in balancing your financial books.", TrainingVenue = "Midrand", SeatsLeft = 10, LastDateOfRegistration = DateTime.Parse("12/12/2021"), Price = "120" }
                };
                context.Courses.AddRange(courses);
                context.SaveChanges();
            }

            if (!context.Trainings.Any())
            {
                Training[] trainings =
                {
                    new Training{ FirstName = "Homer", LastName = "Simpson", PhoneNumber = "1234567890", Email = "email@email.com", CompanyName = "Private", Dietary = Dietary.Vegan, PhyAddress = "11 St. Street", PostalAddress = "PO Box 123"},
                    new Training{ FirstName = "Bart", LastName = "Simpson", PhoneNumber = "0123654", Email = "some@email.com", CompanyName = "Some Company", Dietary = Dietary.Halaal, PhyAddress = "11 St. Road", PostalAddress = "PO Box 13"},
                    new Training{ FirstName = "Darth", LastName = "Vader", PhoneNumber = "1290987", Email = "my@email.com", CompanyName = "Online Company", Dietary = Dietary.RawFood, PhyAddress = "11 Road Str", PostalAddress = "PO Box 12"},
                    new Training{ FirstName = "John", LastName = "Rambo", PhoneNumber = "19075315", Email = "dummy@email.com", CompanyName = "My Company", Dietary = Dietary.Vegetarian, PhyAddress = "11 12th St", PostalAddress = "PO Box 3"}
                };
                context.Trainings.AddRange(trainings);
                context.SaveChanges();
            }
        }
    }
}

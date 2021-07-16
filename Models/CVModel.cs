using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFACV.Models
{
    public class CVModel
    {
        public string Name { get; set; }
        public string FunctionTitle { get; set; }
        public string Profile { get; set; }
        List<ExperienceModel> Experiences { get; set; }
        List<EducationModel> Educations { get; set; }
        List<SkillModel> Skills { get; set; }
        List<ProjectModel> Projects { get; set; }
        List<ContactModel> Contacts { get; set; }
        List<SocialMediaModel> SocialMedias { get; set; }

        public CVModel()
        {
            Name = "Deowan Faruque Ahamed";
            FunctionTitle = "Senior Software Engineer | Full-stack .Net Developer";
            Profile = @"Strong planner and problem solver who readily adapts to change, works independently and exceeds expectations. To chase highly challenging ventures where I can contribute to the organizational goals thereby acquire new technical skills and contribute constructively";
            Experiences = new List<ExperienceModel> {
                new ExperienceModel {
                    Title = "Senior Software Engineer",
                    CompanyName = "TechnoVista Limited",
                    CompanyWebUrl = "https://technovista.com.bd/",
                    City = "Dhaka",
                    StartDate = new DateTime(2018, 1, 1),
                    EndDate = null,
                    Description = ""
                },
                new ExperienceModel {
                    Title = "Software Engineer",
                    CompanyName = "TechnoVista Limited",
                    CompanyWebUrl = "https://technovista.com.bd/",
                    City = "Dhaka",
                    StartDate = new DateTime(2016, 1, 1),
                    EndDate = new DateTime(2017, 12, 31),
                    Description = ""
                },
                new ExperienceModel {
                    Title = "Software Developer",
                    CompanyName = "Unisoft Systems Limited",
                    CompanyWebUrl = "http://www.uslbd.com/",
                    City = "Dhaka",
                    StartDate = new DateTime(2014, 11, 1),
                    EndDate = new DateTime(2015, 12, 31),
                    Description = ""
                },
            };
        }
    }
}

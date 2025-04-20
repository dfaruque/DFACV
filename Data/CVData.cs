using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    public static double ExperienceYears => DateTime.Today.Year - 2014;
    public static double ProgrammingExperienceYears => DateTime.Today.Year - 2006;

    public static CVModel Get()
    {
        return new()
        {
            Name = "Deowan Faruque Ahamed",
            FunctionTitle = "Principal Software Engineer | Full-stack .NET Developer",

            Contacts = GetContacts(),

            SocialMedias = GetSocialMedias(),

            Profile = "Strong planner and problem solver who readily adapts to change, works independently, and exceeds expectations. " +
            "Began programming in school and dreams of becoming a software engineer.",

            Features = GetProfileFeatures(),

            Skills = GetSkills(),

            CommunicationLanguages = new() {
                new() { Name = "Bengali", CommunicationLanguageLevel = CommunicationLanguageLevel.Native },
                new() { Name = "English", CommunicationLanguageLevel = CommunicationLanguageLevel.Professional },
                //new() { Name = "Arabic", CommunicationLanguageLevel = CommunicationLanguageLevel.Elementary },
            },

            Experiences = GetExperiences(),

            Educations = GetEducations(),

            Projects = GetProjects(),

            HobbyProjects = GetHobbyProjects(),

            OpenSourceContributions = GetOpenSourceContributions(),

            Awards = new() {
                new() {
                    Name = "Performance Award",
                    Year = 2017,
                    GivenBy = "TechnoVista Limited"
                },
            },

            References = GetReferences(),
        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    private static List<ExperienceModel> GetExperiences()
    {
        return new() {
            new() {
                Title = "Senior Software Engineer",
                CompanyName = "TechnoVista Limited",
                CompanyWebUrl = "https://technovista.com.bd/",
                City = "Dhaka",
                StartDate = new DateTime(2018, 1, 1),
                EndDate = null,
                Description = "<div>→ Working closely with project managers and clients.</div>" +
                "<div>→ Collecting client requirements and convert them to the technical solution.</div>" +
                "<div>→ As a project development lead, help juniors to understand and perform their tasks.</div>"
            },
            new() {
                Title = "Software Engineer",
                CompanyName = "TechnoVista Limited",
                CompanyWebUrl = "https://technovista.com.bd/",
                City = "Dhaka",
                StartDate = new DateTime(2016, 1, 1),
                EndDate = new DateTime(2017, 12, 31),
                Description = "<div>→ Worked closely with senior software engineers and analysts.</div>" +
                "<div>→ Understood business and developed accordingly.</div>" +
                "<div>→ Got performance award!</div>"
            },
            new() {
                Title = "Software Developer",
                CompanyName = "Unisoft Systems Limited",
                CompanyWebUrl = "http://www.uslbd.com/",
                City = "Dhaka",
                StartDate = new DateTime(2014, 11, 1),
                EndDate = new DateTime(2015, 12, 31),
                Description = "<div>→ Worked as a development team member of an ERP system.</div>" +
                "<div>→ Understood business from analyst and developed accordingly.</div>"
            },
        };
    }
}

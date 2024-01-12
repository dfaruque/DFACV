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
                Description = "<div>• Working closely with project managers and clients from various bussiness domain.</div>" +
                "<div>• Analyzed and translated complex client requirements into scalable technical solutions, resulting in a 40% reduction in development time and a 25% increase in customer satisfaction.</div>" +
                "<div>• As a development lead, help juniors understand and perform their tasks.</div>"
            },
            new() {
                Title = "Software Engineer",
                CompanyName = "TechnoVista Limited",
                CompanyWebUrl = "https://technovista.com.bd/",
                City = "Dhaka",
                StartDate = new DateTime(2016, 1, 1),
                EndDate = new DateTime(2017, 12, 31),
                Description = "<div>• Worked closely with senior software engineers and analysts.</div>" +
                "<div>• Introduced a new framework (Serenity) in the company which reduces 50% developmnet time.</div>" +
                "<div>• Understood business and developed accordingly.</div>" +
                "<div>• Got a performance award!</div>"
            },
            new() {
                Title = "Software Developer",
                CompanyName = "Unisoft Systems Limited",
                CompanyWebUrl = "http://www.uslbd.com/",
                City = "Dhaka",
                StartDate = new DateTime(2014, 11, 1),
                EndDate = new DateTime(2015, 12, 31),
                Description = "<div>• Worked as a development team member of an ERP system.</div>" +
                "<div>• Understood business from analysts and developed accordingly.</div>"
            },
        };
    }
}

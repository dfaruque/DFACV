﻿using System;
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
                Title = "Principal Software Engineer",
                CompanyName = "TechnoVista Limited",
                CompanyWebUrl = "https://technovista.com.bd/",
                City = "Dhaka",
                StartDate = new DateTime(2024, 1, 1),
                EndDate = null,
                Description = "<div>• Analyzed project requirements, defined task breakdowns, and provided accurate time estimations.</div>" +
                "<div>• Delegated tasks effectively, ensuring optimal alignment with team strengths, and managed project timelines to meet deliverables.</div>" +
                "<div>• Devised innovative solutions to address complex challenges, driving project success and enhancing team efficiency.</div>"
            },
            new() {
                Title = "Senior Software Engineer",
                CompanyName = "TechnoVista Limited",
                CompanyWebUrl = "https://technovista.com.bd/",
                City = "Dhaka",
                StartDate = new DateTime(2018, 1, 1),
                EndDate = new DateTime(2023, 12, 31),
                Description = //"<div>• Working closely with project managers and clients from various business domain.</div>" +
                "<div>• Analyzed and translated complex client requirements into scalable technical solutions.</div>" +
                "<div>• As a development lead, help juniors understand and perform their tasks.</div>"
            },
            new() {
                Title = "Software Engineer",
                CompanyName = "TechnoVista Limited",
                CompanyWebUrl = "https://technovista.com.bd/",
                City = "Dhaka",
                StartDate = new DateTime(2016, 1, 1),
                EndDate = new DateTime(2017, 12, 31),
                Description = //"<div>• Worked closely with senior software engineers and analysts.</div>" +
                "<div>• Introduced a new framework (Serenity) in the company which reduces 50% development time.</div>" +
                "<div>• Recognized with a performance award for outstanding contributions and exceptional results.</div>"
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

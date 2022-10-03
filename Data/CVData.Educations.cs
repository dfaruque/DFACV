using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    private static List<EducationModel> GetEducations()
    {
        return new() {
            new() {
                Title = "Masters in Computer Science and Engineering (CSE)",
                InstituteName = "University of Information Technology and Sciences (UITS)",
                City = "Dhaka",
                StartDate = new DateTime(2021, 9, 1),
                //EndDate = new DateTime(2023, 8, 30),
                Result = "Running"
            },
            new() {
                Title = "Bachelor in Computer Science and Engineering (CSE)",
                InstituteName = "University of Information Technology and Sciences (UITS)",
                City = "Dhaka",
                StartDate = new DateTime(2010, 9, 1),
                EndDate = new DateTime(2014, 8, 30),
                Result = "CGPA 3.67 (Out of Scale 4) ─ Got scholarships in several semesters"
            },
            new() {
                Title = "Higher Secondary Certificate (H.S.C)",
                InstituteName = "Porsha Degree College",
                City = "Porsha, Naogaon",
                StartDate = new DateTime(2008, 1, 1),
                EndDate = new DateTime(2010, 3, 1),
                Result = "GPA 3.50 (Out of Scale 5)"
            },
            new() {
                Title = "Secondary School Certificate (S.S.C)",
                InstituteName = "Sapahar Pilot High School",
                City = "Sapahar, Naogaon",
                StartDate = new DateTime(2005, 1, 1),
                EndDate = new DateTime(2007, 3, 1),
                Result = "GPA 3.86 (Out of Scale 5)"
            },
        };
    }
}

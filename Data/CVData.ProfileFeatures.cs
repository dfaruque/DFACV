using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    private static List<string> GetProfileFeatures()
    {
        return new() {
            ExperienceYears + "+ years of professional software development experience",
            ProgrammingExperienceYears + "+ years of programming experience",
            "Knowledge of Object Oriented Programming (<b>OOP</b>)",
            "Follows software design principles <b>SOLID</b>, <b>DRY</b>, and <b>KISS</b>",
            "Strictly maintains coding conventions to write <b>clean code</b> and <b>maintainable software</b>",
            "Good skills in analyzing requirements, designing, coding, and testing",
            "Experience in <b>database design</b>, and <b>performance tuning</b>",
            //"Works in various sizes of projects small to large scale",
            "Knowledge in preventing various <b>web security</b> threats and attacks such as XSRF/CSRF, XSS, SQL Injection, DDoS attack, etc.",
            "Experienced in <b>RESTful API</b> and <b>JWT</b>",
            "Knowledge of <b>image processing</b> and <b>computer vision</b>",
            "Experience in <b>data extraction</b> and <b>transformation</b> from <b>Image</b>, <b>PDF</b>, and <b>Excel</b> files",
            "Ability to jump into any problem and able to develop “<b>outside the box</b>” solutions",
            //"Experience to work remote environment",
            "Contributes to open source projects. Notably Serenity platform",
        };
    }
}

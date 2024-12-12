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
            "Over <b>" + ExperienceYears + " years</b> of professional software development experience and " + ProgrammingExperienceYears + "+ years of programming experience.",
            "Experienced in all phases of Software Development Life Cycle (<b>SDLC</b>) including analysis, design, development, testing and implementation of high quality & complex software.",
            "Strong foundation in Object Oriented Programming (<b>OOP</b>) and adherence to software design principles such as <b>SOLID</b>, <b>DRY</b>, and <b>KISS</b>, resulting in the creation of clean and efficient code that is easy to understand and modify.",
            "Knowledgeable in <b>design patterns</b> such as singleton, repository, dependency injection, and more.",
            "Experience in <b>database design</b>, and <b>performance tuning</b>.",
            //"Works in various sizes of projects small to large scale",
            //"Knowledgeable in preventing <b>web security</b> threats and attacks such as XSRF/CSRF, XSS, SQL Injection, DDoS attacks, and more, ensuring that applications are secure and reliable.",
            "Experienced in <b>RESTful API</b> and <b>JWT.</b>",
            "Familiarity with <b>image processing</b> and <b>computer vision</b>, allowing for the creation of solutions that process visual data in innovative ways.",
            "Capable of <b>extracting</b> and <b>transforming</b> data from various file types, including Image, PDF, and Excel, to streamline workflows and increase productivity.",
            //"Ability to jump into any problem and able to develop “<b>outside the box</b>” solutions",
            //"Experience to work remote environment",
            "Contributes to <b>open-source</b> projects, with notable contributions to the <b>Serenity platform</b>, demonstrating dedication to advancing the field of software development.",
        };
    }
}

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
            "Over <b>" + ExperienceYears + " years</b> of professional software development experience and " + ProgrammingExperienceYears + "+ years of programming expertise.",
            "Skilled in all <b>SDLC</b> phases, including analysis, design, development, testing, and implementation of complex software.",
            "Strong <b>OOP</b> foundation, adhering to <b>SOLID</b>, <b>DRY</b>, and <b>KISS</b> principles for clean, maintainable code.",
            "Knowledgeable in <b>design patterns</b> such as singleton, repository, dependency injection.",
            //"Experience in <b>database design</b>, and <b>performance tuning</b>.",
            //"Works in various sizes of projects small to large scale",
            //"Knowledgeable in preventing <b>web security</b> threats and attacks such as XSRF/CSRF, XSS, SQL Injection, DDoS attacks, and more, ensuring that applications are secure and reliable.",
            "Proficient in a range of web technologies, including <b>ASP.NET Core, MVC, Web API, Blazor, and React</b>, with hands-on experience in designing and implementing robust web applications.",
            "Knowledgeable in <b>image processing</b> and <b>computer vision</b> for innovative visual data solutions.",
            "Skilled in <b>data extraction and transformation</b> from Image, PDF, JSON, CSV and Excel files.",
            //"Ability to jump into any problem and able to develop “<b>outside the box</b>” solutions",
            //"Experience to work remote environment",
            "Active <b>open-source</b> contributor, including significant work on the <b>Serenity platform</b>.",
        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    private static List<ReferenceModel> GetReferences()
    {
        return new() {
            new() {
                Name = "Firoz Ahmed",
                Position = "Senior Software Engineer",
                Organization = "TechnoVista Limited",
                Contact = "+880 1723 427 588",
                Email = "firoz7588@gmail.com"
            },
            new() {
                Name = "Md. Shakhawat Hossain",
                Position = "ICT Specialist",
                Organization = "Local Government Engineering Department (LGED)",
                Contact = "+880 1713 045 757",
                Email = "shakhawat.hossain@yahoo.com"
            }
        };
    }
}

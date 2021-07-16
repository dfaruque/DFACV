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
        List<ExperienceModel> Experiences { get; set; }
        List<EducationModel> Educations { get; set; }
    }
}

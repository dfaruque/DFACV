using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFACV.Models
{
    public class ExperienceModel
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyWebUrl { get; set; }
        public string City { get; set; }
        public string Description { get; set; }

        public int StartYear => StartDate.Year;
        public string EndYear => EndDate?.Year.ToString() ?? "Present";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFACV.Models
{
    public class ProjectModel
    {
        public string Title { get; set; }
        public string Role { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ClientName { get; set; }
        public string ClientCity { get; set; }
        public string Type { get; set; }
        public string ProgrammingLanguages { get; set; }
        public string Databases { get; set; }
        public string UsedTechnologies { get; set; }
        public string Description { get; set; }
        public string ProjectUrl { get; set; }
        public string ProjectSource { get; set; }
        public string ProjectDoc { get; set; }
        public string MoreDescription { get; set; }
        public string Challenges { get; set; }

        public string Period => StartDate.ToString("MMM yyyy") + " - " + (EndDate == null ? "Present" : EndDate?.ToString("MMM yyyy"));
    }
}

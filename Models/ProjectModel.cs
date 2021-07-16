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
    }
}

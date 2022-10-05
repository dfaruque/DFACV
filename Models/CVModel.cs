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
        public string Profile { get; set; }
        public List<string> Features { get; set; }
        public List<SkillGroup> Skills { get; set; }
        public List<CommunicationLanguageModel> CommunicationLanguages { get; set; }
        public List<ExperienceModel> Experiences { get; set; }
        public List<EducationModel> Educations { get; set; }
        public List<ProjectModel> Projects { get; set; }
        public List<ProjectModel> HobbyProjects { get; set; }
        public List<ProjectModel> OpenSourceContributions { get; set; }
        public List<AwardModel> Awards { get; set; }
        public List<ContactModel> Contacts { get; set; }
        public List<SocialMediaModel> SocialMedias { get; set; }
        public List<ReferenceModel> References { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFACV.Models
{
    public class SkillModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SkillStrength Strength { get; set; }
    }

    public enum SkillStrength
    {
        None = 0,
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3,
        Expert = 4
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFACV.Models
{
    public class SkillGroup
    {
        public string Name { get; set; }
        public string IconClass { get; set; }
        public List<SkillGroup> SkillSubGroups { get; set; }
        public List<SkillItem> Items { get; set; }
    }

    public class SkillItem
    {
        public string Name { get; set; }
        public string IconClass { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SkillStrength Strength { get; set; }
    }

    public enum SkillStrength
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3,
        Expert = 4,
        Master = 5
    }
}

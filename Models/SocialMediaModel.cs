using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFACV.Models
{
    public class SocialMediaModel
    {
        public SocialMediaType Type { get; set; }
        public string Value { get; set; }
    }

    public enum SocialMediaType
    {
        LinkedIn = 1,
        Github = 2,
        Facebook = 3,
        Twitter = 4,
    }
}

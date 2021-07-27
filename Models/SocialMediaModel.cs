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
        public string IconClass
        {
            get
            {
                string iconClass;
                switch (Type)
                {
                    case SocialMediaType.Github:
                        iconClass = "github";
                        break;
                    case SocialMediaType.LinkedIn:
                        iconClass = "linkedin";
                        break;
                    default:
                        iconClass = "";
                        break;
                }
                return iconClass;
            }
        }

    }

    public enum SocialMediaType
    {
        LinkedIn = 1,
        Github = 2,
        Facebook = 3,
        Twitter = 4,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    private static List<SocialMediaModel> GetSocialMedias()
    {
        return new() {
            new() {
                Type = SocialMediaType.Github,
                Value = "dfaruque"
            },
            new() {
                Type = SocialMediaType.LinkedIn,
                Value = "dfaruque"
            }
        };
    }
}

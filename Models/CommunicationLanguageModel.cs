using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFACV.Models
{
    public class CommunicationLanguageModel
    {
        public string Name { get; set; }
        public CommunicationLanguageLevel CommunicationLanguageLevel { get; set; }
    }

    public enum CommunicationLanguageLevel
    {
        Native = 1,
        Professional = 2,
        Elementary = 3,
    }
}

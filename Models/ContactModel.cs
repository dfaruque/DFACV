using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFACV.Models
{
    public class ContactModel
    {
        public ContactType Type { get; set; }
        public string Value { get; set; }
    }

    public enum ContactType
    {
        Mobile = 0,
        Email = 1,
        ResidencialAddress = 2,
    }
}

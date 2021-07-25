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
        public string IconClass
        {
            get
            {
                var iconClass = "oi oi-";
                switch (Type)
                {
                    case ContactType.Mobile:
                        iconClass += "phone";
                        break;
                    case ContactType.Email:
                        iconClass += "envelope-closed";
                        break;
                    case ContactType.ResidencialAddress:
                        iconClass += "home";
                        break;
                    default:
                        break;
                }
                return iconClass;
            }
        }
    }
    public enum ContactType
    {
        Mobile = 0,
        Email = 1,
        ResidencialAddress = 2,
    }
}

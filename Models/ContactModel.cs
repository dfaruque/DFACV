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
                string iconClass;
                switch (Type)
                {
                    case ContactType.Mobile:
                        iconClass = "phone";
                        break;
                    case ContactType.Skype:
                        iconClass = "skype";
                        break;
                    case ContactType.Email:
                        iconClass = "envelope";
                        break;
                    case ContactType.Location:
                        iconClass = "map-marker";
                        break;
                    case ContactType.ResidencialAddress:
                        iconClass = "home";
                        break;
                    default:
                        iconClass = "";
                        break;
                }
                return iconClass;
            }
        }
    }
    public enum ContactType
    {
        Mobile = 0,
        Skype = 1,
        Email = 2,
        Location = 3,
        ResidencialAddress = 4,
    }
}

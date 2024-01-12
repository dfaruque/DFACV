using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    private static List<ContactModel> GetContacts()
    {
        return new() {
            //new() {
            //    Type = ContactType.ResidencialAddress,
            //    Value = "Dag#8380, Barua (Paschim Para), Khilkhet, Dhaka-1229, Bangladesh"
            //},
            new() {
                Type = ContactType.Location,
                Value = "Khilkhet, Dhaka, Bangladesh"
            },
            new() {
                Type = ContactType.Email,
                Value = "dfaruque@gmail.com"
            },
            new() {
                Type = ContactType.Mobile,
                Value = "+880 1734 588 155"
            },
            new() {
                Type = ContactType.Website,
                Value = "dfaruque.github.io"
            },
            new() {
                Type = ContactType.Skype,
                Value = "d.faruque"
            },
        };
    }
}

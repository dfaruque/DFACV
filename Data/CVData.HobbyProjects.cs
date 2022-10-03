using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    private static List<ProjectModel> GetHobbyProjects()
    {
        return new() {
            new() {
                Title = "English to Bangla Machine Translator",
                StartDate = new DateTime(2012, 1, 1),
                EndDate = new DateTime(2014, 1, 1),
                UsedTechnologies = ".Net Framework 3.5, C#, MS SQL Server",
                Description = "A rule based english to bangla machine translator. It like a poor man's google translator.",
            },
            new() {
                Title = "Quran Study Tool",
                StartDate = new DateTime(2012, 1, 1),
                EndDate = new DateTime(2012, 12, 31),
                UsedTechnologies = ".Net Framework 3.5, C#, Access Database, HTML, CSS, JavaScript, and Web Browser control",
                Description = "This tool can be used to reading, listening, searching the Holy Quran in different languages (Arabic, Bengali, English).",
            },
            new() {
                Title = "Santali Keyboard Layout",
                StartDate = new DateTime(2012, 1, 1),
                EndDate = new DateTime(2012, 12, 31),
                UsedTechnologies = ".Net Framework 3.0, C#, Windows API",
                Description = "Using this tool one can type Santali (Santali is a language)",
            },
            new() {
                Title = "English, Bengali Dictionary",
                StartDate = new DateTime(2011, 1, 1),
                EndDate = new DateTime(2011, 12, 31),
                UsedTechnologies = ".Net Framework 3.0, C#, MS Access Database",
                Description = "Using this tool one can type Santali (Santali is a language)",
            },
            new() {
                Title = "Virus (clever 9) and Antivirus",
                StartDate = new DateTime(2009, 1, 1),
                EndDate = new DateTime(2009, 12, 31),
                UsedTechnologies = "Visual Basic 6",
                Description = "This program is able to spread out PC to PC via USB disk and delete your files " +
                "without your awareness. It can disable windows task manager, registry editor, and group policy etc. " +
                "To prevent this virus from attack an antivirus software has also been developed.",
            },
            new() {
                Title = "USB Disk Cleaner",
                StartDate = new DateTime(2008, 1, 1),
                EndDate = new DateTime(2009, 12, 31),
                UsedTechnologies = "Visual Basic 6",
                Description = "This prevents viruses to spread from USB Disk.",
            },
            new() {
                Title = "Bangla & English Speed Type",
                StartDate = new DateTime(2008, 1, 1),
                EndDate = new DateTime(2009, 12, 31),
                UsedTechnologies = "Visual Basic 6",
                Description = "This helps people to increase their Bangla and English typing speed.",
            },
            new() {
                Title = "PC Cleaner",
                StartDate = new DateTime(2007, 1, 1),
                EndDate = new DateTime(2009, 12, 31),
                UsedTechnologies = "Visual Basic 6",
                Description = "Clean up the temporary files that are no longer need.",
            },
        };
    }
}

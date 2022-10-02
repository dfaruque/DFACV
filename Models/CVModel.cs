using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFACV.Models
{
    public class CVModel
    {
        public string Name { get; set; }
        public string FunctionTitle { get; set; }
        public string Profile { get; set; }
        public List<string> Features { get; set; }
        public List<SkillGroup> Skills { get; set; }
        public List<CommunicationLanguageModel> CommunicationLanguages { get; set; }
        public List<ExperienceModel> Experiences { get; set; }
        public List<EducationModel> Educations { get; set; }
        public List<ProjectModel> Projects { get; set; }
        public List<ProjectModel> HobbyProjects { get; set; }
        public List<AwardModel> Awards { get; set; }
        public List<ContactModel> Contacts { get; set; }
        public List<SocialMediaModel> SocialMedias { get; set; }
        public List<ReferenceModel> References { get; set; }

        public double ExperienceYears => DateTime.Today.Year - Experiences.Min(m => m.StartDate).Year;
        public static double ProgrammingExperienceYears => DateTime.Today.Year - 2006;

        public CVModel()
        {
            Name = "Deowan Faruque Ahamed";
            FunctionTitle = "Senior Software Engineer | Full-stack .NET Developer";
            Contacts = new() {
                //new() {
                //    Type = ContactType.ResidencialAddress,
                //    Value = "Dag#8380, Barua (Paschim Para), Khilkhet, Dhaka-1229, Bangladesh"
                //},
                new() {
                    Type = ContactType.Location,
                    Value = "Dhaka, Bangladesh"
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
            SocialMedias = new() {
                new() {
                    Type = SocialMediaType.Github,
                    Value = "dfaruque"
                },
                new() {
                    Type = SocialMediaType.LinkedIn,
                    Value = "dfaruque"
                }
            };
            Profile = "Strong planner and problem solver who readily adapts to change, works independently and exceeds expectations. " +
                "Begins programming in school life and dreams to become a Software Engineer.";

            Skills = new() {
                new() {
                    Name = "Programming Languages",
                    IconClass = "code",
                    Items = new() {
                        new() {
                            Name = "C#",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Expert
                        },
                        new() {
                            Name = "TypeScript",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Expert
                        },
                        new() {
                            Name = "JavaScript",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new() {
                            Name = "Java",
                            StartDate = new DateTime(2019, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "Python",
                            StartDate = new DateTime(2019, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                    }
                },
                new() {
                    Name = "Databases",
                    IconClass = "database",
                    Items = new() {
                        new() {
                            Name = "MS SQL Server",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Expert
                        },
                        new() {
                            Name = "Oracle",
                            StartDate = new DateTime(2015, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new() {
                            Name = "MySQL",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "SQLite",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "Redis",
                            StartDate = new DateTime(2019, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                    }
                },
                new() {
                    Name = "Web-development",
                    IconClass = "globe",
                    Items = new() { },
                    SkillSubGroups = new() {
                        new() {
                            Name = "Back-end",
                            IconClass = "server",
                            Items = new() {
                                new() {
                                    Name = "ASP.NET",
                                    StartDate = new DateTime(2012, 1, 1),
                                    Strength = SkillStrength.Expert
                                },
                                new() {
                                    Name = "Serenity.is",
                                    StartDate = new DateTime(2016, 1, 1),
                                    Strength = SkillStrength.Expert
                                },
                                new() {
                                    Name = "Node.js",
                                    StartDate = new DateTime(2016, 1, 1),
                                    Strength = SkillStrength.Intermediate
                                }
                            }
                        },
                        new() {
                            Name = "Front-end",
                            IconClass = "window-maximize",
                            Items = new() {
                                new() {
                                    Name = "HTML",
                                    StartDate = new DateTime(2012, 1, 1),
                                    Strength = SkillStrength.Advanced
                                },
                                new() {
                                    Name = "CSS",
                                    StartDate = new DateTime(2012, 1, 1),
                                    Strength = SkillStrength.Advanced
                                },
                                new() {
                                    Name = "jQuery",
                                    StartDate = new DateTime(2012, 1, 1),
                                    Strength = SkillStrength.Advanced
                                },
                                new() {
                                    Name = "Bootstrap.css",
                                    StartDate = new DateTime(2016, 1, 1),
                                    Strength = SkillStrength.Advanced
                                },
                                new() {
                                    Name = "Angular.js",
                                    StartDate = new DateTime(2016, 1, 1),
                                    Strength = SkillStrength.Intermediate
                                },
                                new() {
                                    Name = "Vue.js",
                                    StartDate = new DateTime(2016, 1, 1),
                                    Strength = SkillStrength.Intermediate
                                },
                                new() {
                                    Name = "React.js",
                                    StartDate = new DateTime(2018, 1, 1),
                                    Strength = SkillStrength.Intermediate
                                },
                                new() {
                                    Name = "Blazor",
                                    StartDate = new DateTime(2020, 1, 1),
                                    Strength = SkillStrength.Intermediate
                                }
                            }
                        }
                    },
                },
                new() {
                    Name = "Desktop-development",
                    IconClass = "desktop",
                    Items = new() {
                        new() {
                            Name = "WinForms",
                            StartDate = new DateTime(2010, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "WPF",
                            StartDate = new DateTime(2014, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "Electron.js",
                            StartDate = new DateTime(2017, 1, 1),
                            Strength = SkillStrength.Intermediate
                        }
                    }
                },
                new() {
                    Name = "Mobile-development",
                    IconClass = "mobile",
                    Items = new() {
                        new() {
                            Name = "Xamarin",
                            StartDate = new DateTime(2018, 1, 1),
                            Strength = SkillStrength.Beginner
                        }
                    }
                },
                new() {
                    Name = "Testing-frameworks",
                    IconClass = "flask",
                    Items = new() {
                        new() {
                            Name = "NUnit / xUnit / MSTest",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new() {
                            Name = "SpecFlow",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "Selenium",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Intermediate
                        }
                    }
                },
                new() {
                    Name = "ORMs",
                    IconClass = "exchange",
                    Items = new() {
                        new() {
                            Name = "Dapper",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new() {
                            Name = "Entity Framework",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Advanced
                        }
                    }
                },
                new() {
                    Name = "Others",
                    IconClass = "square-o",
                    Items = new() {
                        new() {
                            Name = "Git",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new() {
                            Name = "OpenCV",
                            StartDate = new DateTime(2018, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "Babylon.js",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "WebGL",
                            StartDate = new DateTime(2017, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "Tesseract OCR",
                            StartDate = new DateTime(2018, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "Swagger",
                            StartDate = new DateTime(2020, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new() {
                            Name = "Jupyter Notebook",
                            StartDate = new DateTime(2020, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                    }
                },
            };

            CommunicationLanguages = new() {
                new() { Name = "Bengali", CommunicationLanguageLevel = CommunicationLanguageLevel.Native },
                new() { Name = "English", CommunicationLanguageLevel = CommunicationLanguageLevel.Professional },
                //new() { Name = "Arabic", CommunicationLanguageLevel = CommunicationLanguageLevel.Elementary },
            };

            Experiences = new() {
                new() {
                    Title = "Senior Software Engineer",
                    CompanyName = "TechnoVista Limited",
                    CompanyWebUrl = "https://technovista.com.bd/",
                    City = "Dhaka",
                    StartDate = new DateTime(2018, 1, 1),
                    EndDate = null,
                    Description = "<div>→ Working closely with project managers and clients.</div>" +
                    "<div>→ Collecting client requirements and convert them to the technical solution.</div>" +
                    "<div>→ As a project development lead, help juniors to understand and perform their tasks.</div>"
                },
                new() {
                    Title = "Software Engineer",
                    CompanyName = "TechnoVista Limited",
                    CompanyWebUrl = "https://technovista.com.bd/",
                    City = "Dhaka",
                    StartDate = new DateTime(2016, 1, 1),
                    EndDate = new DateTime(2017, 12, 31),
                    Description = "<div>→ Worked closely with senior software engineers and analysts.</div>" +
                    "<div>→ Understood business and developed accordingly.</div>" +
                    "<div>→ Got performance award!</div>"
                },
                new() {
                    Title = "Software Developer",
                    CompanyName = "Unisoft Systems Limited",
                    CompanyWebUrl = "http://www.uslbd.com/",
                    City = "Dhaka",
                    StartDate = new DateTime(2014, 11, 1),
                    EndDate = new DateTime(2015, 12, 31),
                    Description = "<div>→ Worked as a development team member of an ERP system.</div>" +
                    "<div>→ Understood business from analyst and developed accordingly.</div>"
                },
            };

            Educations = new() {
                new() {
                    Title = "Masters in Computer Science and Engineering (CSE)",
                    InstituteName = "University of Information Technology and Sciences (UITS)",
                    City = "Dhaka",
                    StartDate = new DateTime(2021, 9, 1),
                    //EndDate = new DateTime(2023, 8, 30),
                    Result = "Running"
                },
                new() {
                    Title = "Bachelor in Computer Science and Engineering (CSE)",
                    InstituteName = "University of Information Technology and Sciences (UITS)",
                    City = "Dhaka",
                    StartDate = new DateTime(2010, 9, 1),
                    EndDate = new DateTime(2014, 8, 30),
                    Result = "CGPA 3.67 (Out of Scale 4) ─ Got scholarships in several semesters"
                },
                new() {
                    Title = "Higher Secondary Certificate (H.S.C)",
                    InstituteName = "Porsha Degree College",
                    City = "Porsha, Naogaon",
                    StartDate = new DateTime(2008, 1, 1),
                    EndDate = new DateTime(2010, 3, 1),
                    Result = "GPA 3.50 (Out of Scale 5)"
                },
                new() {
                    Title = "Secondary School Certificate (S.S.C)",
                    InstituteName = "Sapahar Pilot High School",
                    City = "Sapahar, Naogaon",
                    StartDate = new DateTime(2005, 1, 1),
                    EndDate = new DateTime(2007, 3, 1),
                    Result = "GPA 3.86 (Out of Scale 5)"
                },
            };

            Projects = new() {
                new() {
                    Title = "Integrated Centralized Billing System for Palli Bidyut Samities",
                    Role = "Analyst & Development Lead",
                    StartDate = new DateTime(2019, 3, 1),
                    EndDate = null,
                    ClientName = "Bangladesh Rural Electrification Board (BREB)",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#, TypeScript",
                    Databases = "Oracle, Redis",
                    UsedTechnologies = "ASP.NET MVC, Serenity.is, Dapper, SlikGrid, OpenCV",
                    Type = "Web-based",
                    Description = "A large-scale billing system. " +
                    "Over 500 workspaces will be using the system from all over the country. " +
                    "Over 30 million  electricity bills will be processed per month by this system. " +
                    "Modules for this system are Electricity Meter Reading by Image Capturing, " +
                    "New Connection Application, Consumer Management, Billing, Collection, and " +
                    "Accounting management system.",
                    Responsibilities = @"<ul>
    <li>Involved since the project initialization.</li>
    <li>Collecting requirements and visiting client premises in several locations.</li>
    <li>Involved in writing Software Requirement Specification (SRS).</li>
    <li>Designed mock UI to present and discuss with the client for requirement clarification.</li>
    <li>Designed database and corresponding user interfaces.</li>
    <li>Write back-end and front-end validation and business logic.</li>
    <li>Write unit test cases for critical business rules.</li>
    <li>Performed research and development (R&D) for electricity meter reading by capturing meter images.</li>
    <li>Deployed the system to the client's data center (about 20 servers).</li>
    <li>Developed a server manager tool to deploy the published application files to the servers using SSH and SCP.</li>
</ul>",

                    Challenges = @"<ul>
    <li>Initially, the software was developed using the MS SQL server database. 
        But later, client choose to use the oracle database. So a large-scale database migration task is performed. 
        Now the system is working fine with both databases.
    </li>
    <li>The software was developed using .NET Framework 4.5. But later, we migrated to .NET 6</li>
    <li>Since it is a financial system, network security is the priority. 
        So, different network zones (VPN, DMZ) are used for modules. 
        The data synchronization between zones was a challenge.
    </li>
    <li>Almost all banks in Bangladesh are connected to this system via VPN. 
        We have to support them in implementing our bill payment API
    </li>
    <li>There are legacy data with a different shape for each workspace. We have to migrate them into our system.</li>
</ul>",
                },
                new() {
                    Title = "Port Automation System",
                    Role = "Analyst & Development Lead",
                    StartDate = new DateTime(2016, 7, 1),
                    EndDate = new DateTime(2018, 3, 1),
                    ClientName = "Mongla Port Authority",
                    ClientCity = "Mongla, Bagerhat",
                    ProgrammingLanguages="C#, TypeScript",
                    Databases = "SQL Server",
                    UsedTechnologies = "ASP.NET MVC, Serenity.is, Dapper, SlikGrid, Vue.js, WebGL, Babylon.js",
                    Type = "Web-based",
                    Description = "This is a complete sea port automation system used at Mongla Port. " +
                    "Modules for this system are Container Yard, Transit Shed and Port Billing etc. " +
                    "Integration with ASYCUDA through IGM."
                },
                new() {
                    Title = "E-Licensing System",
                    Role = "Analyst & Development Lead",
                    StartDate = new DateTime(2017, 7, 1),
                    EndDate = new DateTime(2018, 2, 28),
                    ClientName = "Bangladesh Energy Regulatory Commission (BERC)",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#, TypeScript",
                    Databases = "SQL Server",
                    UsedTechnologies = "ASP.NET MVC, Serenity.is, Vuejs",
                    Type = "Web-based",
                    Description = "Online licensing and approval system for any business entities of " +
                    "Power/Gas/Petroleum Production, Transition or Distribution Companies",
                    ProjectUrl = "http://elicense.berc.org.bd/"
                },
                new() {
                    Title = "IATI Import Module",
                    Role = "Developer",
                    StartDate = new DateTime(2016, 1, 1),
                    EndDate = new DateTime(2016, 6, 30),
                    ClientName = "ERD, Govt. of Bangladesh, financed by UNDP, DFID",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#, TypeScript",
                    Databases = "SQL Server, RavenDB",
                    UsedTechnologies = "ASP.NET MVC, Entity Framework, AngularJs",
                    Type = "Web-based",
                    Description = "This project integrates AIMS Bangladesh with IATI where Development partners " +
                    "publish their data of aid activities through the International Aid Transparency Initiative (IATI). " +
                    "This project's aim is to start using IATI data in Bangladesh's Aid Information Management System (AIMS) " +
                    "and to improve the quality of the data held in the AIMS and reduce the burden of data collection.",
                    ProjectUrl = "http://aims.erd.gov.bd/IATIImportSite",
                    ProjectSource = "https://github.com/BD-IATI/edi",
                    ProjectDoc = "http://bd-iati.github.io/",
                },
                new() {
                    Title = "Security (User Management) Module",
                    Role = "Main Developer",
                    StartDate = new DateTime(2016, 3, 1),
                    EndDate = new DateTime(2016, 6, 30),
                    ClientName = "LGED, BEPZA, SDF and many others",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#, TypeScript",
                    Databases = "Cross Database (SQL Server/Oracle/MySQL etc.)",
                    UsedTechnologies = "ASP.NET MVC, Serenity.is, Vuejs",
                    Type = "Web-based",
                    Description = "This is a cross database, single-sign-on (SSO) user management module " +
                    "which can be integrated with any project",
                },
                new() {
                    Title = "Warehouse and Inventory Management System (WIMS)",
                    Role = "Developer",
                    StartDate = new DateTime(2016, 1, 1),
                    EndDate = new DateTime(2016, 6, 30),
                    ClientName = "Banglalink Digital Communication System",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#, JavaScript",
                    Databases = "Oracle",
                    UsedTechnologies = "ASP.NET Web Forms, WCF",
                    Type = "Web-based",
                    Description = "Enhancing WIMS by adding new features like: Automatic item re-order " +
                    "and requisition system, item issue trend analysis; Real time integration WIMS-LMS " +
                    "(Loyalty Management System) a gift distribution system of Banglalink through WCF service",
                },
                new() {
                    Title = "UniERP Business Solutions",
                    Role = "Main Developer",
                    StartDate = new DateTime(2014, 11, 1),
                    EndDate = new DateTime(2015, 12, 31),
                    ClientName = "Golden Life Insurance Ltd., Gentle Park | Bismillah Holdings Ltd.",
                    ClientCity = "Dhaka, Bangladesh | National Capital District, Papua New Guinea",
                    ProgrammingLanguages="C#, JavaScript",
                    Databases = "SQL Server/Oracle",
                    UsedTechnologies = "ASP.NET WebForms, Entity Framework, Crystal Reports",
                    Type = "Web-based",
                    Description = "Solution to the all business needs including Finances, Human resources, " +
                    "Manufacturing, Supply chain and etc.",
                },
                new() {
                    Title = "Restricted Logon System",
                    Role = "Analyst & Development Lead",
                    StartDate = new DateTime(2013, 8, 1),
                    EndDate = new DateTime(2014, 11, 30),
                    ClientName = "Siatex Ltd",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#",
                    Databases = "My SQL",
                    UsedTechnologies = ".NET Framework, WinForms and WPF",
                    Type = "Desktop-based",
                    Description = "Security-software that can restrict employees to do unauthorized " +
                    "access of apps and websites, monitor employees’ activity and send screenshots to " +
                    "the server, remotely change the employees’ privileges. It also provides file sharing " +
                    "and chatting facility.",
                    MoreDescription = @"<b>Features:</b> The features are applicable for specific user or group of users.
<ul>
<li><b>Block Applications</b>– Users can run only those apps that are assigned to him and all others apps are blocked. So they cannot waste their office time by playing games or watching movies.</li>
<li><b>Block websites</b>– This feature helps you to block the specific websites that are used to passing time such as Facebook and twitter etc.</li>
<li><b>Prevent access to specific hard disk drive</b>– Users can only access those disk drives that are assigned to him. If a user have only d: and f: drives then he can only access these drives.</li>
<li><b>Restrict from using USB drive/Pen drive/CD-DVD drive</b>– USB drives are used to transfer files from one PC to another PC. Prevent using these drives; you can safe valuable data/files.</li>
<li><b>Automatically capture screenshots and send it to the server</b>– this software capture screenshots of the specific apps at a specific interval and send it to the server. You can see these screenshots whenever you want.</li>
<li><b>File transferring/sharing</b>– it is easy to transfer files using this software, you have to select a file. The file is automatically uploaded to the server and at the receiver’s PC it is automatically downloaded.</li>
<li><b>Chatting</b>– The users can send messages instantly. Supports private and public chat.</li>
<li><b>Protects from viruses</b>– Since this software blocks all unnecessary apps including viruses, so you do not need an antivirus.</li>
</ul>",
                },
            };

            HobbyProjects = new() {
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

            Awards = new() {
                new() {
                    Name = "Performance Award",
                    Year = 2017,
                    GivenBy = "TechnoVista Limited"
                },
            };

            Features = new() {
                ExperienceYears + "+ years of professional software development experience",
                ProgrammingExperienceYears + "+ years of programming experience",
                "Knowledge of Object Oriented Programming (<b>OOP</b>)",
                "Follows software design principles <b>SOLID</b>, <b>DRY</b>, and <b>KISS</b>",
                "Strictly maintains coding conventions to write <b>clean code</b> and <b>maintainable software</b>",
                "Good skills in analyzing requirements, designing, coding, and testing",
                "Experience in <b>database design</b>, and <b>performance tuning</b>",
                //"Works in various sizes of projects small to large scale",
                "Knowledge in preventing various <b>web security</b> threats and attacks such as XSRF/CSRF, XSS, SQL Injection, DDoS attack, etc.",
                "Experienced in <b>RESTful API</b> and <b>JWT</b>",
                "Knowledge of <b>image processing</b> and <b>computer vision</b>",
                "Experience in <b>data extraction</b> and <b>transformation</b> from <b>Image</b>, <b>PDF</b>, and <b>Excel</b> files",
                "Ability to jump into any problem and able to develop “<b>outside the box</b>” solutions",
                //"Experience to work remote environment",
                "Contributes to open source projects. Notably Serenity platform",
            };

            References = new() {
                new() {
                    Name = "Firoz Ahmed",
                    Position = "Senior Software Engineer",
                    Organization = "TechnoVista Limited",
                    Contact = "+880 1723 427 588",
                    Email = "firoz7588@gmail.com"
                },
                new() {
                    Name = "Md. Shakhawat Hossain",
                    Position = "ICT Specialist",
                    Organization = "Local Government Engineering Department (LGED)",
                    Contact = "+880 1713 045 757",
                    Email = "shakhawat.hossain@yahoo.com"
                }
            };
        }
    }
}

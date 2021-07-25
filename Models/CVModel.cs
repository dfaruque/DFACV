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
        public List<ExperienceModel> Experiences { get; set; }
        public List<EducationModel> Educations { get; set; }
        public List<ProjectModel> Projects { get; set; }
        public List<ContactModel> Contacts { get; set; }
        public List<SocialMediaModel> SocialMedias { get; set; }
        public List<ReferenceModel> References { get; set; }

        public CVModel()
        {
            Name = "Deowan Faruque Ahamed";
            FunctionTitle = "Senior Software Engineer | Full-stack .Net Developer";
            Contacts = new List<ContactModel> { 
                new ContactModel {
                    Type = ContactType.Mobile,
                    Value = "+880 1734 588 155"
                },
                new ContactModel {
                    Type = ContactType.Email,
                    Value = "dfaruque@gmail.com"
                },
                new ContactModel {
                    Type = ContactType.ResidencialAddress,
                    Value = "Dag No. 8380, Barua (Paschim Para), Khilkhet, Dhaka - 1229"
                }
            };
            Profile = @"Strong planner and problem solver who readily adapts to change, works independently and exceeds expectations. To chase highly challenging ventures where I can contribute to the organizational goals thereby acquire new technical skills and contribute constructively";
            Features = new List<string> {
                "7+ years of professional software development experience",
                "11+ years of programming experience",
                "Like to write clean and maintainable code",
                "Good skills on analyzing requirements, designing, coding and testing",
                "Knowledge on Object Oriented Programming (OOP) and SOLID principles",
                "Familiar with Relational Database Management System (RDBMS) and SQL",
                "Knowledge on Big data and NoSQL",
                "Knowledge on Image processing and Computer Vision",
                "Experience to work remotely"
            };

            Skills = new List<SkillGroup> {
                new SkillGroup {
                    Name = "Programming Languages",
                    Items = new List<SkillItem> {
                        new SkillItem {
                            Name = "C#",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new SkillItem {
                            Name = "Typescript",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new SkillItem {
                            Name = "Javascript",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new SkillItem {
                            Name = "Python",
                            StartDate = new DateTime(2019, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                    }
                },
                new SkillGroup {
                    Name = "Databases",
                    Items = new List<SkillItem> {
                        new SkillItem {
                            Name = "MS SQL Server",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new SkillItem {
                            Name = "Oracle",
                            StartDate = new DateTime(2015, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new SkillItem {
                            Name = "MySQL",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new SkillItem {
                            Name = "NoSQL (MongoDB, RavenDB, etc.)",
                            StartDate = new DateTime(2019, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                    }
                },
                new SkillGroup {
                    Name = "Web-development Back-end",
                    Items = new List<SkillItem> {
                        new SkillItem {
                            Name = "ASP.Net MVC",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Advanced
                        },
                        new SkillItem {
                            Name = "Serenity.is",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Expert
                        }
                    }
                },
                new SkillGroup {
                    Name = "Web-development Front-end",
                    Items = new List<SkillItem> {
                        new SkillItem {
                            Name = "Blazor WebAssembly",
                            StartDate = new DateTime(2020, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new SkillItem {
                            Name = "Angular",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new SkillItem {
                            Name = "Vue.js",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new SkillItem {
                            Name = "React.js",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Intermediate
                        }
                    }
                },
                new SkillGroup {
                    Name = "Desktop-development",
                    Items = new List<SkillItem> {
                        new SkillItem {
                            Name = "WinForms",
                            StartDate = new DateTime(2010, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new SkillItem {
                            Name = "WPF",
                            StartDate = new DateTime(2014, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new SkillItem {
                            Name = "Electron.js",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Intermediate
                        }
                    }
                },
                new SkillGroup {
                    Name = "Testing-frameworks",
                    Items = new List<SkillItem> {
                        new SkillItem {
                            Name = "NUnit/xUnit/MSTest",
                            StartDate = new DateTime(2016, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new SkillItem {
                            Name = "SpecFlow",
                            StartDate = new DateTime(2014, 1, 1),
                            Strength = SkillStrength.Intermediate
                        },
                        new SkillItem {
                            Name = "Selenium",
                            StartDate = new DateTime(2012, 1, 1),
                            Strength = SkillStrength.Intermediate
                        }
                    }
                },
            };

            Experiences = new List<ExperienceModel> {
                new ExperienceModel {
                    Title = "Senior Software Engineer",
                    CompanyName = "TechnoVista Limited",
                    CompanyWebUrl = "https://technovista.com.bd/",
                    City = "Dhaka",
                    StartDate = new DateTime(2018, 1, 1),
                    EndDate = null,
                    Description = ""
                },
                new ExperienceModel {
                    Title = "Software Engineer",
                    CompanyName = "TechnoVista Limited",
                    CompanyWebUrl = "https://technovista.com.bd/",
                    City = "Dhaka",
                    StartDate = new DateTime(2016, 1, 1),
                    EndDate = new DateTime(2017, 12, 31),
                    Description = ""
                },
                new ExperienceModel {
                    Title = "Software Developer",
                    CompanyName = "Unisoft Systems Limited",
                    CompanyWebUrl = "http://www.uslbd.com/",
                    City = "Dhaka",
                    StartDate = new DateTime(2014, 11, 1),
                    EndDate = new DateTime(2015, 12, 31),
                    Description = ""
                },
            };

            Educations = new List<EducationModel> {
                new EducationModel {
                    Title = "Bachelor of Computer Science and Engineering (CSE)",
                    InstituteName = "University of Information Technology and Sciences (UITS)",
                    City = "Dhaka",
                    StartDate = new DateTime(2010, 9, 1),
                    EndDate = new DateTime(2014, 8, 30),
                    Result = "CGPA 3.67 (Out of Scale 4)"
                },
                new EducationModel {
                    Title = "Higher Secondary Certificate (H.S.C)",
                    InstituteName = "Porsha Degree College",
                    City = "Porsha, Naogaon",
                    StartDate = new DateTime(2008, 1, 1),
                    EndDate = new DateTime(2010, 3, 1),
                    Result = "GPA 3.50 (Out of Scale 5)"
                },
                new EducationModel {
                    Title = "Secondary School Certificate (S.S.C)",
                    InstituteName = "Sapahar Pilot High School",
                    City = "Sapahar, Naogaon",
                    StartDate = new DateTime(2005, 1, 1),
                    EndDate = new DateTime(2007, 3, 1),
                    Result = "GPA 3.86 (Out of Scale 5)"
                },
            };

            Projects = new List<ProjectModel> {
                new ProjectModel {
                    Title = "Integrated Centralized Billing System for Palli Bidyut Samities",
                    Role = "Analyst & Development Lead",
                    StartDate = new DateTime(2019, 3, 1),
                    EndDate = null,
                    ClientName = "Bangladesh Rural Electrification Board (BREB)",
                    ClientCity = "Dhaka,",
                    ProgrammingLanguages="C#, Typescript",
                    Databases = "Oracle, Couchbase",
                    UsedTechnologies = "ASP.NET MVC, Serenity.is, Dapper, SlikGrid, OpenCV",
                    Type = "Web-based",
                    Description = @"This is a complete billing system used at Bangladesh Rural Electrification Board (BREB). Modules for this system are Electricity Meter Reading by Image Capturing, Consumer Management, Billing, Collection, and Accounting"
                },
                new ProjectModel {
                    Title = "Port Automation System",
                    Role = "Analyst & Development Lead",
                    StartDate = new DateTime(2016, 7, 1),
                    EndDate = new DateTime(2018, 3, 1),
                    ClientName = "Mongla Port Authority",
                    ClientCity = "Mongla, Bagerhat",
                    ProgrammingLanguages="C#, Typescript",
                    Databases = "SQL Server",
                    UsedTechnologies = "ASP.NET MVC, Serenity.is, Dapper, SlikGrid, Vue.js, Babylon.js",
                    Type = "Web-based",
                    Description = @"This is a complete sea port automation system used at Mongla Port. Modules for this system are Container Yard, Transit Shed and Port Billing etc. Integration with ASYCUDA through IGM."
                },
                new ProjectModel {
                    Title = "IATI Import Module",
                    Role = "Developer",
                    StartDate = new DateTime(2016, 1, 1),
                    EndDate = new DateTime(2016, 6, 30),
                    ClientName = "ERD, Govt. of Bangladesh, financed by UNDP, DFID",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#, Typescript",
                    Databases = "SQL Server, RavenDB",
                    UsedTechnologies = "ASP.NET MVC, Entity Framework, AngularJs",
                    Type = "Web-based",
                    Description = @"This project integrates AIMS Bangladesh with IATI where Development partners publish their data of aid activities through the International Aid Transparency Initiative (IATI). This project's aim is to start using IATI data in Bangladesh's Aid Information Management System (AIMS) and to improve the quality of the data held in the AIMS and reduce the burden of data collection.",
                    ProjectUrl = "http://aims.erd.gov.bd/",
                    ProjectSource = "https://github.com/BD-IATI/edi",
                    ProjectDoc = "http://bd-iati.github.io/",
                },
                new ProjectModel {
                    Title = "Security (User Management) Module",
                    Role = "Main Developer",
                    StartDate = new DateTime(2016, 3, 1),
                    EndDate = new DateTime(2016, 6, 30),
                    ClientName = "LGED, BEPZA, SDF and many others",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#, Typescript",
                    Databases = "Cross Database (SQL Server/Oracle/MySQL etc.)",
                    UsedTechnologies = "ASP.NET MVC, Serenity.is, Vuejs",
                    Type = "Web-based",
                    Description = @"This is a cross database, signle-sign-on user management module which can be integrated with any project",
                },
                new ProjectModel {
                    Title = "UniERP Business Solutions",
                    Role = "Main Developer",
                    StartDate = new DateTime(2014, 11, 1),
                    EndDate = new DateTime(2015, 12, 31),
                    ClientName = "Golden Life Insurance Ltd.,, Gentle Park | Bismillah Holdings Ltd.",
                    ClientCity = "Dhaka, Bangladesh | National Capital District, Papua New Guinea",
                    ProgrammingLanguages="C#, Javascript",
                    Databases = "SQL Server/Oracle",
                    UsedTechnologies = "ASP.NET MVC, Serenity.is, Vuejs",
                    Type = "Web-based",
                    Description = @"Solution to the all business needs including Finances, Human resources, Manufacturing, Supply chain and etc.",
                },
                new ProjectModel {
                    Title = "E-Licensing System",
                    Role = "Analyst & Development Lead",
                    StartDate = new DateTime(2017, 7, 1),
                    EndDate = new DateTime(2018, 2, 28),
                    ClientName = "Bangladesh Energy Regulatory Commission (BERC)",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#, Typescript",
                    Databases = "SQL Server",
                    UsedTechnologies = "ASP.NET MVC, Serenity.is, Vuejs",
                    Type = "Web-based",
                    Description = @"Online licensing and approval system for any business entities of Power/Gas/Petroleum Production, Transition or Distribution Companies",
                },
                new ProjectModel {
                    Title = "Warehouse and Inventory Management System (WIMS)",
                    Role = "Developer",
                    StartDate = new DateTime(2016, 1, 1),
                    EndDate = new DateTime(2016, 6, 30),
                    ClientName = "Banglalink Digital Communication System",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#, Javascript",
                    Databases = "SQL Server",
                    UsedTechnologies = "ASP.NET Web Forms, WCF",
                    Type = "Web-based",
                    Description = @"Enhancing WIMS by adding new features like: Automatic item re-order and requisition system, item issue trend analysis; Real time integration WIMS-LMS (Loyalty Management System) a gift distribution system of Banglalink through WCF service",
                },
                new ProjectModel {
                    Title = "Restricted Logon System",
                    Role = "Analyst & Development Lead",
                    StartDate = new DateTime(2013, 8, 1),
                    EndDate = new DateTime(2014, 11, 30),
                    ClientName = "Siatex Ltd",
                    ClientCity = "Dhaka",
                    ProgrammingLanguages="C#",
                    Databases = "My SQL",
                    UsedTechnologies = ".Net framework, Winforms and WPF",
                    Type = "Desktop-based",
                    Description = @"Security-software that can restrict employees to do	unauthorized access of apps and websites, monitor employees’ activity and send screenshots to the server, remotely change the employees’ privileges. It also provides file sharing and chatting facility.",
                    MoreDescription = @"Features: The features are applicable for specific user or group of users.
o	Block Applications– Users can run only those apps that are assigned to him and all others apps are blocked. So they cannot waste their office time by playing games or watching movies.
o	Block websites– This feature helps you to block the specific websites that are used to passing time such as Facebook and twitter etc.
o	Prevent access to specific hard disk drive– Users can only access those disk drives that are assigned to him. If a user have only d: and f: drives then he can only access these drives.
o	Restrict from using USB drive/Pen drive/CD-DVD drive– USB drives are used to transfer files from one PC to another PC. Prevent using these drives; you can safe valuable data/files.
o	Automatically capture screenshots and send it to the server– this software capture screenshots of the specific apps at a specific interval and send it to the server. You can see these screenshots whenever you want.
o	File transferring/sharing– it is easy to transfer files using this software, you have to select a file. The file is automatically uploaded to the server and at the receiver’s PC it is automatically downloaded.
o	Chat– The users can send messages instantly. Supports private and public chat.
o	Protects from viruses– Since this software blocks all unnecessary apps including viruses, so you do not need an antivirus.
",
                },
                /* Todo: add the following in appropriate place!
                 * Maintaining a notable gitbub repository and nuget package called Serenity.Extra
https://github.com/dfaruque/Serenity.Extra
https://www.nuget.org/packages/Serenity.Extra

Beginning programming with VB6 at school life (since 2006).
Developed some applications with my own interest.
                 */
            };

            References = new List<ReferenceModel> {
                new ReferenceModel
                {
                    Name = "Firoz Ahmed",
                    Position = "Senior Software Engineer",
                    Organization = "TechnoVista Limited",
                    Contact = "+880 1723 427 588",
                    Email = "firoz7588@gmail.com"
                },
                new ReferenceModel
                {
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

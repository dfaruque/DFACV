using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    private static List<SkillGroup> GetSkills()
    {
        return new() {
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
                                Name = "Chart.js",
                                StartDate = new DateTime(2016, 1, 1),
                                Strength = SkillStrength.Intermediate
                            },
                            new() {
                                Name = "Babylon.js",
                                StartDate = new DateTime(2016, 1, 1),
                                Strength = SkillStrength.Intermediate
                            },
                            //new() {
                            //    Name = "Three.js",
                            //    StartDate = new DateTime(2016, 1, 1),
                            //    Strength = SkillStrength.Intermediate
                            //},
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
                IconClass = "mobile text-large",
                Items = new() {
                    new() {
                        Name = "Xamarin",
                        StartDate = new DateTime(2018, 1, 1),
                        Strength = SkillStrength.Intermediate
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
    }
}

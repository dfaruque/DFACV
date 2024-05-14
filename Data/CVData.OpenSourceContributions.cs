using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    private static List<ProjectModel> GetOpenSourceContributions()
    {
        return new() {
            new() {
                Title = "Serenity Platform",
                StartDate = new DateTime(2016, 1, 1),
                Description = "Serenity is an ASP.NET Core / TypeScript application platform " +
                "designed to simplify and shorten the development of data-centric business applications " +
                "with a service-based architecture. " +
                "It aims to make development easier while reducing maintenance costs by avoiding " +
                "boiler-plate code, reducing the time spent on repetitive tasks and applying best " +
                "software design practices.",
                ProjectSource= "https://github.com/serenity-is/Serenity",
                ProjectUrl = "https://serenity.is",
                Responsibilities = @"<ul>
    <li>Added support for the oracle database</li>
    <li>Enhanced code generation</li>
    <li>Added method overloads for Sql <code>Sum</code>, <code>Avg</code>, <code>Min</code>, <code>Max</code> etc. 
        which takes <code>IField</code> as parameter
    </li>
    <li>AutoParam consistent after cloning <code>SqlQuery</code></li>
    <li>Added <code>ForJson</code> SqlQuery method similar to <code>ForXml</code> method</li>
    <li>Handled tabs with empty captions in the generated form</li>
    <li>Added selectedItem getter in Select2Editor</li>
    <li>Tab title localization in forms</li>
    <li>Added Bengali localization</li>
    <li>Giving a hint to fix the ""Specified cast is not valid."" exception </li>
    <li>Some minor changes such as look and feel, small bug fixes</li>
</ul>",
            },
            new() {
                Title = "Fluent Migrator",
                StartDate = new DateTime(2016, 1, 1),
                Description = @"Fluent Migrator is a migration framework for .NET
                        Migrations are a structured way to alter your database schema and are an alternative
                        to creating lots of sql scripts that have to be run manually by every developer involved.
                        Migrations solve the problem of evolving a database schema for multiple databases
                        (for example, the developer's local database, the test database and the production database).
                        Database schema changes are described in classes written in C# that can be checked into
                        a version control system.",
                ProjectSource= "https://github.com/fluentmigrator/fluentmigrator",
                ProjectUrl = "https://fluentmigrator.github.io",
                Responsibilities = @"<ul>
    <li>Oracle 12C supports object name max length = 128</li>
</ul>",
            },
//            new() {
//                Title = "Open CV Playground",
//                StartDate = new DateTime(2020, 6, 1),
//                Description = @"A playground app for testing algorithms in OpenCV",
//                ProjectSource= "https://github.com/rexcardan/OpenCVPlaygound",
//                Responsibilities = @"<ul>
//    <li>Updated OpenCvSharp to 4.4.0</li>
//</ul>",
//            },
            new() {
                Title = "Serenity.Extra",
                StartDate = new DateTime(2017, 6, 1),
                Description = @"It has some extra features on top of the Serenity Platform,
                    such as audit logging, theming, reporting, grid data inline editing, and some usefull utilities.
                    <br />
                    <div><strong>NuGet: </strong><a class=""text-decoration-none"" href=""https://www.nuget.org/packages/Serenity.Extra"">https://www.nuget.org/packages/Serenity.Extra</a></div>
",
                ProjectSource= "https://github.com/dfaruque/Serenity.Extra",
                Responsibilities = @"<ul>
    <li>This repository and NuGet package are being maintained by me</li>
</ul>",
            }
        };
    }
}

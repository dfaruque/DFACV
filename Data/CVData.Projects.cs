using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFACV.Models;

namespace DFACV;

public partial class CVData
{
    private static List<ProjectModel> GetProjects()
    {
        return new() {
            new() {
                Title = "Integrated Centralized Billing System for Palli Bidyut Samities",
                Role = "Solution Architect & Development Lead",
                StartDate = new DateTime(2019, 3, 1),
                EndDate = null,
                ClientName = "Bangladesh Rural Electrification Board (BREB)",
                ClientCity = "Dhaka",
                ProgrammingLanguages="C#, TypeScript",
                Databases = "Oracle, Redis",
                UsedTechnologies = "ASP.NET Core MVC, Serenity.is, Dapper, SlikGrid, OpenCV, Chart.js",
                Type = "Web-based",
                Description = "A large-scale billing system. " +
                "Over 2000 employees from over 500 workspaces will be using the system daily from all over the country. " +
                "Over 30 million  electricity bills will be processed per month by this system. " +
                "Modules for this system are Electricity Meter Reading by Image Capturing, " +
                "New Connection Application, Consumer Management, Billing, Collection, and " +
                "Accounting management system.",
                Responsibilities = @"<ul>
    <li>Involved since the project initialization.</li>
    <li>Collecting requirements and visiting client premises in several locations.</li>
    <li>Involved in writing Software Requirement Specification (SRS).</li>
    <li>Designed databases and corresponding user interfaces.</li>
    <li>Write back-end and front-end validation and business logic.</li>
    <li>Architecting the solution using the Serenity platform.</li>
    <li>Write unit test cases for critical business rules.</li>
    <li>Performed research and development (R&D) for electricity meter readings by capturing meter images. 
        R&D task performed using python and Jupyter Notebook. 
        Later, it converted to java for integration with the android app.
    </li>
    <li>Implemented two-factor authentication.</li>
    <li>Implemented distributed caching using Redis.</li>
    <li>Deployed the system to the client's data center (about 20 servers) as a distributed system.</li>
    <li>Developed a server management tool to deploy the published application files to the servers using SSH and SCP.</li>
</ul>",

                Challenges = @"<ul>
    <li>Initially, the software was developed using the MS SQL server database. 
        But later, the client chooses to use the oracle database. So, a large-scale database migration task is performed. 
        Now the system is working fine with both databases.
    </li>
    <li>The software was developed using .NET Framework 4.x. But later, we migrated to .NET 6</li>
    <li>Since it is a financial system, network security is the priority. 
        So, different network zones (VPN, DMZ) are used for modules. 
        The data synchronization between zones was a challenge.
    </li>
    <li>Almost all banks in Bangladesh are connected to this system via VPN. 
        We have to support them in implementing our bill payment API
    </li>
    <li>There are legacy data with different shapes for each workspace. We have to migrate them into our system.</li>
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
                UsedTechnologies = "ASP.NET MVC, Serenity.is, Dapper, SlikGrid, Vue.js, WebGL, Babylon.js, Chart.js",
                Type = "Web-based",
                Description = "This is a complete sea-port automation system used at Mongla Port. " +
                "Modules for this system are Container Yard, Transit Shed, and Port Billing, etc. " +
                "Integration with ASYCUDA through IGM.",
                Challenges = @"<ul>
    <li>The port business is a new domain for us. We have to study a lot to understand the requirements.</li>
    <li>Visual representation of the port yard and locating the cargo inside the port was a challenge.</li>
    <li>The users did not have much IT knowledge to operate the system. So, implementation was another challenge.</li>
</ul>",
                Responsibilities = @"<ul>
    <li>Designed and develop the end-to-end solution to the requirements.</li>
    <li>Developed the visual representation of the port yard using the WebGL library (babylon.js).</li>
    <li>Integrated google maps to locate incoming and outgoing vessels.</li>
    <li>Import General Manifest (IGM) XML file importing facility.</li>
</ul>"
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
                UsedTechnologies = "ASP.NET MVC, Serenity.is, Vuejs, Chart.js",
                Type = "Web-based",
                Description = "Online licensing and approval system for any business entities of " +
                "Power/Gas/Petroleum Production, Transition, or Distribution Companies",
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
                "publish their data on aid activities through the International Aid Transparency Initiative (IATI). " +
                "This project's aim is to start using IATI data in Bangladesh's Aid Information Management System (AIMS) " +
                "and improve the quality of the data held in the AIMS and reduce the burden of data collection.",
                ProjectUrl = "http://aims.erd.gov.bd/IATIImportSite",
                ProjectSource = "https://github.com/BD-IATI/edi",
                ProjectDoc = "http://bd-iati.github.io/",
            },
            new() {
                Title = "Security (User Management) Module",
                Role = "Developer",
                StartDate = new DateTime(2016, 3, 1),
                EndDate = new DateTime(2016, 6, 30),
                ClientName = "LGED, BEPZA, SDF and many others",
                ClientCity = "Dhaka",
                ProgrammingLanguages="C#, TypeScript",
                Databases = "Cross Database (SQL Server/Oracle/MySQL etc.)",
                UsedTechnologies = "ASP.NET MVC, Serenity.is, Vuejs",
                Type = "Web-based",
                Description = "This is a cross-database, single-sign-on (SSO) user management module " +
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
                "and requisition system, item issue trend analysis; Real-time integration WIMS-LMS " +
                "(Loyalty Management System) a gift distribution system of Banglalink through WCF service",
            },
            new() {
                Title = "UniERP Business Solutions",
                Role = "Developer",
                StartDate = new DateTime(2014, 11, 1),
                EndDate = new DateTime(2015, 12, 31),
                ClientName = "Golden Life Insurance Ltd., Gentle Park | Bismillah Holdings Ltd.",
                ClientCity = "Dhaka, Bangladesh | National Capital District, Papua New Guinea",
                ProgrammingLanguages="C#, JavaScript",
                Databases = "SQL Server/Oracle",
                UsedTechnologies = "ASP.NET WebForms, Entity Framework, Crystal Reports",
                Type = "Web-based",
                Description = "A solution to all business needs including Finances, Human resources, Manufacturing, Supply chain and etc.",
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
                Description = "Security software that can restrict employees to do unauthorized " +
                "access of apps and websites, monitor employees’ activity and send screenshots to " +
                "the server, remotely change the employees’ privileges. It also provides file sharing " +
                "and chatting facility.",
                MoreDescription = @"<b>Features:</b> The features are applicable to a specific user or group of users.
<ul>
<li><b>Block Applications</b>– Users can run only those apps that are assigned to them and all others apps are blocked. So they cannot waste their office time by playing games or watching movies.</li>
<li><b>Block websites</b>– This feature helps you to block the specific websites that are used to pass time such as Facebook and Twitter etc.</li>
<li><b>Prevent access to specific hard disk drives</b>– Users can only access those disk drives that are assigned to them. If a user has only d: and f: drives then he can only access these drives.</li>
<li><b>Restrict from using USB drive/Pen drive/CD-DVD drive</b>– USB drives are used to transfer files from one PC to another PC. Prevent using these drives; you can save valuable data/files.</li>
<li><b>Automatically capture screenshots and send them to the server</b>– this software capture screenshots of the specific apps at a specific interval and send them to the server. You can see these screenshots whenever you want.</li>
<li><b>File transferring/sharing</b>– it is easy to transfer files using this software, you have to select a file. The file is automatically uploaded to the server and at the receiver’s PC, it is automatically downloaded.</li>
<li><b>Chatting</b>– The users can send messages instantly. Supports private and public chat.</li>
<li><b>Protects from viruses</b>– Since this software blocks all unnecessary apps including viruses, so you do not need an antivirus.</li>
</ul>",
            },
        };
    }
}

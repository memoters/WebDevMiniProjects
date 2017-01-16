using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioSite.Models
{
    public class PortfolioDbSeedData
    {
        private PortfolioDbContext _context;

        public PortfolioDbSeedData(PortfolioDbContext context)
        {
            _context = context;
        }

        public async Task GenerateSeedData()
        {
            if(_context.Projects.Count() == 0)
            { 

                List<ProjectDetails> projects = new List<ProjectDetails>()
                {
                    new ProjectDetails()
                    {
                        Name = "FieldMate R3.02",
                        Description = @"FieldMate Versatile Device Management Software is a PC based configuration tool that performs various tasks, 
                                        including initial setup, daily maintenance, troubleshooting, and configuration backup for device replacement.
                                        This project is a revision-up of the previous FieldMate version (R3.01) which focuses on Windows 10 support and 
                                        providing new competitive functions which aims to provide efficiency and improve the productivity of users.",
                        Image = "FM.jpg",
                        ProductLink = "www.yokogawa.com/solutions/products-platforms/industrial-networking/device-smart-communicators-2/mobile-field-device-management-fieldmate/"
                    },
                    new ProjectDetails()
                    {
                        Name = "ROTAMASS TI DTM Advanced Functions",
                        Description = @"Rotamass is a Yokogawa Coriolis flow meter device. 
                                        The development focus of this project are the advanced functions of the DTM (Device Type Manager) of this device 
                                        such as concentration calculation and report, tube integrity health check, event management.",
                        Image = "FM.jpg",
                        ProductLink = "web-material3.yokogawa.com/Bulletin_01U10A01-01EN_-R__RotaMASS_TI_Overview_Brochure.pdf"
                    },
                     new ProjectDetails()
                    {
                        Name = "PRM R3.20 DTMWorks support",
                        Description = @"DTMWorks is a frame application mainly used for field device calibration and device parameter display. 
                                        This tool conforms to FDT (Field Device Tool) 2.0 specifications.
                                        For this project, the previous C++ based DTMWorks version was replaced by the new C# WPF/WCF based version of DTMWorks.",
                        Image = "DTMWorks.jpg",
                        ProductLink = "www.yokogawa.com/au/technical-library/resources/media-publications/yokogawa-fieldmate-and-device-dtm-compliance-with-fdt2/"
                    },
                    new ProjectDetails()
                    {
                        Name = "PRM R3.12 Status Configuration Tool",
                        Description = @"This application is used for configuring device status information based on NE 107 standards. 
                                        Device status sent by device can be modified using this tool and final result will be seen in the Asset Management Software (PRM)",
                        Image = "PRM.jpg",
                    },
                    new ProjectDetails()
                    {
                        Name = "PRM R3.11 PROFIBUS Communication DTM",
                        Description = @"This release of the PRM (Plant Resource Management) software includes support for the new PROFIBUS IOM (Input/Output Module). 
                                        A Communication DTM (Device Type Manager) is needed to be developed to support this new IOM.",
                        Image = "DTMWorks.jpg",
                    },
                    new ProjectDetails()
                    {
                        Name = "CENTUM VP Graphic Builder Maintenance",
                        Description = @"CENTUM VP is a DCS software which monitors and manages plant devices. 
                                        For this project, maintenance support for the graphic builder subsystem is performed. ",
                        Image = "DTMWorks.jpg",
                        ProductLink = "www.yokogawa.com/au/solutions/products-platforms/control-system/distributed-control-systems-dcs/centum-vp-new/"
                    },
                };

                /*
                List<ProjectDetails> projects = new List<ProjectDetails>()
                {
                    new ProjectDetails()
                    {
                        Name = "FieldMate R3.02",
                        Description = @"FieldMate Versatile Device Management Software is a PC based configuration tool that performs various tasks, 
                                        including initial setup, daily maintenance, troubleshooting, and configuration backup for device replacement.
                                        This project is a revision-up of the previous FieldMate version (R3.01) which focuses on Windows 10 support and 
                                        providing new competitive functions which aims to provide efficiency and improve the productivity of users.",
                        Image = "~/images/FM.jpg",
                        ProductLink = "www.yokogawa.com/solutions/products-platforms/industrial-networking/device-smart-communicators-2/mobile-field-device-management-fieldmate/"
                    },
                    new ProjectDetails()
                    {
                        Name = "ROTAMASS TI DTM Advanced Functions",
                        Description = @"Rotamass is a Yokogawa Coriolis flow meter device. 
                                        The development focus of this project are the advanced functions of the DTM (Device Type Manager) of this device 
                                        such as concentration calculation and report, tube integrity health check, event management.",
                        Image = "wwwroot/images/FM.jpg",
                        ProductLink = "https://web-material3.yokogawa.com/Bulletin_01U10A01-01EN_-R__RotaMASS_TI_Overview_Brochure.pdf"
                    },
                     new ProjectDetails()
                    {
                        Name = "PRM R3.20 DTMWorks support",
                        Description = @"DTMWorks is a frame application mainly used for field device calibration and device parameter display. 
                                        This tool conforms to FDT (Field Device Tool) 2.0 specifications.
                                        For this project, the previous C++ based DTMWorks version was replaced by the new C# WPF/WCF based version of DTMWorks.",
                        Image = "~/images/DTMWorks.jpg",
                        ProductLink = "http://www.yokogawa.com/au/technical-library/resources/media-publications/yokogawa-fieldmate-and-device-dtm-compliance-with-fdt2/"
                    },
                    new ProjectDetails()
                    {
                        Name = "PRM R3.12 Status Configuration Tool",
                        Description = @"This application is used for configuring device status information based on NE 107 standards. 
                                        Device status sent by device can be modified using this tool and final result will be seen in the Asset Management Software (PRM)",
                        Image = "~/images/PRM.jpg",
                    },
                    new ProjectDetails()
                    {
                        Name = "PRM R3.11 PROFIBUS Communication DTM",
                        Description = @"This release of the PRM (Plant Resource Management) software includes support for the new PROFIBUS IOM (Input/Output Module). 
                                        A Communication DTM (Device Type Manager) is needed to be developed to support this new IOM.",
                        Image = "~/images/DTMWorks.jpg",
                    },
                    new ProjectDetails()
                    {
                        Name = "CENTUM VP Graphic Builder Maintenance",
                        Description = @"CENTUM VP is a DCS software which monitors and manages plant devices. 
                                        For this project, maintenance support for the graphic builder subsystem is performed. ",
                        Image = "~/images/DTMWorks.jpg",
                        ProductLink = "http://www.yokogawa.com/au/solutions/products-platforms/control-system/distributed-control-systems-dcs/centum-vp-new/"
                    },
                };
                */

                foreach (var project in projects)
                    _context.Projects.Add(project);


                await _context.SaveChangesAsync();
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Energy_Insights.Models;

namespace Energy_Insights.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            // Sample data for team members
            var teamMembers = new List<AboutUsModel>
            {
                new AboutUsModel
                {
                    Name = "Nidhi Falak",
                    ImageUrl = "img/Nidhi.jpg",
                    GitHubUrl = "https://github.com/nfalak-9",
                    Description = "With 2+ years in software development for banking and finance, I use Python, MySQL, PL/SQL, Tableau, and PowerBI. Pursuing a Master's in Business Analytics & Information Systems. Contributed to the About Us page and data model in the project."
                },
                
                new AboutUsModel
                {
                    Name = "Janhavi Kharmale",
                    ImageUrl = "img/janhavi.jpg",
                    GitHubUrl = "https://github.com/JanhaviKharm",
                    Description = "Proactive professional with a Master's in Business Analytics & Information Systems from the University of South Florida. Passionate about using data for strategic decision-making. Contributed to the homepage and styling of the project."
                },
                new AboutUsModel
                {
                    Name = "Amisha Bhagat",
                    ImageUrl = "img/self/amisha.jpeg",
                    GitHubUrl = "https://github.com/amishabt",
                    Description = "With 8+ years in IT, I focus on Java, Spring, Hibernate, and Oracle in Insurance and Banking. Experienced in Agile, I excel in project delivery and mentorship. Holding a Master's in Business Analytics from the University of South Florida, I contribute to innovative solutions. My contributions to the project include the Total Energy Production page and graphs."
                },
                new AboutUsModel
                {
                    Name = "Venkata Dharma Teja Konakanchi",
                    ImageUrl = "img/Dharma.jpg",
                    GitHubUrl = "https://github.com/Dharma2808",
                    Description = "With 2+ years in Data Engineering at Larsen and Toubro Infotech, I'm pursuing a Master's in Business Analytics & Information Systems. Passionate about using data for insights and strategic decisions. Contributed to the Renewable and Non-Renewable Energy pages in the project."
                }
            };
            ViewBag.LogoPath = "~/img/logo.png";
            return View("AboutUs",teamMembers);
        }
    }
}

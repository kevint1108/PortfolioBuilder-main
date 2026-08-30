using Microsoft.AspNetCore.Mvc;
using PortfolioBuilder.Models;
public class ProjectController : Controller
{
    public IActionResult Detail(int id)
    {
        var projects = new List<Project>
        {
            new Project { Id = 1, Title = "Quick Kids Quiz", Description = ".NET MAUI", ImageName = "MainMenu.jpg, About.jpg, questions.jpg, Correct.jpg, Incorrect.jpg, Result.jpg" },
            new Project { Id = 2, Title = "App ToDo", Description = "React", ImageName = "todoapp.png"},
            new Project { Id = 3, Title = "Icecream Shopping Cart", Description = "HTML/CSS and JS", ImageName = "Icecream shopping cart project.png, Icecream topping.png "},
            new Project { Id = 4, Title = "Trivia Game", Description = "Flutter", ImageName = "Question(trivia).jpg, Correct answer(trivia).jpg, incorrect answer(trivia).jpg, Result(Trivia).jpg" },
            new Project { Id = 5, Title = "Flutter Dice Project App", Description = "Flutter", ImageName = "D20App.jpg,DiceAppD6.jpg"},
            new Project { Id = 6, Title = "12H Food Delivery", Description = "MERN React + Node.js + MongoDB + Stripe + Cloudinary + Vercel + Javascript.js + HTML/CSS", ImageName = "Frontend of 12H.png, Favorite dished.png, mobile app icon 12h.png, search button in 12h.png, search result in 12h.png, In cart 12h.png, Delivery Information and Cart total in 12h.png, Stripe payment in 12h.png, My orders in 12h.png, In cart 12h.png, List Order in 12h.png, Orders in 12h.png" }
        };
        var project = projects.FirstOrDefault(p => p.Id == id);
        if (project == null)
        {
            return NotFound();
        }

        return View(project);
    }

    private Portfolio GetPortfolio()
    {
        return new Portfolio
        {
            FullName = "Binh Tang",
            Bio = "Software Application Developer",
            Avatar = "/images/me.jpg",
            Skills = new List<Skill>
            {
                new Skill { Name = "C#" },
                new Skill { Name = ".Net MAUI" },
                new Skill { Name = "SQL" },
                new Skill { Name = "Javascript" },
            },
            Projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "Quick Kids Quiz",
                    Description = ".Net MAUI and C#",
                    ImageName = "MainMenu.jpg, About.jpg, questions.jpg, Correct.jpg, Incorrect.jpg, Result.jpg"
                },
                new Project { Id = 2, Title = "App ToDo", Description = "React", ImageName = "todoapp.png"},
                new Project { Id = 3, Title = "Icecream Shopping Cart", Description = "HTML/CSS and Javascript" },
                new Project { Id = 4, Title = "Trivia Game", Description = "Flutter" },
                new Project { Id = 5, Title = "Flutter Dice Project App", Description = "Flutter" },
                new Project { Id = 6, Title = "12H Food Delivery", Description = "MERN React + Node.js + MongoDB + Stripe + Cloudinary + Vercel + Javascript.js + HTML/CSS" }
            }
        };
    }
}

using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }



    List<Slider> _sliders = new List<Slider>
    {
        new Slider{Id=1,Title="Title-1",Subtitle="Subtitle-1",Description="Gullerden qalmadi",Image="1-2-524x617.png",Order=1,IsDeleted=false},
        new Slider{Id=2,Title="Title-2",Subtitle="Subtitle-2",Description="Mohtesem endirimler",Image="1-2-524x617.png",Order=2,IsDeleted=false},
        new Slider{Id=3,Title="Title-3",Subtitle="Subtitle-3",Description="Korogluya manatdan",Image="images.jfif",Order=3,IsDeleted=false},
    };

    public IActionResult Index()
    {
        HomeVM homeVM = new()
        {
            Sliders = _sliders
            .OrderBy(s=>s.Order)
            .Take(2)
            .Where(s=>!s.IsDeleted==false)
            .ToList()
        };


        return View(homeVM);
    }
}

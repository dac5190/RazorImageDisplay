using Microsoft.AspNetCore.Mvc;
using RazorImageDisplay.Data;
using RazorImageDisplay.Models;
using System.Diagnostics;

namespace RazorImageDisplay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SlideShowsFromCS slideShowsFromCS = new SlideShowsFromCS();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ImageCountDisplay()
        {
            SlideShowModel slideShowModel = new SlideShowModel()
            {
                slideShowImages = slideShowsFromCS.GetFullExampleImages()
            };

            return View(slideShowModel);
        }

        public IActionResult ImageCountDisplayTwoColumn()
        {
            SlideShowModel slideShowModel = new SlideShowModel()
            {
                slideShowImages = slideShowsFromCS.GetFullExampleImages(),
                twoColumn = true
            };

            return View(slideShowModel);
        }

        public IActionResult MultipleSlideShows()
        {
            PortfolioModel model = slideShowsFromCS.GetPortfolioModel();
            return View(model);
        }
        public IActionResult MultipleSlideShowsTwoColumn()
        {
            PortfolioModel model = slideShowsFromCS.GetPortfolioModel();

            if (model.ExampleOneCarousel != null && model.ExampleTwoCarousel != null &&
                model.ExampleThreeCarousel != null && model.ExampleFourCarousel != null)
            {
                model.ExampleOneCarousel.twoColumn = true;
                model.ExampleTwoCarousel.twoColumn = true;
                model.ExampleThreeCarousel.twoColumn = true;
                model.ExampleFourCarousel.twoColumn = true;
            }

            return View(model);
        }

        public IActionResult SimpleSlideShow()
        {
            return View();
        }

        public IActionResult SimpleSlideShowTwoColumn()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

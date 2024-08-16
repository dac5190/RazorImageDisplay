using RazorImageDisplay.Models;

namespace RazorImageDisplay.Data
{
    public class SlideShowsFromCS
    {
        private string thumbBeginingUrl = "/img/thumbs/";
        private string urlBeginingUrl = "/img/";

        public List<SlideShowImage> GetFullExampleImages()
        {
            List<SlideShowImage> images = new List<SlideShowImage>() {
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "atlantic_city_always_keeping_us_guessing.jpg",
                    ThumbUrl = thumbBeginingUrl + "atlantic_city_always_keeping_us_guessing.jpg"
                },
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "atlantic_city_always_keeping_us_guessing_1.jpg",
                    ThumbUrl = thumbBeginingUrl + "atlantic_city_always_keeping_us_guessing_1.jpg"
                },
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "a_lot_safer_solar_setup.jpg",
                    ThumbUrl = thumbBeginingUrl + "a_lot_safer_solar_setup.jpg"
                },
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "baltimore_at_night.jpg",
                    ThumbUrl = thumbBeginingUrl + "baltimore_at_night.jpg"
                },
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "comptia_last_profile_pic.jpg",
                    ThumbUrl = thumbBeginingUrl + "comptia_last_profile_pic.jpg"
                },
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "enjoyment_of_studying_comptia_cysa.jpg",
                    ThumbUrl = thumbBeginingUrl + "enjoyment_of_studying_comptia_cysa.jpg"
                },
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "random_ikea_section_under_construction.jpg",
                    ThumbUrl = thumbBeginingUrl + "random_ikea_section_under_construction.jpg"
                },
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "random_lenny.jpg",
                    ThumbUrl = thumbBeginingUrl  + "random_lenny.jpg"
                },
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "sure_this_is_safe.jpg",
                    ThumbUrl = thumbBeginingUrl + "sure_this_is_safe.jpg"
                },
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "vice_city_shirt_apparently_this_is_what_i_do_to_destress.jpg",
                    ThumbUrl = thumbBeginingUrl + "vice_city_shirt_apparently_this_is_what_i_do_to_destress.jpg"
                },
                new SlideShowImage()
                {
                    Url = urlBeginingUrl + "yep_totally_safe.jpg",
                    ThumbUrl = thumbBeginingUrl + "yep_totally_safe.jpg"
                }
            };

            return images;
        }

        public List<SlideShowImage> GetRandomSortImages()
        {
            Random random = new Random();
            return GetFullExampleImages().OrderBy(item => random.Next()).ToList();
        }

        public PortfolioModel GetPortfolioModel()
        {
            PortfolioModel portfolioModel = new PortfolioModel()
            {
                ExampleOneCarousel = new SlideShowModel()
                {
                    Id = "ExampleOneCarousel",
                    slideShowImages = GetRandomSortImages()
                },
                ExampleTwoCarousel = new SlideShowModel()
                {
                    Id = "ExampleTwoCarousel",
                    slideShowImages = GetRandomSortImages()
                },
                ExampleThreeCarousel = new SlideShowModel()
                {
                    Id = "ExampleThreeCarousel",
                    slideShowImages = GetRandomSortImages()
                },
                ExampleFourCarousel = new SlideShowModel()
                {
                    Id = "ExampleFourCarousel",
                    slideShowImages = GetRandomSortImages()
                }
            };

            return portfolioModel;
            
        }
    }
}

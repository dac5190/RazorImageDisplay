namespace RazorImageDisplay.Models
{
    public class SlideShowModel
    {
        public List<SlideShowImage>? slideShowImages { get; set; }
        public bool twoColumn { get; set; } = false;

        public string Id { get; set; } = "slideshow";
    }
}

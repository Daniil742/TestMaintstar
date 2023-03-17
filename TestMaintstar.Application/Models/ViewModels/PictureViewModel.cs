using Microsoft.AspNetCore.Http;

namespace TestMaintstar.Application.Models.ViewModels
{
    public class PictureViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public DateTime PublicationDate { get; set; }

        public IFormFile? Image { get; set; }
    }
}

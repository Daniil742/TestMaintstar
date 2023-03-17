using System.ComponentModel.DataAnnotations;

namespace TestMaintstar.Application.Models.Entities
{
    public class Picture
    {
        public int Id { get; set; }

        [Display(Name = "Title")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }

        public byte[]? Image { get; set; }
    }
}

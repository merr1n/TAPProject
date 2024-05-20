using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dto
{
    public class EventDto
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        [Required(ErrorMessage = "OrganizerId is required")]
        public Guid OrganizerId {  get; set; }
        [Required(ErrorMessage = "TypeId is required")]
        public int TypeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}

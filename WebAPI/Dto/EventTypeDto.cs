using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dto
{
    public class EventTypeDto
    {
        [Required(ErrorMessage = "Type is required")]
        public string Type {  get; set; }
    }
}

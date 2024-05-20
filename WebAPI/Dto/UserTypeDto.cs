using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dto
{
    public class UserTypeDto
    {
        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }
    }
}

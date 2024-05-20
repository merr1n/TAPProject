using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dto
{
    public class TicketDto
    {
        [Required(ErrorMessage = "EventId is required")]
        public Guid EventId { get; set; }
        [Required(ErrorMessage = "UserId is required")]
        public Guid UserId { get; set; }
    }
}

using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly IRepository<Ticket> _ticketsRepository;

        public TicketController(IRepository<Ticket> ticketsRepository)
        {
            _ticketsRepository = ticketsRepository;
        }

        [HttpGet("get")]
        public IEnumerable<Ticket> Get()
        {
            return _ticketsRepository.GetAll();
        }

        [HttpPost("add")]
        public ObjectResult Add(TicketDto ticketDto)
        {
            _ticketsRepository.Add(new Ticket(ticketDto.UserId, ticketDto.EventId));
            _ticketsRepository.SaveChanges();
            return Ok(ticketDto);
        }

        [HttpDelete("delete")]
        public ObjectResult Delete(int ticketId)
        {
            var ticketFromDb = _ticketsRepository.Find(t => t.Id == ticketId).FirstOrDefault();
            if (ticketFromDb != null)
            {
                _ticketsRepository.Remove(ticketFromDb);
                _ticketsRepository.SaveChanges();
                return Ok("Ticket successfully deleted.");
            }
            else
                return NotFound("Ticket doesn't exist.");
        }
    }
}

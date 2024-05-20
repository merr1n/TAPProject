using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IRepository<Event> _eventsRepository;

        public EventController(IRepository<Event> eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }

        [HttpGet("get")]
        public Task<IEnumerable<Event>> Get()
        {
            return _eventsRepository.GetAll(["Type", "Organizer","Organizer.Type"]);
        }

        [HttpPost("add")]
        public ObjectResult Add(EventDto eventDto)
        {
            _eventsRepository.Add(new Event(eventDto.Title, eventDto.Location, eventDto.OrganizerId, eventDto.Date, eventDto.Description, eventDto.TypeId, eventDto.Price, eventDto.Status));
            _eventsRepository.SaveChanges();
            return Ok(eventDto);
        }

        [HttpPost("update")]
        public ObjectResult Update(EventDto eventDto, Guid eventId)
        {
            var eventFromDb = _eventsRepository.Find(e => e.Id == eventId).FirstOrDefault();
            if (eventFromDb == null)
            {
                return NotFound("Event doesn't exist.");
            }
            eventFromDb.Title = eventDto.Title;
            eventFromDb.Location = eventDto.Location;
            eventFromDb.Date=eventDto.Date;
            eventFromDb.Description = eventDto.Description;
            eventFromDb.TypeId = eventDto.TypeId;
            eventFromDb.Price = eventDto.Price;
            eventFromDb.Status = eventDto.Status;
            _eventsRepository.Update(eventFromDb);
            _eventsRepository.SaveChanges();
            return Ok(eventFromDb);
        }

        [HttpDelete("delete")]
        public ObjectResult Delete(Guid eventId)
        {
            var eventFromDb = _eventsRepository.Find(e => e.Id == eventId).FirstOrDefault();
            if (eventFromDb != null)
            {
                _eventsRepository.Remove(eventFromDb);
                _eventsRepository.SaveChanges();
                return Ok("Event successfully deleted.");
            }
            else
                return NotFound("Event doesn't exist.");
        }
    }
}

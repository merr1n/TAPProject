using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventTypeController : ControllerBase
    {
        private readonly IRepository<EventType> _eventTypeRepository;

        public EventTypeController(IRepository<EventType> eventTypeRepository)
        {
            _eventTypeRepository = eventTypeRepository;
        }

        [HttpGet("get")]
        public IEnumerable<EventType> Get()
        {
            return _eventTypeRepository.GetAll();
        }

        [HttpPost("add")]
        public ObjectResult Add(EventTypeDto eventTypeDto)
        {
            _eventTypeRepository.Add(new EventType(eventTypeDto.Type));
            _eventTypeRepository.SaveChanges();
            return Ok(eventTypeDto);
        }

        [HttpPost("update")]
        public ObjectResult Update(EventTypeDto eventTypeDto, int eventTypeId)
        {
            var eventTypeFromDb = _eventTypeRepository.Find(e => e.Id == eventTypeId).FirstOrDefault();
            if (eventTypeFromDb == null)
            {
                return NotFound("Event type doesn't exist.");
            }
            eventTypeFromDb.Type = eventTypeDto.Type;
            _eventTypeRepository.Update(eventTypeFromDb);
            _eventTypeRepository.SaveChanges();
            return Ok(eventTypeFromDb);
        }

        [HttpDelete("delete")]
        public ObjectResult Delete(int eventTypeId)
        {
            var eventTypeFromDb = _eventTypeRepository.Find(e => e.Id == eventTypeId).FirstOrDefault();
            if (eventTypeFromDb != null)
            {
                _eventTypeRepository.Remove(eventTypeFromDb);
                _eventTypeRepository.SaveChanges();
                return Ok("Event type successfully deleted.");
            }
            else
                return NotFound("Event type doesn't exist.");
        }
    }
}

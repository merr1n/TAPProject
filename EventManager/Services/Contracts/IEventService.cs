using EventManager.Models;

namespace EventManager.Services.Contracts
{
    public interface IEventService
    {
        Task<IEnumerable<EventDto>> GetAll();
    }
}

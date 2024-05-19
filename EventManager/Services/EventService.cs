using EventManager.Models;
using EventManager.Services.Contracts;
using System.Net.Http.Json;

namespace EventManager.Services
{
    public class EventService : IEventService
    {
        private readonly HttpClient _httpClient;
        public EventService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<EventDto>> GetAll()
        {
            try
            {
                var events = await this._httpClient.GetFromJsonAsync<IEnumerable<EventDto>>("api/Event");
                return events;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

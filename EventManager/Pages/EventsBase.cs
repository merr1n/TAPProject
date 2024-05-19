using Microsoft.AspNetCore.Components;
using EventManager.Services.Contracts;
using EventManager.Models;

namespace EventManager.Pages
{
    public class EventsBase : ComponentBase
    {
        [Inject]
        public IEventService EventService { get; set; }

        public IEnumerable<EventDto> Events { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Events = await EventService.GetAll();
        }
    }
}

using HallManagment.Entities;

namespace HallManagment.Services
{
    public class EventServes
    {
        private List<Event> Events=new List<Event>();

        public List<Event> GetEvents()
        {
            return Events;
        }

        public Event? GetEventById(int id)
        {
            return Events.Find(e => e.Id == id);
        }
        public void DeleteEvent(int id)
        {
            int index = Events.FindIndex(e => e.Id == id);
            if (index != -1)
                Events.RemoveAt(index);
        }

        public void AddEvent(Event e)
        {
            Events.Add(e);
        }

        public void UpdateEvent(int id, Event e)
        {
            int index = Events.FindIndex(e => e.Id == id);
            if (index != -1)
                Events[index] = e;
        }

        public List<Event> GetOpenEvents()
        {
            return Events.Where(e => e.Closed == false).ToList();
        }

        public List<Event> GetEventByDate(DateOnly date)
        {
            return Events.Where(e => e.Date == date).ToList();
        }
    }
}

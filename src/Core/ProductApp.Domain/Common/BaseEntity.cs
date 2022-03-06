using ProductApp.Domain.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        private ICollection<IEvent> events { get; }
        public ICollection<IEvent> Events => events;

        public void AddEvent(IEvent @event)
        {
            events.Add(@event);
        }
        public ICollection<IEvent> GetEvents()
        {
            return events;
        }
        public void RemoveEvent(IEvent @event)
        {
            events.Remove(@event);
        }
    }
}

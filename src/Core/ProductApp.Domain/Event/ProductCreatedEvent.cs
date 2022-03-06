using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Domain.Event
{
    public class ProductCreatedEvent:INotification,IEvent
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
    }
}

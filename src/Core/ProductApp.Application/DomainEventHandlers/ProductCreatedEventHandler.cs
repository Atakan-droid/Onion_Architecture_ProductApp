using MediatR;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApp.Application.DomainEventHandlers
{
    public class ProductCreatedEventHandler : INotificationHandler<ProductCreatedEvent>, IEvent
    {
        private readonly IProductRepository productRepository;

        public ProductCreatedEventHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Task Handle(ProductCreatedEvent notification, CancellationToken cancellationToken)
        {
            var productNameExist = productRepository.GetByIdAsync(notification.Id);
            if (productNameExist.Result != null)
            {
                return Task.FromResult(1);
            }
            else

                return Task.CompletedTask;//with exception
            }
        }
    }
}

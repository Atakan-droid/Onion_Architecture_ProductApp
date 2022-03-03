using AutoMapper;
using MediatR;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Commands.CreateProduct
{
    public class CreateProductQuery:IRequest<ServiceResponse<Guid>>
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }


        public class CreateProductCommandHandler : IRequestHandler<CreateProductQuery, ServiceResponse<Guid>>
        {
            private readonly IProductRepository productRepository;
            private readonly IMapper mapper;

            public CreateProductCommandHandler(IProductRepository productRepository,IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }
            public async Task<ServiceResponse<Guid>> Handle(CreateProductQuery request, CancellationToken cancellationToken)
            {
                var product = mapper.Map<Product>(request);
                await productRepository.CreateAsync(product);

                return new ServiceResponse<Guid>(product.Id);
            }
        }
    }
}

using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery:IRequest<ServiceResponse<ProductViewDto>>
    {
        public Guid Id { get; set; }

        public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<ProductViewDto>>
        {
            private readonly IProductRepository productRepo;
            private readonly IMapper mapper;

            public GetProductByIdHandler(IProductRepository productRepo,IMapper mapper)
            {
                this.productRepo = productRepo;
                this.mapper = mapper;
            }
            public async Task<ServiceResponse<ProductViewDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            {
                var product = await productRepo.GetByIdAsync(request.Id);
                var viewDto = mapper.Map<ProductViewDto>(product);
                return new ServiceResponse<ProductViewDto>(viewDto);
            }
        }
    }
}

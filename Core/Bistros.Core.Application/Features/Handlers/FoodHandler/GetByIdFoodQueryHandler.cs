using AutoMapper;
using Bistros.Core.Application.Dtos.Food;
using Bistros.Core.Application.Features.Queries.FoodQuery;
using Bistros.Core.Application.Interfaces;
using Bistros.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Features.Handlers.FoodHandler
{
    public class GetByIdFoodQueryHandler : IRequestHandler<GetByIdFoodQuery, ResultFoodDto>
    {
        private readonly IRepository<Food> _repository;
        private readonly IMapper _mapper;

        public GetByIdFoodQueryHandler(IRepository<Food> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultFoodDto> Handle(GetByIdFoodQuery request, CancellationToken cancellationToken)
        {
            var food = await _repository.GetByIdAsync(request.Id);

            if (food == null)
                throw new Exception();

            return _mapper.Map<ResultFoodDto>(food);
        }
    }
}

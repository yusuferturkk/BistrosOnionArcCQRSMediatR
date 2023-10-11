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
    public class GetAllFoodQueryHandler : IRequestHandler<GetAllFoodQuery, List<ResultFoodDto>>
    {
        private readonly IRepository<Food> _repository;
        private readonly IMapper _mapper;

        public GetAllFoodQueryHandler(IRepository<Food> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultFoodDto>> Handle(GetAllFoodQuery request, CancellationToken cancellationToken)
        {
            var foods = _repository.GetAllIncluding(food => food.Category);
            return _mapper.Map<List<ResultFoodDto>>(foods);
        }
    }
}

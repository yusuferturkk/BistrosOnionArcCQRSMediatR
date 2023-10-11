using AutoMapper;
using Bistros.Core.Application.Dtos.Food;
using Bistros.Core.Application.Features.Commands.FoodCommand;
using Bistros.Core.Application.Interfaces;
using Bistros.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Features.Handlers.FoodHandler
{
    public class CreateFoodCommandHandler : IRequestHandler<CreateFoodCommand, CreateFoodDto>
    {
        private readonly IRepository<Food> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateFoodCommandHandler(IRepository<Food> repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateFoodDto> Handle(CreateFoodCommand request, CancellationToken cancellationToken)
        {
            var newFood = new Food { Name = request.Name };

            await _repository.CreateAsync(newFood);
            await _unitOfWork.CommitAsync();

            return _mapper.Map<CreateFoodDto>(newFood);
        }
    }
}

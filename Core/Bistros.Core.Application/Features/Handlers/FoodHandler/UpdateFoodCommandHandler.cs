using AutoMapper;
using Bistros.Core.Application.Dtos.Food;
using Bistros.Core.Application.Features.Commands.FoodCommand;
using Bistros.Core.Application.Interfaces;
using Bistros.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Features.Handlers.CategoryHandler
{
    public class UpdateFoodCommandHandler : IRequestHandler<UpdateFoodCommand, UpdateFoodDto>
    {
        private readonly IRepository<Food> _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateFoodCommandHandler(IRepository<Food> repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<UpdateFoodDto> Handle(UpdateFoodCommand request, CancellationToken cancellationToken)
        {
            var updatedFood = new Food { Name = request.Name };

            _repository.Update(updatedFood);
            _unitOfWork.Commit();

            return _mapper.Map<UpdateFoodDto>(updatedFood);
        }
    }
}

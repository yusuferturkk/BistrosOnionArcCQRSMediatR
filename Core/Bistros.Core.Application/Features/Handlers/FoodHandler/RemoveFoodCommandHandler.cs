using Bistros.Core.Application.Features.Commands.FoodCommand;
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
    public class RemoveFoodCommandHandler : IRequestHandler<RemoveFoodCommand>
    {
        private readonly IRepository<Food> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveFoodCommandHandler(IRepository<Food> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveFoodCommand request, CancellationToken cancellationToken)
        {
            var deletedFood = await _repository.GetByIdAsync(request.Id);

            if (deletedFood == null) { return; }
            else
            {
                _repository.Remove(deletedFood);
                _unitOfWork.Commit();
            }
        }
    }
}

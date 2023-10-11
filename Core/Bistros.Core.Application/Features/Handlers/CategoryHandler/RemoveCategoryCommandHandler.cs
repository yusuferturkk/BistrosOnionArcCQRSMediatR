using Bistros.Core.Application.Features.Commands.CategoryCommand;
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
    public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand>
    {
        private readonly IRepository<Category> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveCategoryCommandHandler(IRepository<Category> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            var deletedCategory = await _repository.GetByIdAsync(request.Id);

            if (deletedCategory == null) { return; }
            else
            {
                _repository.Remove(deletedCategory);
                _unitOfWork.Commit();
            }
        }
    }
}

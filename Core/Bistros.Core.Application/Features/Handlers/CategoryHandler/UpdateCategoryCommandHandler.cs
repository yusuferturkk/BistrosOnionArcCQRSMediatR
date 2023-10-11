using AutoMapper;
using Bistros.Core.Application.Dtos.Category;
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
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, UpdateCategoryDto>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCategoryCommandHandler(IRepository<Category> repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<UpdateCategoryDto> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var updatedCategory = new Category { Name = request.Name };

            _repository.Update(updatedCategory);
            _unitOfWork.Commit();

            return _mapper.Map<UpdateCategoryDto>(updatedCategory);
        }
    }
}

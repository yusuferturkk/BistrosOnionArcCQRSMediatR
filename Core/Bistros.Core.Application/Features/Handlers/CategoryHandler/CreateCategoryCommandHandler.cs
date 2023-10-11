using AutoMapper;
using Bistros.Core.Application.Dtos.Category;
using Bistros.Core.Application.Features.Commands.CategoryCommand;
using Bistros.Core.Application.Interfaces;
using Bistros.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Features.Handlers.CategoryHandler
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryDto>
    {
        private readonly IRepository<Category> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(IRepository<Category> repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateCategoryDto> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var newCategory = new Category { Name = request.Name };

            await _repository.CreateAsync(newCategory);
            await _unitOfWork.CommitAsync();

            return _mapper.Map<CreateCategoryDto>(newCategory);
        }
    }
}

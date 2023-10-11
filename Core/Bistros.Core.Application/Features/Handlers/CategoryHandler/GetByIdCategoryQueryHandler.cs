using AutoMapper;
using Bistros.Core.Application.Dtos.Category;
using Bistros.Core.Application.Features.Queries.CategoryQuery;
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
    public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQuery, ResultCategoryDto>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetByIdCategoryQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultCategoryDto> Handle(GetByIdCategoryQuery request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIdAsync(request.Id);

            if (category == null)
                throw new Exception();

            return _mapper.Map<ResultCategoryDto>(category);
        }
    }
}

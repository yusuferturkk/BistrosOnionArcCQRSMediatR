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
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, List<ResultCategoryDto>>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetAllCategoryQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultCategoryDto>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = _repository.GetAllIncluding(category => category.Foods);
            return _mapper.Map<List<ResultCategoryDto>>(categories);
        }
    }
}

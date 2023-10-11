using Bistros.Core.Application.Dtos.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Features.Queries.CategoryQuery
{
    public class GetAllCategoryQuery : IRequest<List<ResultCategoryDto>>
    {
    }
}

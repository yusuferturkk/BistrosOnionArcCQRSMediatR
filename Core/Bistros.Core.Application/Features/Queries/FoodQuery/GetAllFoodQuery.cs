using Bistros.Core.Application.Dtos.Food;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Features.Queries.FoodQuery
{
    public class GetAllFoodQuery : IRequest<List<ResultFoodDto>>
    {
    }
}

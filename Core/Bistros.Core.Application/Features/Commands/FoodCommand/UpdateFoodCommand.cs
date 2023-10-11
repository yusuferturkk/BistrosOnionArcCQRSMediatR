using Bistros.Core.Application.Dtos.Food;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Features.Commands.FoodCommand
{
    public class UpdateFoodCommand : IRequest<UpdateFoodDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

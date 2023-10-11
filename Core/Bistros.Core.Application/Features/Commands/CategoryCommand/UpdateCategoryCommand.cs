using Bistros.Core.Application.Dtos.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Features.Commands.CategoryCommand
{
    public class UpdateCategoryCommand : IRequest<UpdateCategoryDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

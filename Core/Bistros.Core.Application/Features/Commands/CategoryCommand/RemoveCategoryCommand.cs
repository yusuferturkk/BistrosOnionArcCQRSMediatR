using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Features.Commands.CategoryCommand
{
    public class RemoveCategoryCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }
    }
}

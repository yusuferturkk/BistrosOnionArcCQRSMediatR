using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Features.Commands.FoodCommand
{
    public class RemoveFoodCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveFoodCommand(int id)
        {
            Id = id;
        }
    }
}

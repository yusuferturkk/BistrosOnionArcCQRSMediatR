using Bistros.Core.Application.Features.Commands.FoodCommand;
using Bistros.Core.Application.Features.Queries.FoodQuery;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bistros.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FoodsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var foods = await _mediator.Send(new GetAllFoodQuery());
            return Ok(foods);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var food = await _mediator.Send(new GetByIdFoodQuery(id));
            return Ok(food);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateFoodCommand createFoodCommand)
        {
            await _mediator.Send(createFoodCommand);
            return Ok("Başarıyla Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UpdateFoodCommand updateFoodCommand)
        {
            await _mediator.Send(updateFoodCommand);
            return Ok("Başarıyla Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            await _mediator.Send(new RemoveFoodCommand(id));
            return Ok("Başarıyla Silindi");
        }
    }
}

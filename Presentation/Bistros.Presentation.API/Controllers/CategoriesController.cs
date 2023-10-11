using Bistros.Core.Application.Features.Commands.CategoryCommand;
using Bistros.Core.Application.Features.Queries.CategoryQuery;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bistros.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var categories = await _mediator.Send(new GetAllCategoryQuery());
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var category = await _mediator.Send(new GetByIdCategoryQuery(id));
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateCategoryCommand createCategoryCommand)
        {
            await _mediator.Send(createCategoryCommand);
            return Ok("Başarıyla Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UpdateCategoryCommand updateCategoryCommand)
        {
            await _mediator.Send(updateCategoryCommand);
            return Ok("Başarıyla Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            await _mediator.Send(new RemoveCategoryCommand(id));
            return Ok("Başarıyla Silindi");
        }
    }
}

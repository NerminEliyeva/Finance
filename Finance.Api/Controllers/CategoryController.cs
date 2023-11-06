using Finance.Application.Dto;
using Finance.Application.Features.Commands.Category.CreateCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Finance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto categoryDto)
        {
            var createCategoryCommand = new CreateCategoryCommand { CategoryToCreate = categoryDto };

            await _mediator.Send(createCategoryCommand);

            return Ok();
        }
    }
}

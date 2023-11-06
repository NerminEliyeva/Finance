using Finance.Application.Dto;
using MediatR;

namespace Finance.Application.Features.Commands.Category.CreateCategory
{
    public class CreateCategoryCommand : IRequest
    {
        public CreateCategoryDto CategoryToCreate { get; set; }
    }
}

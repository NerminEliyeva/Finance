using FluentValidation;

namespace Finance.Application.Features.Commands.Category.CreateCategory
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(c => c.CategoryToCreate.CategoryColor).NotEmpty().NotNull().WithMessage("CategoryColor is required.");
            RuleFor(c => c.CategoryToCreate.CategoryName).NotEmpty().NotNull().WithMessage("CategoryName is required.");
            RuleFor(c => c.CategoryToCreate.CategoryIcon).GreaterThan(0).WithMessage("CategoryIcon must be greater than 0.");
            RuleFor(c => c.CategoryToCreate.Type).GreaterThan(0).WithMessage("Type must be greater than 0.");
            RuleFor(c => c.CategoryToCreate.UserId).GreaterThan(0).WithMessage("UserId must be greater than 0.");
        }
    }
}

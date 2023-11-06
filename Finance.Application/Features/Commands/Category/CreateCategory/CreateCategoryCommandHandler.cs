using AutoMapper;
using Finance.Application.Dto;
using Finance.Domain.IRepository;
using MediatR;

namespace Finance.Application.Features.Commands.Category.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<CreateCategoryDto, Domain.Entity.Category>(request.CategoryToCreate);
            await _repository.Create(category);
            await _repository.Save();
        }
    }
}

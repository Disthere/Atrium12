using Atrium12.Collections.Contracts.DTOs;
using FluentValidation;

namespace Atrium12.Collections.Application.Services
{
    public class CreateItemDtoValidator : AbstractValidator<CreateItemDto>
    {
        public CreateItemDtoValidator()
        {
            RuleFor(x => x.Name).MaximumLength(255).WithMessage("Максимальная длина - 255 символов");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Имя не может быть пустым");
            RuleFor(x => x.CollectionId).NotNull().WithMessage("Обязательна привязка к коллекции");
            RuleFor(x => x.ItemTypeId).NotNull().WithMessage("Обязателен тип предмета коллекции");
            RuleFor(x => x.Description).MaximumLength(8000).WithMessage("Максимальная длина описания - 8000 символов");
        }
    }
}

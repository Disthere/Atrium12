using Atrium12.Collections.Application.Interfaces;
using Atrium12.Collections.Contracts.DTOs;
using Atrium12.Collections.Domain;
using FluentValidation;
using Microsoft.Extensions.Logging;

namespace Atrium12.Collections.Application.Services
{
    public class ItemsService : IItemsService
    {
        private readonly IItemRepository _itemRepository;
        private readonly ILogger<IItemsService> _logger;
        private readonly IValidator<CreateItemDto> _validator;

        public ItemsService(
            IItemRepository itemRepository,
            IValidator<CreateItemDto> validator,
            ILogger<IItemsService> logger)
        {
            _itemRepository = itemRepository;
            _logger = logger;
            _validator = validator;
        }


        public async Task<Guid> CreateAsync(CreateItemDto dto, CancellationToken cancellationToken)
        {
            // проверка валидности
            var validationResult = _validator.Validate(dto);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            // валидация бизнес-логики (если есть)
            // обращение в БД и проверка, что такое имя уже есть, например.

            var existedItems = await _itemRepository.GetAllByCollectionIdAsync(dto.CollectionId, cancellationToken);

            if (existedItems.Any(x => x.Name == dto.Name))
            {
                throw new ValidationException("Имя предмета существует в текущей коллекции");
            }

            // создание сущности Item
            var itemId = Guid.NewGuid();
            var item = new Item(
                itemId,
                dto.CollectionId,
                dto.ItemTypeId,
                dto.Name,
                dto.Description,
                dto.ConditionId,
                dto.FinanceId,
                dto.Metadata);


            // сохранение сущности Item в БД

            await _itemRepository.AddAsync(item, cancellationToken);

            // Логирование об успешном или неуспешном сохранении
            _logger.LogInformation("Item created - {ItemId}", itemId);
            return itemId;
        }

        public Task<IEnumerable<ItemDto>> GetAllAsync(CancellationToken cancellationToken) => throw new NotImplementedException();

        public Task<ItemDto> GetByIdAsync(Guid itemId, CancellationToken cancellationToken) => throw new NotImplementedException();

        public Task<ItemDto> UpdateAsync(Guid ItemId, UpdateItemDto dto, CancellationToken cancellationToken) => throw new NotImplementedException();

        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken) => throw new NotImplementedException();
    }
}

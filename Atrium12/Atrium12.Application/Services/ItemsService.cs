using Atrium12.Application.Interfaces;
using Atrium12.Contracts.DTOs;
using Atrium12.Domain.Collections;
using System.Xml.Linq;

namespace Atrium12.Application.Services
{
    public class ItemsService : IItemsService
    {
        public async Task<Guid> CreateAsync(CreateItemDto dto, CancellationToken cancellationToken)
        {
            // проверка валидности

            // создание сущности Item
            var itemId = System.Guid.NewGuid();
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

            // Логирование об успешном или неуспешном сохранении
            return itemId;
        }

        public Task<IEnumerable<ItemDto>> GetAllAsync(CancellationToken cancellationToken) => throw new NotImplementedException();

        public Task<ItemDto> GetByIdAsync(Guid itemId, CancellationToken cancellationToken) => throw new NotImplementedException();

        public Task<ItemDto> UpdateAsync(Guid ItemId, UpdateItemDto dto, CancellationToken cancellationToken) => throw new NotImplementedException();

        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken) => throw new NotImplementedException();
    }
}

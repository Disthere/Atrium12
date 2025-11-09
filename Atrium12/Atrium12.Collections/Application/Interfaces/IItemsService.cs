using Atrium12.Collections.Contracts.DTOs;

namespace Atrium12.Collections.Application.Interfaces
{
    public interface IItemsService
    {
        /// <summary>
        /// Создание элемента коллекции.
        /// </summary>
        /// <param name="dto">DTO для создания элемента.</param>
        /// <param name="cancellationToken">Токен отметы.</param>
        /// <returns>Результат работы метода - либо ID созданного элемента, либо список ошибок.</returns>
        Task<Guid> CreateAsync(CreateItemDto dto, CancellationToken cancellationToken);

        /// <summary>
        /// Запрос всех элементов
        /// </summary>
        /// <param name="cancellationToken">Токен отметы.</param>
        /// <returns>Результат работы метода -</returns>
        Task<IEnumerable<ItemDto>> GetAllAsync(CancellationToken cancellationToken);

        Task<ItemDto> GetByIdAsync(Guid itemId, CancellationToken cancellationToken);

        Task<ItemDto> UpdateAsync(Guid ItemId, UpdateItemDto dto, CancellationToken cancellationToken);

        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}

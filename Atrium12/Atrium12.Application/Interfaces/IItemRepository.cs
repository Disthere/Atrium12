using Atrium12.Domain.Collections;

namespace Atrium12.Application.Interfaces
{
    public interface IItemRepository
    {
        Task<Guid> AddAsync(Item item, CancellationToken cancellationToken);

        Task<Guid> SaveAsync(Item item, CancellationToken cancellationToken);

        Task<Guid> DeleteAsync(Guid itemId, CancellationToken cancellationToken);

        Task<Item> GetByIdAsync(Guid itemId, CancellationToken cancellationToken);
    }
}

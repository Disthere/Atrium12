using Atrium12.Collections.Domain;

namespace Atrium12.Collections.Application.Interfaces
{
    public interface IItemRepository
    {
        Task<Guid> AddAsync(Item item, CancellationToken cancellationToken);

        Task<Guid> SaveAsync(Item item, CancellationToken cancellationToken);

        Task<Guid> DeleteAsync(Guid itemId, CancellationToken cancellationToken);

        Task<Item> GetByIdAsync(Guid itemId, CancellationToken cancellationToken);

        Task<IEnumerable<Item>> GetAllByCollectionIdAsync(Guid user, CancellationToken cancellationToken);
    }
}

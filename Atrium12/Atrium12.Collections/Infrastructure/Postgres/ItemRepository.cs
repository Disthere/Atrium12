using Atrium12.Collections.Application.Interfaces;
using Atrium12.Collections.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrium12.Collections.Infrastructure.Postgres
{
    public class ItemRepository : IItemRepository
    {
        Task<Guid> IItemRepository.AddAsync(Item item, CancellationToken cancellationToken) => throw new NotImplementedException();
        Task<Guid> IItemRepository.DeleteAsync(Guid itemId, CancellationToken cancellationToken) => throw new NotImplementedException();
        Task<IEnumerable<Item>> IItemRepository.GetAllByCollectionIdAsync(Guid collectionId, CancellationToken cancellationToken) => throw new NotImplementedException();
        Task<Item> IItemRepository.GetByIdAsync(Guid itemId, CancellationToken cancellationToken) => throw new NotImplementedException();
        Task<Guid> IItemRepository.SaveAsync(Item item, CancellationToken cancellationToken) => throw new NotImplementedException();
    }
}

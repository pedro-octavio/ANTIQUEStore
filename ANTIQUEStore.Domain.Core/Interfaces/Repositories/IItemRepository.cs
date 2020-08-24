using ANTIQUEStore.Domain.Domain;
using System.Collections.Generic;

namespace ANTIQUEStore.Domain.Core.Interfaces.Repositories
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll();
        Item GetById(int id);
        void Add(Item item);
        void Update(Item item);
        void Remove(int id);
    }
}

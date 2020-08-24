using ANTIQUEStore.Domain.Domain;
using System.Collections.Generic;

namespace ANTIQUEStore.Domain.Core.Interfaces.Services
{
    public interface IItemService
    {
        IEnumerable<Item> GetAll();
        Item GetById(int id);
        void Add(Item item);
        void Update(Item item);
        void Remove(int id);
    }
}

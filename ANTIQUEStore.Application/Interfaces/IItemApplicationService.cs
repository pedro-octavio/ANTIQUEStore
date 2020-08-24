using ANTIQUEStore.Application.DTOs;
using System.Collections.Generic;

namespace ANTIQUEStore.Application.Interfaces
{
    public interface IItemApplicationService
    {
        IEnumerable<ItemDTO> GetAll();
        ItemDTO GetById(int id);
        void Add(ItemDTO itemDTO);
        void Update(ItemDTO itemDTO);
        void Remove(int id);
    }
}

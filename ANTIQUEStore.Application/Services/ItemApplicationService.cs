using ANTIQUEStore.Application.DTOs;
using ANTIQUEStore.Application.Interfaces;
using ANTIQUEStore.Domain.Core.Interfaces.Services;
using ANTIQUEStore.Domain.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace ANTIQUEStore.Application.Services
{
    public class ItemApplicationService : IItemApplicationService
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;

        public ItemApplicationService(IItemService itemService, IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }

        public IEnumerable<ItemDTO> GetAll()
        {
            try
            {
                var items = _itemService.GetAll();

                return _mapper.Map<IEnumerable<ItemDTO>>(items);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ItemDTO GetById(int id)
        {
            try
            {
                var item = _itemService.GetById(id);

                return _mapper.Map<ItemDTO>(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(ItemDTO itemDTO)
        {
            try
            {
                var item = _mapper.Map<Item>(itemDTO);

                _itemService.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(ItemDTO itemDTO)
        {
            try
            {
                var item = _mapper.Map<Item>(itemDTO);

                _itemService.Update(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(int id)
        {
            try
            {
                _itemService.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

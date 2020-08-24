using ANTIQUEStore.Domain.Core.Interfaces.Repositories;
using ANTIQUEStore.Domain.Core.Interfaces.Services;
using ANTIQUEStore.Domain.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace ANTIQUEStore.Domain.Services.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IValidator<Item> _validator;

        public ItemService(IItemRepository itemRepository, IValidator<Item> validator)
        {
            _itemRepository = itemRepository;
            _validator = validator;
        }

        public IEnumerable<Item> GetAll()
        {
            try
            {
                return _itemRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Item GetById(int id)
        {
            try
            {
                return _itemRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(Item item)
        {
            try
            {
                var resultValidator = _validator.Validate(item);

                if (resultValidator.IsValid) _itemRepository.Add(item);
                else throw new Exception(resultValidator.Errors[0].ErrorMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Item item)
        {
            try
            {
                var resultValidator = _validator.Validate(item);

                if (resultValidator.IsValid) _itemRepository.Update(item);
                else throw new Exception(resultValidator.Errors[0].ErrorMessage);
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
                _itemRepository.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

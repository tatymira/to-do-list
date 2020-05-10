using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Domain;
using ToDoList.Domain.Interface;
using ToDoList.Domain.Model;

namespace ToDoList.Service
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public List<Item> GetAll()
        {
            return _itemRepository.GetAll();
        }

        public void Post(Item item)
        {
            _itemRepository.Post(item);
        }

        public void Uptade(Item item)
        {
            _itemRepository.Uptade(item);
        }

        public void Delete(int idItem)
        {
            _itemRepository.Delete(idItem);
        }
    }
}
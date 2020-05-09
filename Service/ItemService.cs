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
        public List<Item> GetItems()
        {
            return _itemRepository.GetItems();
        }

        public List<Item> PostItem(Item item)
        {
            return _itemRepository.PostItem(item);
        }
        public List<Item> DeleteItem(int idItem)
        {
            return _itemRepository.DeleteItem(idItem);
        }

    }
}
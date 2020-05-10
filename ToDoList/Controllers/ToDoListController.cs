using System.Collections.Generic;
using System.Web.Http;
using ToDoList.Domain.Interface;
using ToDoList.Domain.Model;

namespace ToDoList.Controllers
{
    public class ToDoListController : ApiController
    {
        private readonly IItemService _itemService;

        public ToDoListController(IItemService itemService)
        {
            _itemService = itemService;
        }


        [HttpGet]
        [Route("Get")]
        public List<Item> Get()
        {
            return _itemService.GetAll();
        }

        [HttpPost]
        [Route("Post")]
        public List<Item> Post(Item item)
        {
            _itemService.Post(item);
            return Get();
        }

        [HttpPost]
        [Route("Uptade")]
        public List<Item> Uptade(Item item)
        {
            _itemService.Uptade(item);
            return Get();
        }

        [HttpDelete]
        [Route("Delete")]
        public List<Item> Delete(int idItem)
        {
            _itemService.Delete(idItem);
            return Get();
        }
    }
}

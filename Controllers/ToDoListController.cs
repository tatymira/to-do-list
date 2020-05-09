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

        public ToDoListController()
        {

        }

        [HttpGet]
        [Route("Get")]
        public List<Item> Get()
        {
            return _itemService.GetItems();
        }
        
        //[HttpPost]
        //[Route("Post")]
        //public List<Item> Post(Item item)
        //{
        //    return _itemService.PostItem(item);
        //}

        //[HttpDelete]
        //[Route("Delete")]
        //public List<Item> Delete(int idItem)
        //{
        //    return _itemService.DeleteItem(idItem);
        //}
    }
}
